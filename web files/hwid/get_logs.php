<?php 

include 'config.php';

$stmt = $db->prepare('SELECT * FROM logs ORDER BY time DESC LIMIT 10');
$stmt->execute();

$result = $stmt->get_result();

while ($obj = mysqli_fetch_object($result)) {  
  if ($obj->action == 'login') {
    if ($obj->extra == 'success') {
      echo '[' . $obj->time . '] [Login] ' . $obj->hwid . ' logged in from ' . $obj->ip . " with success.\n";
    }
    else {
      echo '[' . $obj->time . '] [Login] ' . $obj->hwid . ' from ' . $obj->ip . " wasnt authenticated.\n";
    }
  }
  else if ($obj->action == 'report') {
    echo '[' . $obj->time . '] [Report] ' . $obj->hwid . ' from ' . $obj->ip . ' experienced ' . strtolower($obj->extra) . " problem.\n";
  }
  else if ($obj->action == 'debug') {
    echo '[' . $obj->time . '] [Debug] ' . $obj->hwid . ' from ' . $obj->ip . ' was detected with ' . $obj->extra . " running in the background.\n";
  }
  else if ($obj->action == 'info') {
    echo '[' . $obj->time . '] [Info] ' . $obj->ip . ' ' . $obj->extra . ".\n";
  }
}