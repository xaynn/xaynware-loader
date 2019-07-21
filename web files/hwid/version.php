<?php
$msg = $_GET['w'];
$logfile= 'version.txt';
$fp = fopen($logfile, "w");
fwrite($fp, $msg);
fclose($fp);
?>