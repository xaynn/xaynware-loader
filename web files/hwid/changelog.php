<?php 

include 'config.php';

$change = $_GET['change'];

$stmt = $db->prepare('INSERT INTO changelog (msg) VALUES (?)');
$stmt->bind_param('s', $change);
$stmt->execute();