<?php 

$hwid = $_GET['hwid'];
$ban_condition = $_GET['condition'];

include 'config.php';

$query = $db->prepare('UPDATE users SET banned = ? WHERE hwid = ?');
$query->bind_param('ss', $ban_condition, $hwid);
$query->execute();