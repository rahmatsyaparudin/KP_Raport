<html>
<head>
<title>Upload page</title>
</head>
<body>


<!-- Form Untuk Upload File CSV-->
   Silahkan masukan file csv yang ingin diupload<br /> 
   <form enctype='multipart/form-data' action='' method='post'>
    Cari CSV File anda:<br />
	<input type='file' name='filename' size='100'>
   <input type='submit' name='submit' value='Upload'></form>

<?php
//KONEKSI.. 
$host='localhost';
$username='root';
$password='';
$database='db_smanjak1';
mysql_connect($host,$username,$password);
mysql_select_db($database);

if (isset($_POST['submit'])) {//Script akan berjalan jika di tekan tombol submit..
		//Script Upload File..
	    if (is_uploaded_file($_FILES['filename']['tmp_name'])) {
	        echo "<h1>" . "File ". $_FILES['filename']['name'] ." Berhasil di Upload" . "</h1>";
	    }

	    //Import uploaded file to Database, Letakan dibawah sini..
	    $handle = fopen($_FILES['filename']['tmp_name'], "r"); //Membuka file dan membacanya
	    while (($data = fgetcsv($handle, 1000, ",")) !== FALSE) {
	        $siswa = mysql_query("INSERT into siswa values('$data[0]','$data[1]','$data[2]',
	        	'$data[3]','$data[4]','$data[5]','$data[6]','$data[7]','$data[8]','$data[9]',
	        	'$data[10]','$data[11]','$data[12]','$data[13]')") or die(mysql_error());
	        $ortu = mysql_query("INSERT into orangtua values(DEFAULT, '$data[0]','$data[14]','$data[15]',
	        	'$data[16]','$data[17]','$data[18]','$data[19]','$data[20]','$data[21]',
	        	'$data[22]')") or die(mysql_error());
	    }

	    fclose($handle); //Menutup CSV file
	    echo "<br><strong>Import data selesai.</strong>";
}else { 

} mysql_close(); ?>
</body>
</html>
