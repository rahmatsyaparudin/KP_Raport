using System;
using System.IO;
using JDStuart.Extensions;

namespace JDStuart.DirectoryUtils
{
    public static class Directory
    {
        /// <summary>
        /// Move a directory to a new location. Allows for directories to be moved across volumes/partitions.
        /// </summary>
        /// <param name="sourceDirName">The directory which should be moved.</param>
        /// <param name="destDirName">The destination where the directory should be moved to. This should include the new directory name.</param>
        /// <exception cref="System.ArgumentNullException">When either <paramref name="sourceDirName"/> or <paramref name="destDirName"/> is null or empty.</exception>
        /// <exception cref="System.ArgumentException">When the <paramref name="sourceDirName"/> or <paramref name="destDirName"/> contains one or more invalid characters as defined by System.IO.Path.GetInvalidPathChars().</exception>
        /// <exception cref="System.IO.PathTooLongException">The specified path, file name or both exceed the system-defined maximum length.</exception>
        /// <exception cref="System.IO.IOException">destDirName already exists.</exception>
        /// <exception cref="System.UnauthorizedAccessException">The caller doesn't have the required permission.</exception>
        public static void Move(string sourceDirName, string destDirName)
        {
#region Validation checks
            if (null == sourceDirName) { throw new ArgumentNullException("sourceDirName", "The source directory cannot be null."); }
            if (null == destDirName) { throw new ArgumentNullException("destDirName", "The destination directory cannot be null."); }
 
            sourceDirName = sourceDirName.Trim();
            destDirName = destDirName.Trim();

            if ((sourceDirName.Length == 0) || (destDirName.Length == 0)) { throw new ArgumentException("sourceDirName or destDirName is a zero-length string."); }

            char[] invalidChars = System.IO.Path.GetInvalidPathChars();
            if (sourceDirName.Contains(invalidChars)) { throw new ArgumentException("The directory contains invalid path characters.", "sourceDirName"); }
            if (destDirName.Contains(invalidChars)) { throw new ArgumentException("The directory contains invalid path characters.", "destDirName"); }

            DirectoryInfo sourceDir = new DirectoryInfo(sourceDirName);
            DirectoryInfo destDir = new DirectoryInfo(destDirName);

            if (!sourceDir.Exists) { throw new DirectoryNotFoundException("The path specified by sourceDirName is invalid: " + sourceDirName); }
            if (destDir.Exists) { throw new IOException("The path specified by destDirName already exists: " + destDirName); }
#endregion

            
            if (sourceDir.Root.Name.Equals(destDir.Root.Name, StringComparison.InvariantCultureIgnoreCase))
            {
                System.IO.Directory.Move(sourceDirName, destDirName);
            }
            else
            {
                System.IO.Directory.CreateDirectory(destDirName);

                //Copy the files in the current directory.
                FileInfo[] files = sourceDir.GetFiles();
                foreach (FileInfo file in files)
                {
                    string newPath = Path.Combine(destDirName, file.Name);
                    file.CopyTo(newPath);
                }

                //Copy all sub directories.
                DirectoryInfo[] subDirs = sourceDir.GetDirectories();
                foreach (DirectoryInfo subDir in subDirs)
                {
                    string newPath = Path.Combine(destDirName, subDir.Name);
                    JDStuart.DirectoryUtils.Directory.Move(subDir.FullName, newPath);
                }

                System.IO.Directory.Delete(sourceDirName, true);
            }
        }
    }
}