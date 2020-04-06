<?php
require_once('config/init.php');
printHTML("header.html");
if(!isLogged())
{
    echo menu();
}
else
{
    echo child();
}
?>
<section id="up" class="start-area">
        <div class="start-img"></div>  
        <h1 class="slower animated bounceInLeft">Live <sup>in</sup> Care gyerek nézegetője</h1>
        <?php
          if(isLogged())
          {
            $parentId = $_SESSION['uid'];
            $sql ="SELECT children_fullprofile.cname,children_healths.type,children_healths.details,children_healths.special_treatment,children_healths.treatdate,children_healths.by
            FROM children_fullprofile INNER JOIN children_healths ON children_fullprofile.ID = children_healths.childrenID INNER JOIN parentsk ON children_fullprofile.ID = parentsk.childrenID
            WHERE parentsk.pID = '$parentId'";
            $res = $conn -> query($sql);
            $total = mysqli_num_rows($res);
            //echo $total;
            $msg= "";
            if(!$res)
            {
              die("Hibás lekérdezés!");
            }
            else
            {
              if($total == 0)
              {
                echo "<h2 style='color:#00aba9;'>Nincs gyereked regisztrálva a rendszerünkbe!</h2>";
              }
              else
              {
                
              
              while($row=$res -> fetch_array())
              {
        ?>
        <div class="container">
          <div class="row">
            <div class="col-lg-12">
              <table class="table table-light table-borderless table-striped">
                <thead class="tabletop">
                  <tr>
                    <th>Gyermek</th>
                    <th>Tipusa</th>
                    <th>Leírás</th>
                    <th>Különleges bánásmód</th>
                    <th>Időpont</th>
                    <th>Orvos</th>
                  </tr>
                </thead>
                <tbody class="tbodycol">
                  <tr>
                    <td><?php echo "\n".$row[0];?></td>
                    <td><?php echo $row[1];?></td>
                    <td><?php echo $row[2];?></td>
                    <td><?php echo $row[3];?></td>
                    <td><?php echo $row[4];?></td>
                    <td><?php echo $row[5];?></td>
                  </tr>
                </tbody>
              </table>
            </div>
          </div>
        </div>
        <?php 
              }
            }
          } 
        }?>
</section>
<!---------------------------------Footer--------------------------------->
<section id="midpic2" id="conts">
  </section>
  <footer class="page-footer font-small blue pt-4" id="const">
      <div class="container-fluid text-center text-md-left">
          <div class="row">
            <div class="col-md-6 mt-md-0 mt-3">
              <h5 class="text-uppercase">Elérhetőség:</h5>
              <p>&#128616; Cég neve: Live <sup>in</sup> Care ©</p>
              <p>&#9742; Telefonszám: 06704853698</p>
              <p>&#8982; Telephely: Szeged, József Attila utca 13.</p>
              <p>&#128231; Email cím: liveincare@gmail.com</p>
            </div>
            <hr class="clearfix w-100 d-md-none pb-3">
            <div class="col-md-3 mb-md-0 mb-3">
              <h5 class="text-uppercase">Menü:</h5>
              <ul class="list-unstyled">
                <li>
                  <a href="index.php" style="text-decoration: none">Kezdőlap</a>
                </li>
                <li>
                  <a href="#quote" style="text-decoration: none">Idézetek</a>
                </li>
                <li>
                  <a href="#company" style="text-decoration: none">Rólunk</a>
                </li>
              </ul>
            </div>
          </div>
        </div>
        <div class="fcr text-center py-3">Live <sup>in</sup> Care © 2020 Copyright:
          <a href=""></a>
        </div>
  </footer>
</div>
</div>
</body>
</html>