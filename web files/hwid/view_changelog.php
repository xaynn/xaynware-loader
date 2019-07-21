<?php 

include 'config.php';

$stmt = $db->prepare('SELECT * FROM changelog ORDER BY time DESC');
$stmt->execute();

$result = $stmt->get_result();

while ($obj = mysqli_fetch_object($result)) {  
  echo "\n" . $obj->time . "\n\n - " . $obj->msg . ' ';  
}