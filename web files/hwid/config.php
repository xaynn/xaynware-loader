<?php 

$db = new mysqli('localhost', 'root', 'pass123', 'nameofdatabase');

if ($db->connect_error) {
  die('Connection failed. ' . $db->connect_error);
}