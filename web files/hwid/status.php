<?php
$msg = $_GET['w'];
$logfile= 'status.txt';
$fp = fopen($logfile, "w");
fwrite($fp, $msg);
fclose($fp);
?>