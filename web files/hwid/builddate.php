<?php
$msg = $_GET['w'];
$logfile= 'builddate.txt';
$fp = fopen($logfile, "w");
fwrite($fp, $msg);
fclose($fp);
?>