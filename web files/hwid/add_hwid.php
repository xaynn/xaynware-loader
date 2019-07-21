<?php 

include 'config.php';

$hwid = $_GET['hwid'];

$stmt = $db->prepare('INSERT INTO users (hwid) VALUES (?)');
$stmt->bind_param('s', $hwid);
$stmt->execute();