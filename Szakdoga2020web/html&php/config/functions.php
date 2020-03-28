<?php

function printHTML($html) {
    echo file_get_contents($html);
}

function isLogged() {
    if (!empty($_SESSION['uid'])) {
        return true;
    } else {
        return false;
    }
}

function logOut() {
    unset($_SESSION['uid']);
    header("Location: index.php");
}

function menu() {
    $menu = file_get_contents('../html&php/menu.html');
    
    return $menu;
}
function menuin() {
    $menu = file_get_contents('../html&php/menuin.html');
    
    return $menu;
}
function child() {
    $menu = file_get_contents('../html&php/childchecker.html');
    
    return $menu;
}

?>