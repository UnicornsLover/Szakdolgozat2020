<?php
require_once('config/init.php');
printHTML("header.html");
if (!isLogged()) {
  echo menu();
} else {
  echo child();
}
?>
<section id="up" class="start-area">
  <div class="start-img"></div>
  <h1 class="slower animated bounceInLeft">Live <sup>in</sup> Care gyerek ellátás</h1>
  <h1 class="slower animated bounceInLeft">Válassza ki a gyermek nevét a legördülő menüből!</h1>
  <div class="container">
    <div class="row">
      <div class="col-lg-3">
        <?php
          $parentId = $_SESSION['uid'];
          $sql = "SELECT DISTINCT children_fullprofile.cname,children_fullprofile.ID
          FROM children_fullprofile INNER JOIN children_healths ON children_fullprofile.ID = children_healths.childrenID INNER JOIN parentsk ON children_fullprofile.ID = parentsk.childrenID
          WHERE parentsk.pID = '$parentId'";
          $res = $conn -> query($sql);
          $select = "<br><select class='custom-select bg-info text-white' id='hchiname'><option>Gyermek neve</option>";
          while ($row = $res->fetch_array())
          {
            $select .= "<option id='$row[1]'>{$row[0]}</option>";
            $choseone = $row[0];
          }
          $select .= "</select><br><br>";
          echo $select;
        ?>

      </div>
    </div>
    <div class="row">
      <div class="col-lg-12">
        
      <table class="htable table table-light table-borderless table-striped">
      </table>
      </div>
    </div>
  </div>
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