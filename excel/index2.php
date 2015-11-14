<html>
<head>
<title>Upload page</title>
</head>
<body>
<?php
//KONEKSI.. 
$host='localhost';
$username='root';
$password='';
$db='db_smanjak1';
mysql_connect($host,$username,$password);
mysql_select_db($db);

if (isset($_POST['csvFile'])){
	if(!empty($_FILES['csvFile']['tmp_name'])){
			$file = $_FILES['csvFile']['tmp_name'];
			$openFile = fopen($file, "r");

			while (($dataFileFile = fgetcsv($openFile, 3000, ","))) {
				if($number != 1){
					$import="INSERT into siswa values('$dataFile[0]','$dataFile[1]','$dataFile[2]','$dataFile[3]','$dataFile[4]','$dataFile[5]','$dataFile[6]','$dataFile[7]','$dataFile[8]','$dataFile[9]','$dataFile[10]','$dataFile[11]','$dataFile[12]','$dataFile[13]')"; //dataFile array sesuaikan dengan jumlah kolom pada CSV anda mulai dari “0” bukan “1”
        			mysql_query($import) or die(mysql_error()); //Melakukan Import
				}
			}
			fclose($openFile); //Menutup CSV file
    		echo "<br><strong>Import dataFile selesai.</strong>";
		
	} else {
		echo "Anda belum memilih file CSV";
	}
}
?>

<form action="" method="POST" enctype="multipart/form-dataFile">
	<input type="file" name="csvFile"/>
	<input type="submit" name="upload" value="Import CSV File">
</form>
</body>
</html>
