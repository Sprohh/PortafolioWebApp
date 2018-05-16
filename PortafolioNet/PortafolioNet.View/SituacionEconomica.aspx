<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SituacionEconomica.aspx.cs" Inherits="PortafolioNet.View.SituacionEconomica" %>

<!doctype html>

<html class="no-js" lang="">

<head>
<meta charset="utf-8">
<meta name="description" content="">
<meta name="viewport" content="width=device-width, initial-scale=1">
<title>Odontologica Linda Sonrisa</title>
<link rel="stylesheet" href="css/bootstrap.min.css">
<link rel="stylesheet" href="css/flexslider.css">
<link rel="stylesheet" href="css/jquery.fancybox.css">
<link rel="stylesheet" href="css/main.css">
<link rel="stylesheet" href="css/responsive.css">
<link rel="stylesheet" href="css/font-icon.css">
<link rel="stylesheet" href="css/animate.min.css">
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/font-awesome/4.4.0/css/font-awesome.min.css">
</head>

<body>
        <form id="form1" runat="server">
<!-- header section -->
<section class="banner" role="banner">
  <header id="header">
    <div class="header-content clearfix"> <a class="logo" href="Index.aspx">LINDA SONRISA</a>
      <nav class="navigation" role="navigation">
        <ul class="primary-nav">
          <li><a href="Index.aspx">Nosotros</a></li>
          <li><a href="Index.aspx">Servicios</a></li>
          <li><a href="Index.aspx">Nuestro equipo</a></li>
          <li><a href="Index.aspx">Testimonios</a></li>
          <li><a href="Index.aspx">Contacto</a></li>
          <li><a href="Index.aspx">Login</a></li>
        </ul>
      </nav>
      <a href="#" class="nav-toggle">Menu<span></span></a> </div>
  </header>
      <!-- banner text -->
    <!-- contact section -->
<section id="contact" class="section">
  <div class="container">
    <div class="row">
      <div class="col-md-8 col-md-offset-2 conForm">
        <h5>Situacion Socio Economica</h5>
        <div id="message"></div>        
          <textarea name="comments" id="comments" cols="" rows="" class="col-xs-12 col-sm-12 col-md-12 col-lg-12" placeholder="Deje su comentario..."></textarea>
          <input type="submit" id="archivo" name="subir" class="submitBnt" value="Subir Archivo">
          <input type="submit" id="submit" name="send" class="submitBnt" value="Enviar">
          <input type="submit" id="volver" name="volver" class="volverBnt" value="Volver">
          <div id="simple-msg"></div>
      </div>
    </div>
  </div>
</section>
<!-- contact section --> 
</section>
<!-- Footer section --> 
<!-- JS FILES --> 
<script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js"></script> 
<script src="js/bootstrap.min.js"></script> 
<script src="js/jquery.flexslider-min.js"></script> 
<script src="js/jquery.fancybox.pack.js"></script> 
<script src="js/retina.min.js"></script> 
<script src="js/modernizr.js"></script> 
<script src="js/main.js"></script> 
<script type="text/javascript" src="js/jquery.contact.js"></script>
            </form>
</body>
</html>