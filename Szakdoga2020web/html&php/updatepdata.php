<?php
require_once('config/init.php');
    if (!empty($_POST['regusername']) && (!empty($_POST['idcard']) && $_SERVER["REQUEST_METHOD"]=="POST")) //data-ba ami van ajax
    {
        $azon = $_SESSION["azonosito"];
        $name = $_POST['name'];
        $birth = $_POST['birth'];
        $idcard = $_POST['idcard'];
        $username = $_POST['regusername'];
        $password = $_POST['password'];
        $sql = "UPDATE `parents` SET `pname`= '$name', `pbirth`= '$birth', `pidcardnumber`= '$idcard', `loginuser`= '$username', `loginpsw`= '$password', `reg`=1 WHERE `ID` = '$azon';";
        $res = $conn -> query($sql);
        if (!$res){
            die("Hiba a bejelentkezéskor!");
            echo 0;
        }
        else
        {
            echo 1;
        }

    }
