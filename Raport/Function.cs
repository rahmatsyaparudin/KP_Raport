using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Security.Cryptography;

namespace Raport
{
    class Function
    {
        string ConnString;
        public static string IV = "asercvyunm135790";
        public static string Key = "1234567890qazwsxedcrfvtgbyhnujmi";
        public static string host = ConfigurationManager.AppSettings["host"];
        public static string user = ConfigurationManager.AppSettings["user"];
        public static string pass = ConfigurationManager.AppSettings["pass"];
        public static string dbms = ConfigurationManager.AppSettings["dbms"];
        public static string port = ConfigurationManager.AppSettings["port"];
        public static string connStr = "server='" + host + "';port='" + port + "';username='" + user + "';password='" + pass +
                                        "';database='" + dbms + "';UseCompression=True";

        public Function()
        {
            ConnString = connStr;
        }

        public static MySqlConnection getKoneksi()
        {
            string server = connStr;
            MySqlConnection connection = new MySqlConnection(server);
            return connection;
        }

        public void ExecuteNonQuery(string Query)
        {
            MySqlConnection myConn = new MySqlConnection(ConnString);
            myConn.Open();
            MySqlCommand myComm = new MySqlCommand(Query, myConn);
            myComm.ExecuteNonQuery();
            myConn.Close();
        }

        // -> tambah data > INSERT INTO <namatabel> (namafield1,namafield2,..) VALUES ('nilaifield1','nilaifield2',..)
        public void insertData(string table, string field)
        {
            MySqlConnection myConn = new MySqlConnection(ConnString);
            string query = "INSERT INTO " + table + " VALUES( " + field + " )" ;
            myConn.Open();
            MySqlCommand myComm = new MySqlCommand(query, myConn);
            myComm.ExecuteNonQuery();
            myConn.Close();
        }


        // -> ubah data  > UPDATE <namatabel> SET namafield='nilaifield',namafield2=nilaifield2,.. [WHERE kondisi]
        public void deleteData(string table, string cond)
        {
            MySqlConnection myConn = new MySqlConnection(ConnString);
            string query = "DELETE FROM " + table + " WHERE " + cond;
            myConn.Open();
            MySqlCommand myComm = new MySqlCommand(query, myConn);
            myComm.ExecuteNonQuery();
            myConn.Close();
        }

        public void updateData(string table, string field, string cond)
        {
            MySqlConnection myConn = new MySqlConnection(ConnString);
            string query = "UPDATE " + table + " SET " + field + " WHERE " + cond;
            myConn.Open();
            MySqlCommand myComm = new MySqlCommand(query, myConn);
            myComm.ExecuteNonQuery();
            myConn.Close();
        }

        public void sortData(string field, string table, string cond)
        {
            MySqlConnection myConn = new MySqlConnection(ConnString);
            string query = "SELECT " + field + " FROM " + table + " WHERE " + cond;
            myConn.Open();
            MySqlCommand myComm = new MySqlCommand(query, myConn);
            myComm.ExecuteNonQuery();
            myConn.Close();
        }

        public DataTable GetDataTable(string field, string table, string cond)
        {
            DataTable result = new DataTable();
            MySqlConnection MyConn = new MySqlConnection(ConnString);
            MyConn.Open();
            string query = "SELECT " + field + " FROM " + table + " WHERE " + cond;
            MySqlCommand MyComm = new MySqlCommand(query, MyConn);
            MySqlDataReader myReader = MyComm.ExecuteReader();
            result.Load(myReader);
            MyConn.Close();
            return result;
        }

        public DataTable setCombo(string idValue, string dispValue, string table, string cond, string sortby)
        {
            DataTable result = new DataTable();
            MySqlConnection MyConn = new MySqlConnection(ConnString);
            MyConn.Open();
            string query = "SELECT " + idValue + ", " + dispValue + " FROM " + table + " WHERE " + cond + " ORDER BY " + sortby;
            MySqlCommand MyComm = new MySqlCommand(query, MyConn);
            MySqlDataReader myReader = MyComm.ExecuteReader();
            DataColumn dc1 = new DataColumn("valueID");
            DataColumn dc2 = new DataColumn("valueDisplay");
            result.Columns.Add(dc1);
            result.Columns.Add(dc2);
            result.Rows.Add("", "");
            while (myReader.Read())
            {
                string sName = myReader.GetString(dispValue);
                string sId = myReader.GetString(idValue);
                result.Rows.Add(sId, sName);
            }
            MyConn.Close();
            return result;
        }
        
        public DataTable getTahuj()
        {
            DataTable result = new DataTable();
            DataColumn dc1 = new DataColumn("valueDisplay");
            result.Columns.Add(dc1);
            result.Rows.Add("");
            result.Rows.Add("2015/2016");
            result.Rows.Add("2016/2017");
            result.Rows.Add("2017/2018");
            result.Rows.Add("2018/2019");
            result.Rows.Add("2019/2020");
            result.Rows.Add("2020/2021");
            return result;
        }

        public DataTable getPredikat()
        {
            DataTable result = new DataTable();
            DataColumn dc1 = new DataColumn("valueDisplay");
            result.Columns.Add(dc1);
            result.Rows.Add("");
            result.Rows.Add("A");
            result.Rows.Add("A-");
            result.Rows.Add("B+");
            result.Rows.Add("B");
            result.Rows.Add("B-");
            result.Rows.Add("C+");
            result.Rows.Add("C");
            result.Rows.Add("C-");
            result.Rows.Add("D+");
            result.Rows.Add("D");
            return result;
        }

        public DataTable getSmt()
        {
            DataTable result = new DataTable();
            DataColumn dc1 = new DataColumn("valueID");
            DataColumn dc2 = new DataColumn("valueDisplay");
            result.Columns.Add(dc1);
            result.Columns.Add(dc2);
            result.Rows.Add("", "");
            result.Rows.Add("SMT1", "Semester 1");
            result.Rows.Add("SMT2", "Semester 2");
            return result;
        }

        public DataTable getDesk()
        {
            DataTable result = new DataTable();
            DataColumn dc1 = new DataColumn("valueID");
            DataColumn dc2 = new DataColumn("valueDisplay");
            result.Columns.Add(dc1);
            result.Columns.Add(dc2);
            result.Rows.Add("", "");
            result.Rows.Add("A", "A");
            result.Rows.Add("T", "T");
            result.Rows.Add("B", "B");
            return result;
        }

        public DataTable getAgama()
        {
            DataTable result = new DataTable();
            DataColumn dc1 = new DataColumn("valueDisplay");
            result.Columns.Add(dc1);
            result.Rows.Add("");
            result.Rows.Add("Islam");
            result.Rows.Add("Kristen");
            result.Rows.Add("Budha");
            result.Rows.Add("Katolik");
            result.Rows.Add("Hindu");
            return result;
        }

        public DataTable getKelamin()
        {
            DataTable result = new DataTable();
            DataColumn dc1 = new DataColumn("valueDisplay");
            result.Columns.Add(dc1);
            result.Rows.Add("");
            result.Rows.Add("Laki-Laki");
            result.Rows.Add("Perempuan");
            return result;
        }

        public DataTable getAngka()
        {
            DataTable result = new DataTable();
            DataColumn dc1 = new DataColumn("valueDisplay");
            result.Columns.Add(dc1);
            result.Rows.Add("");
            for (int i = 1; i <= 9; i++)
            {
                result.Rows.Add(i);
            }
            return result;
        }

        public DataTable getKategori()
        {
            DataTable result = new DataTable();
            DataColumn dc1 = new DataColumn("valueDisplay");
            result.Columns.Add(dc1);
            result.Rows.Add("");
            result.Rows.Add("Kelompok A");
            result.Rows.Add("Kelompok B");
            result.Rows.Add("Kelompok C");
            return result;
        }

        public DataTable getStatusAnak()
        {
            DataTable result = new DataTable();
            DataColumn dc1 = new DataColumn("valueDisplay");
            result.Columns.Add(dc1);
            result.Rows.Add("");
            result.Rows.Add("Anak Kandung");
            result.Rows.Add("Anak Angkat");
            result.Rows.Add("Anak Asuh");
            return result;
        }

        public String randomIdGuru()
        {
            Random rnd = new Random();
            int angka = rnd.Next(100000);
            string idGuru = angka.ToString();
            return idGuru;
        }

        public String capitalizeWord(string str)
        {
            return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str);
        }

        public string SHA1(string data)
        {
            SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();
            sha1.ComputeHash(ASCIIEncoding.ASCII.GetBytes(data));
            byte[] sh = sha1.Hash;
            StringBuilder sb = new StringBuilder();
            foreach (byte b in sh)
            {
                sb.Append(b.ToString("x2"));
            }
            return sb.ToString();
        }

        public string Encrypt(string data)
        {
            byte[] textbytes = ASCIIEncoding.ASCII.GetBytes(data);
            AesCryptoServiceProvider aes = new AesCryptoServiceProvider();
            aes.BlockSize = 128;
            aes.KeySize = 256;
            aes.Key = ASCIIEncoding.ASCII.GetBytes(Key);
            aes.IV = ASCIIEncoding.ASCII.GetBytes(IV);
            aes.Padding = PaddingMode.PKCS7;
            aes.Mode = CipherMode.CBC;

            ICryptoTransform icrypt = aes.CreateEncryptor(aes.Key, aes.IV);

            byte[] enc = icrypt.TransformFinalBlock(textbytes, 0, textbytes.Length);
            icrypt.Dispose();
            return Convert.ToBase64String(enc);
        }

        public string Decrypt(string data)
        {
            byte[] encbytes = Convert.FromBase64String(data);
            AesCryptoServiceProvider aes = new AesCryptoServiceProvider();
            aes.BlockSize = 128;
            aes.KeySize = 256;
            aes.Key = ASCIIEncoding.ASCII.GetBytes(Key);
            aes.IV = ASCIIEncoding.ASCII.GetBytes(IV);
            aes.Padding = PaddingMode.PKCS7;
            aes.Mode = CipherMode.CBC;

            ICryptoTransform icrypt = aes.CreateDecryptor(aes.Key, aes.IV);

            byte[] dec = icrypt.TransformFinalBlock(encbytes, 0, encbytes.Length);
            icrypt.Dispose();
            return ASCIIEncoding.ASCII.GetString(dec);
        }
    }
}