<?php

require_once('config/init.php');
if (!empty($_POST['rusername']) && (!empty($_POST['rpassword'])) && ($_SERVER["REQUEST_METHOD"]=="POST")) {
    $username = $_POST['rusername'];
    $pwd = $_POST['rpassword'];
    $sql = "SELECT * FROM parents WHERE loginuser = '$username' AND loginpsw = '$pwd' AND loginpermission =1 AND reg=0";
    $res = $conn -> query($sql);
    if (!$res){
        die("Hibás bejelentkezés!");
    }
    if ($res -> num_rows == 1){
        //sikeres a belépés
        $row = $res -> fetch_assoc();
        $_SESSION['azonosito'] = $row['ID'];
        echo "1";
    } else 
    {
        //sikertelen bejelentkezési kísérlet
        echo "0";
    }

}


?>
