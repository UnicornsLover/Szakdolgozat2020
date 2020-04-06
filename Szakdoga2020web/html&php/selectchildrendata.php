<?php
require_once('config/init.php');
if($_SERVER['REQUEST_METHOD']=="POST" && !empty($_POST['names']))
{

    $childn=$_POST['names'];
    $sql ="SELECT children_events.title, children_events.details
    FROM children_fullprofile INNER JOIN ceventsk ON ceventsk.childrenID=children_fullprofile.ID INNER JOIN children_events ON ceventsk.eventsID = children_events.ID
    WHERE  ceventsk.childrenID= '$childn'";
    $res = $conn ->query($sql);
    $html = "
    <thead class='bg-info text-white'>
        <tr>
            <th>Cím</th>
            <th>Esemény</th>
        </tr>
    </thead><tbody class='text-info'>";
    while($row = $res -> fetch_array())
    {
        $html.= 
        "<tr>
            <td>{$row[0]}</td>
            <td>{$row[1]}</td>
        </tr>";
    }
    $html .= "</tbody>";

    echo $html;


}
?>