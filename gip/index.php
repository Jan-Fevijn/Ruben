<!DOCTYPE html>
<?php
if (isset($_SESSION['id'])) {
    session_destroy();
    unset($$_SESSION['id']);
}

?>
<html lang="en" xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta charset="utf-8" />
    <title></title>
    <link rel="stylesheet"
          type="text/css"
          href="css/css.css" />
</head>
<body>
    <?php 
    $index = true ;
    include("code/banner.php");
    ?>
    <div id="homeContainer">
        <div id="contentHome">

            <div id="contentHomeLeft">
                <h2>Welkom op arduino educatief.</h2>
                <p id="midden"><b> Arduino educatief is een leerplatform om te leren werken met arduino. <br />
				Het doelpubliek zijn leerlingen van de 1e graad secundair.</b><br /> <br />
				<img src="img/arduinoTransparant.png" width="150" height="100" /></p>
			
            </div>
        </div>

		<br /> <br /> <br /> <br /> <br /> <br /> <br /> <br /> <br /> 

    </div>
	<br /> <br /> <br /> <br /> <br /> <br /> <br /> <br /> <br /> 
    <!-----footer                             footer             footer     -->
	<div id="footer">
	  <section id="footer">
        <div class="container">
            <div class="row">
                <div class="col-md-3 col-sm-3 col-xs-12 block">
                    <div class="footer-block">
                        <h4>Adressen</h4>
						<hr/>
						<h5>Atheneum Jan Fevijn</h5>
						Daverlostraat 132,<br> 8310 Assebroek <br><br>
						 <a target="_blank" id="footerLink" href="https://www.janfevijn.be/" class="learnmore">Learn More <i class="fa fa-caret-right"></i></a>
						<hr/>
						<h5>webdesigner: Ruben Aspeslag</h5>
                        
                        <p>Elzenstraat 2 ,<br> 8000 Brugge <p>
                        </p>
						
                        <a id="footerLink" href="#" class="learnmore">Learn More <i class="fa fa-caret-right"></i></a> <br>
                    </div>
                </div>

                <div class="col-md-3 col-sm-3 col-xs-12 block">
                    <div class="footer-block">
                        <h4>Useful Links</h4>
                        <hr/>
                        <ul class="footer-links">
                            <li><a id="footerLink" href="index.php">Home</a></li><br>
                            <li><a id="footerLink" href="code/ourService.php">Onze service</a></li><br>
                            <li><a id="footerLink" href="code/aboutUs.php">Over ons</a></li><br>
                            <li><a id="footerLink" href="code/contactUs.php">Contacteer ons</a></li><br>
                            <li><a id="footerLink" href="code/registreer.php">Registreer</a></li><br>
                            <li><a id="footerLink" href="index.php">Inloggen</a></li><br>
                        </ul>
                    </div>
                </div>

                <div class="col-md-3 col-sm-3 col-xs-12 block">
                    <div class="footer-block">
                        <h4>Community</h4>
                        <hr/>
                        <ul class="footer-links">
                            <li><a id="footerLink" href="#">Blog</a></li><br>
                            <li><a id="footerLink" href="#">Forum</a></li><br>
                            <li><a id="footerLink" href="#">Free Goods</a></li><br>
                        </ul>
                    </div>
                </div>

                <div class="col-md-3 col-sm-3 col-xs-12 <block></block>">
                    <div class="footer-block">
                        <h4>Recent Posts</h4>
                        <hr/>
                        <ul class="footer-links">
                            <li>
                                <a id="footerLink" href="#" class="post">Lorem ipsum dolor sit amet</a>
                                <p class="post-date">May 25, 2017</p>
                            </li>
                            <li>
                                <a id="footerLink" href="#" class="post">Lorem ipsum dolor sit amet</a>
                                <p class="post-date">May 25, 2017</p>
                            </li>
                            <li>
                                <a id="footerLink" href="#" class="post">Lorem ipsum dolor sit amet</a>
                                <p class="post-date">May 25, 2017</p>
                            </li>

                        </ul>
                    </div>
                </div>
            </div>
        </div>

    
    </section>  
         
       
    
        
</body>
</html>