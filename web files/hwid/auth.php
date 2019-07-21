<?php 

include 'config.php';

$hwid = $_GET['hwid'];
$banned = false;

$stmt = $db->prepare('SELECT * FROM users WHERE hwid = ? AND banned = ?');
$stmt->bind_param('ss', $hwid, $banned);
$stmt->execute();

$result = $stmt->get_result();

if ($result->num_rows > 0) {
  echo 'success';
}
else {
  echo 'invalid';
}