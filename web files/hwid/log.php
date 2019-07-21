<?php 

include 'config.php';

$hwid = $_GET['hwid'];
$ip = $_GET['ip'];
$action = $_GET['action'];
$extra = $_GET['extra'];

if (!isset($hwid)) {
  $stmt = $db->prepare('INSERT INTO logs (action, ip, extra) VALUES (?, ?, ?)');
  $stmt->bind_param('sss', $action, $ip, $extra);
  $stmt->execute();
}
else {
  $stmt = $db->prepare('INSERT INTO logs (action, hwid, ip, extra) VALUES (?, ?, ?, ?)');
  $stmt->bind_param('ssss', $action, $hwid, $ip, $extra);
  $stmt->execute();
}

