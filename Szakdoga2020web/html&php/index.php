<?php
require_once('config/init.php');
printHTML("header.html");
if(!isLogged())
{
    echo menu();
}
else
{
    echo menuin();
}
printHTML("homepage2.html");
$conn -> close();

