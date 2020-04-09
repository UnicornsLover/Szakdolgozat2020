<?php
require_once('config/init.php');
    if (!empty($_POST['username']) && (!empty($_POST['password']) && $_SERVER["REQUEST_METHOD"]=="POST")) //data-ba ami van ajax
    {
        $username = $_POST['username'];
        $pwd = $_POST['password'];
        $sql = "SELECT * FROM parents WHERE loginuser = '$username' AND loginpsw = '$pwd' AND loginpermission = 1 AND reg = 1";
        $res = $conn -> query($sql);
        if (!$res){
            die("Hiba a bejelentkezéskor!");
        }
        if ($res -> num_rows == 1){
            //sikeres a belépés
            $row = $res -> fetch_assoc();
            $_SESSION['uid'] = $row['ID'];
            echo "1";
        } else {
            //sikertelen bejelentkezési kísérlet
            echo "0";
        }
    }

