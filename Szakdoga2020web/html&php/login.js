$(document).ready(function(){
    $("#loginbtn").click(function(e){
        e.preventDefault();
        let username = $("#uname").val();
        let password = $("#psw").val();
        //console.log(username);
        //console.log(password);
        $.ajax({
            url:"login.php",
            method:"POST",
            data:{username:username,password:password},
            success:function(data){
                //alert(data);
                if(data == "1")
                {
                    window.location = "index.php";
                }
                else if(username == "" )
                {
                    $("#uname").css("border","2px solid red");
                    $("p").remove();
                    $("br").remove();
                    $("#loginbtn").after("<br><br><p class='slower animated bounceIn' id ='error' style='color:red; text-align:center;'>Töltse ki a 'Felhasználónév' mezőt!</p>");
                }
                else if(password== "")
                {
                    $("#psw").css("border","2px solid red");
                    $("p").remove();
                    $("br").remove();
                    $("#loginbtn").after("<br><br><p class='slower animated bounceIn' id ='error' style='color:red; text-align:center;'>Töltse ki a 'Jelszó' mezőt!</p>");
                }
                else
                {
                    $("p").remove();
                    $("br").remove(); 
                    $("#loginbtn").after("<br><br><p class='slower animated bounceIn' id ='error' style='color:red; text-align:center;'>Hibás jelszó vagy felhasználónév!!</p>");
                }
            }

        });
    });

    $("#rloginbtn").click(function(e){
        e.preventDefault();
        let rusername = $("#runame").val();
        let rpassword = $("#rrpsw").val();
        //console.log(rusername);
        //console.log(rpassword);
        $.ajax({
            url:"reg.php",
            method:"POST",
            data:{rusername:rusername,rpassword:rpassword},
            success:function(data){
                //alert(data);
                if(data == "1")
                {
                   $("#id02").fadeOut(300);
                   $("#id03").fadeIn(300);
                   $.ajax({
                        url:"preg.php",
                        method: "POST",
                        data:{rusername:rusername,rpassword:rpassword},
                        success: function(data){
                            $(".reger").html(data);
                        }
                   });
                }
                else if(rusername == "")
                {
                    $("#runame").css("border","2px solid red");
                    $("p").remove();
                    $("br").remove();
                    $("#rloginbtn").after("<br><br><p class='slower animated bounceIn' id ='error' style='color:red; text-align:center;'>Töltse ki a 'Regisztrációsnév' mezőt!</p>");
                }
                else if(rpassword == "")
                {
                    $("#rrpsw").css("border","2px solid red");
                    $("p").remove();
                    $("br").remove();
                    $("#rloginbtn").after("<br><br><p class='slower animated bounceIn' id ='error' style='color:red; text-align:center;'>Töltse ki a 'Regisztrációs jelszó' mezőt!</p>");
                }
                else
                {
                    $("p").remove();
                    $("br").remove();
                    $("#rloginbtn").after("<br><br><p class='slower animated bounceIn' id ='error' style='color:red; text-align:center;'>Hibás a megadott regisztrációsnév vagy a jelszó! <br> Vagy már regisztrált, akkor használja a 'Bejelentkezés' menüpontot! </p>");
                
                }
            }

        });
    });

    $(document).on("click",".save",function(e){
        e.preventDefault();
        let name = $("#regname").val();
        let birth = $("#regbrth").val();
        let idcard = $("#regidcard").val();
        let regusername = $("#regusername").val();
        let password = $("#regpassword").val();
        console.log(name);
        console.log(birth);
        console.log(idcard);
        console.log(regusername);
        console.log(password);
        $.ajax({
            url:"updatepdata.php",
            method:"POST",
            data:{name:name,birth:birth,idcard:idcard,regusername:regusername,password:password},
            success:function(data){
                if(data == 1)
                {
                    $(".save").before("<span style='color: green; font-weight: bold;'>Sikeres mentés!</span>");
                    setTimeout(function(){
                      $("#id03").fadeOut(200);
                    },1000)
                }
                else
                {

                }
            }

        });

    });
    
    $("#content").click(function(){
        $('html, body').animate({ scrollTop: $("#conts").offset().top}, 1500);
        return false;
    });    

    
    
    
});

