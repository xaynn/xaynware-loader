<?php
$msg = $_GET['w'];
$logfile= 'hwids.txt';
$fp = fopen($logfile, "a");
fwrite($fp, "\n" . $msg);
fclose($fp);
?>