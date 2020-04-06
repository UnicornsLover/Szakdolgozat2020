<?php
require_once('config/init.php');
if($_SERVER['REQUEST_METHOD']=="POST" && !empty($_POST['names']))
{

    $childn=$_POST['names'];
    $sql ="SELECT children_healths.type,children_healths.details,children_healths.special_treatment,children_healths.treatdate,children_healths.by
    FROM children_fullprofile INNER JOIN children_healths ON children_fullprofile.ID = children_healths.childrenID
    WHERE children_healths.childrenID= '$childn'";
    $res = $conn ->query($sql);
    $html = "
    <thead class='bg-info text-white'>
        <tr>
            <th>Tipusa</th>
            <th>Leírás</th>
            <th>Különleges bánásmód</th>
            <th>Vizsgálat dátuma</th>
            <th>Orvos</th>
        </tr>
    </thead><tbody class='text-info'>";
    while($row = $res -> fetch_array())
    {
        $html.= 
        "<tr>
            <td>{$row[0]}</td>
            <td>{$row[1]}</td>
            <td>{$row[2]}</td>
            <td>{$row[3]}</td>
            <td>{$row[4]}</td>
        </tr>";
    }
    $html .= "</tbody>";

    echo $html;


}
?>