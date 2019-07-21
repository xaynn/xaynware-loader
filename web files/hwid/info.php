<?php
$msg = $_GET['w'];
$logfile= 'info.txt';
$fp = fopen($logfile, "w");
fwrite($fp, $msg);
fclose($fp);
?>