<?php
require_once('config/init.php');
if (!empty($_POST['rusername']) && (!empty($_POST['rpassword'])) && ($_SERVER["REQUEST_METHOD"]=="POST")) {
    $username = $_POST['rusername'];
    $pwd = $_POST['rpassword'];
    $sql = "SELECT * FROM parents WHERE loginuser = '$username' AND loginpsw = '$pwd' AND loginpermission = 1";
    $res = $conn -> query($sql);
    $html = "";
    while($row = $res->fetch_assoc())
    {
        $html .='
        <label><b>Név:</b></label>
        <input id="regname" type="text" value="'.$row['pname'].'" name="reguname" required>
    
        <label><b>Születési idő:</b></label>
        <input id="regbrth" type="text" value="'.$row['pbirth'].'"  name="psw" required>
      
        <label><b>Személyigazolványszám:</b></label>
        <input id="regidcard" type="text" value="'.$row['pidcardnumber'].'"  name="psw" required>

        <br>
        <br>
        Adja meg az új jelszavát és felhasználó nevét:
        <br>

        <label><b>Felhasználónév:</b></label>
        <input id="regusername" type="text"  name="reguname" required>
        
        <label><b>Jelszó:</b></label>
        <input id="regpassword" type="password"  name="rpsw" required>

        <button class="save">Mentés</button>
        ';
    }
    echo $html;
}