Imports System.Runtime.CompilerServices

Module Htmls

    Public cfFile As String = $"{Application.StartupPath}\Data\Launcher\config.xml"
    Public conf As Conf = New Conf(cfFile).Instance

    Public MainHtml As String = "<head>
<title>" & conf.ServerName & "</title>
<meta http-equiv=""X-UA-Compatible"" content=""IE=9"" charset=""utf-8"" />
<style>
/* Style the video: 100% width and height to cover the entire window */
#myVideo {
	position: fixed;
    top: 50%;
    left: 50%;
    min-width: 100%;
    min-height: 100%;
    width: auto;
    height: auto;
    z-index: -100;
    transform: translateX(-50%) translateY(-50%);
  background-size: cover;
  transition: 1s opacity;
}

.content-top {
  position: fixed;
  top: 0;
  left: 0;
  width: 100%;
  padding: 0px;
}

.content-window {
  position: fixed;
  top: 0;
  right: 0;
  padding: 0px;
}

.content-bottom {
  position: fixed;
  left: 0;
  bottom: 0;
  width: 100%;
  padding: 0px;
  margin-bottom: -4px;
}

.content-select {
  position: fixed;
  top: 50%;
  left: 50%;
  transform: translate(-50%, -50%);
  width: 200px;
  height: 349px;
  padding: 0px;
}

.exit-msgbox {
  position: fixed;
  top: 55%;
  left: 50%;
  transform: translate(-50%, -50%);
  width: 335px;
  height: 100px;
  padding: 0px
}

.help-window {
  position: fixed;
  top: 50%;
  left: 50%;
  transform: translate(-50%, -50%);
  width: 700px;
  height: 416px;
  padding: 0px
}

.news-window {
  position: fixed;
  top: 50%;
  left: 50%;
  transform: translate(-50%, -50%);
  width: 700px;
  height: 416px;
  padding: 0px
}

.website-window {
  position: fixed;
  top: 49%;
  left: 50%;
  transform: translate(-51%, -50%);
  width: 1160px;
  height: 564px;
  padding: 0px
}

.register-window {
  position: fixed;
  top: 49%;
  left: 50%;
  transform: translate(-51%, -50%);
  width: 1160px;
  height: 564px;
  padding: 0px
}

.content-select-buttons {
  position: fixed;
  top: 50%;
  left: 50%;
  transform: translate(-50%, -50%);
  width: 102px;
  height: 20px;
  padding: 0px;
}

.content-bottom-copyright {
  position: fixed;
  left: 0;
  bottom: 0;
  width: 100%;
  padding: 0px;
  color: #f1f1f1;
  font-family: ""Arial"", Helvetica, sans-serif;
  font-size: 14px;
  text-align: center;
}

img {text-decoration: none; border: 0px}

.disable-selection {
     -moz-user-select: none; /* Firefox */
      -ms-user-select: none; /* Internet Explorer */
   -khtml-user-select: none; /* KHTML browsers (e.g. Konqueror) */
  -webkit-user-select: none; /* Chrome, Safari, and Opera */
  -webkit-touch-callout: none; /* Disable Android and iOS callouts*/
}
</style>
</head>

<body>
<!-- The video -->
<video autoplay muted loop id=""myVideo"">
  <source src=""" & Application.StartupPath & "\Data\Launcher\videos\bg.mp4"" type=""video/mp4"">
</video>

<audio autoplay loop id=""bgm"">
	<source src=""" & Application.StartupPath & "\Data\Launcher\bgm\intro.mp3"" type=""audio/mp3"">
</audio>

<div class=""content-select disable-selection"">
  <img draggable=""false"" src=""" & Application.StartupPath & "\Data\Launcher\images\select_server.png"" style=""width:200px;height:349px;opacity:0.9;filter:alpha(opacity=90);"">
  <p style=""position:absolute;left:5px;top:99px;color:#f1f1f1;font-family:'Arial', Helvetica, sans-serif;font-size:14px;"">" & conf.ServerName & "</p>
</div>

<div class=""content-select-buttons"">
  <a href=""#play""><img draggable=""false"" id=""play"" src=""" & Application.StartupPath & "\Data\Launcher\images\play.png"" style=""padding-bottom: 5px"" onmousedown=""mousedown('play');"" onmouseup=""resetimage('play');"" onmouseleave=""resetimage('play');""></a>
  <a href=""#register""><img draggable=""false"" id=""register"" src=""" & Application.StartupPath & "\Data\Launcher\images\register.png"" style=""padding-bottom: 5px"" onmousedown=""mousedown('register');"" onmouseup=""resetimage('register');"" onmouseleave=""resetimage('register');""></a>
  <a href=""#website""><img draggable=""false"" id=""website"" src=""" & Application.StartupPath & "\Data\Launcher\images\website.png"" style=""padding-bottom: 5px"" onmousedown=""mousedown('website');"" onmouseup=""resetimage('website');"" onmouseleave=""resetimage('website');""></a>
  <a href=""#news""><img draggable=""false"" id=""news"" src=""" & Application.StartupPath & "\Data\Launcher\images\news.png"" style=""padding-bottom: 5px"" onmousedown=""mousedown('news');"" onmouseup=""resetimage('news');"" onmouseleave=""resetimage('news');""></a>
  <a href=""#help""><img draggable=""false"" id=""help"" src=""" & Application.StartupPath & "\Data\Launcher\images\help.png"" style=""padding-bottom: 5px"" onmousedown=""mousedown('help');"" onmouseup=""resetimage('help');"" onmouseleave=""resetimage('help');""></a> 
  <a href=""#exit""><img draggable=""false"" id=""exit"" src=""" & Application.StartupPath & "\Data\Launcher\images\exit.png"" onmousedown=""mousedown('exit');"" onmouseup=""resetimage('exit');"" onmouseleave=""resetimage('exit');"" hspace=""70"" vspace=""5""></a>
</div>

<div style=""display: none"" id=""exit-msgbox"" class=""exit-msgbox"">
  <img draggable=""false"" src=""" & Application.StartupPath & "\Data\Launcher\images\msgbox_bg.png"" style=""width:335px;height:100px;opacity:0.8;filter:alpha(opacity=80);"">
  <img draggable=""false"" src=""" & Application.StartupPath & "\Data\Launcher\images\msgbox.png"" style=""width:327px;height:66px;opacity:0.8;filter:alpha(opacity=80);position:absolute;left:4px;top:4px;"">
  <p style=""position:absolute;left:10px;top:0px;color:#f1f1f1;font-family:'Arial', Helvetica, sans-serif;font-size:14px;"">是否要離開遊戲？</p>
  <a href=""#exitok""><img draggable=""false"" id=""exitok"" src=""" & Application.StartupPath & "\Data\Launcher\images\exitok.png"" style=""position:absolute;left:120px;top:75px;"" onmousedown=""mousedown('exitok');"" onmouseup=""resetimage('exitok');"" onmouseleave=""resetimage('exitok');""></a>
  <a href=""#exitcancel""><img draggable=""false"" id=""exitcancel"" src=""" & Application.StartupPath & "\Data\Launcher\images\exitcancel.png"" style=""position:absolute;left:228px;top:75px;"" hspace=""0"" onmousedown=""mousedown('exitcancel');"" onmouseup=""resetimage('exitcancel');"" onmouseleave=""resetimage('exitcancel');""></a>
</div>

<div style=""display: none"" id=""help-window"" class=""help-window"">
  <img draggable=""false"" src=""" & Application.StartupPath & "\Data\Launcher\images\help_window.png"" style=""width:700px;height:416px;opacity:0.9;filter:alpha(opacity=90);""> 
  <iframe src=""" & Application.StartupPath & "\Data\Launcher\..\Help\help.htm"" height=""400"" width=""700"" style=""position:absolute;left:0px;top:16px;border:none;opacity:0.9;filter:alpha(opacity=90);""></iframe>
  <p style=""position:absolute;left:10px;top:-10px;color:#f1f1f1;font-family:'Arial', Helvetica, sans-serif;font-size:14px;"">幫助</p>
  <a href=""#"" id=""closehelp"" style=""text-decoration:none;position:absolute;right:5px;top:-6px;color:#f1f1f1;font-family:'Arial', Helvetica, sans-serif;font-size:25px;"" onmousedown=""showhelp();"">&times;</a>
</div>

<div style=""display: none"" id=""news-window"" class=""news-window"">
  <img draggable=""false"" src=""" & Application.StartupPath & "\Data\Launcher\images\help_window.png"" style=""width:700px;height:416px;opacity:0.9;filter:alpha(opacity=90);""> 
  <iframe src=" & conf.NewsLink & " height=""400"" width=""700"" style=""position:absolute;left:0px;top:16px;border:none;opacity:0.9;filter:alpha(opacity=90);""></iframe>
  <p style=""position:absolute;left:10px;top:-10px;color:#f1f1f1;font-family:'Arial', Helvetica, sans-serif;font-size:14px;"">新聞</p>
  <a href=""#"" id=""closenews"" style=""text-decoration:none;position:absolute;right:5px;top:-6px;color:#f1f1f1;font-family:'Arial', Helvetica, sans-serif;font-size:25px;"" onmousedown=""shownews();"">&times;</a>
</div>

<div style=""display: none"" id=""website-window"" class=""website-window"">
  <img draggable=""false"" src=""" & Application.StartupPath & "\Data\Launcher\images\website_window.png"" style=""width:1160px;height:580px;opacity:0.9;filter:alpha(opacity=90);""> 
  <iframe src=" & conf.WebsiteLink & " height=""564"" width=""1160"" style=""position:absolute;left:0px;top:16px;border:none;opacity:0.9;filter:alpha(opacity=90);""></iframe>
  <p style=""position:absolute;left:10px;top:-10px;color:#f1f1f1;font-family:'Arial', Helvetica, sans-serif;font-size:14px;"">網站</p>
  <a href=""#"" id=""closewebsite"" style=""text-decoration:none;position:absolute;right:5px;top:-6px;color:#f1f1f1;font-family:'Arial', Helvetica, sans-serif;font-size:25px;"" onmousedown=""showwebsite();"">&times;</a>
</div>

<div style=""display: none"" id=""register-window"" class=""register-window"">
  <img draggable=""false"" src=""" & Application.StartupPath & "\Data\Launcher\images\website_window.png"" style=""width:1160px;height:580px;opacity:0.9;filter:alpha(opacity=90);""> 
  <iframe src=" & conf.RegisterLink & " height=""564"" width=""1160"" style=""position:absolute;left:0px;top:16px;border:none;opacity:0.9;filter:alpha(opacity=90);""></iframe>
  <p style=""position:absolute;left:10px;top:-10px;color:#f1f1f1;font-family:'Arial', Helvetica, sans-serif;font-size:14px;"">網站</p>
  <a href=""#"" id=""closeregister"" style=""text-decoration:none;position:absolute;right:5px;top:-6px;color:#f1f1f1;font-family:'Arial', Helvetica, sans-serif;font-size:25px;"" onmousedown=""showregister();"">&times;</a>
</div>

<div class=""content-top"">
  <img draggable=""false"" src=""" & Application.StartupPath & "\Data\Launcher\images\border_top.png"" style=""width:100%;height:75px;opacity:0.8;filter:alpha(opacity=80);"">
</div>

<div class=""content-window"">
  <a href=""#window""><img draggable=""false"" id=""window"" src=""" & Application.StartupPath & "\Data\Launcher\images\window.png"" style=""width:20px;height:20px;right:0;""></a>
</div>

<div class=""content-bottom"">
  <img draggable=""false"" src=""" & Application.StartupPath & "\Data\Launcher\images\border_bottom.png"" style=""width:100%;height:75px;opacity:0.8;filter:alpha(opacity=80);"">
</div>

<div class=""content-bottom-copyright disable-selection"">
  <p>" & conf.Copyright.Replace("\n", "<br>").Replace("(c)", "&copy;") & "</p>
</div>
</body>

<script>
function mousedown(id) {
	var el = document.getElementById(id);
	if (!el) {
		throw new ReferenceError(id + ""is not defined"");
	}
	el.setAttribute(""src"", """ & Application.StartupPath.Replace("\", "\\") & "\\Data\\Launcher\\images\\"" + id + ""_pressed.png"")
	if (id === ""exit"") {
	showmsgboxexit();
	}
	if (id === ""exitcancel"") {
	showmsgboxexit();
	}
	if (id === ""help"") {
	showhelp();
	}
	if (id === ""news"") {
	shownews();
	}
	if (id === ""website"") {
	showwebsite();
	}
	if (id === ""register"") {
	showregister();
	}
}

function resetimage(id) {
	var el = document.getElementById(id);
	if (!el) {
		throw new ReferenceError(id + ""is not defined"");
	}
	el.setAttribute(""src"", """ & Application.StartupPath.Replace("\", "\\") & "\\Data\\Launcher\\images\\"" + id + "".png"")
}

function showmsgboxexit() {
	var x = document.getElementById(""exit-msgbox"")
	if (x.style.display === ""none"") {
		x.style.display = ""block"";
	} else {
		x.style.display = ""none"";
	}
}

function showhelp() {
	var x = document.getElementById(""help-window"")
	if (x.style.display === ""none"") {
		x.style.display = ""block"";
	} else {
		x.style.display = ""none"";
	}
}

function shownews() {
	var x = document.getElementById(""news-window"")
	if (x.style.display === ""none"") {
		x.style.display = ""block"";
	} else {
		x.style.display = ""none"";
	}
}

function showwebsite() {
	var x = document.getElementById(""website-window"")
	if (x.style.display === ""none"") {
		x.style.display = ""block"";
	} else {
		x.style.display = ""none"";
	}
}

function showregister() {
	var x = document.getElementById(""register-window"")
	if (x.style.display === ""none"") {
		x.style.display = ""block"";
	} else {
		x.style.display = ""none"";
	}
}
</script>"

    Public UpdHtml As String = "<!DOCTYPE html>
<html>
<head>
<meta http-equiv=""X-UA-Compatible"" content=""IE=9"" charset=""utf-8"" />
<meta name=""viewport"" content=""width=device-width, initial-scale=1"">
<style>
* {box-sizing: border-box;}
body {font-family: Verdana, sans-serif;}
.mySlides {display: none;}
img {vertical-align: middle;}

/* Slideshow container */
.slideshow-container {
  max-width: 1000px;
  position: relative;
  margin: auto;
}

/* Caption text */
.text {
  color: #f2f2f2;
  font-size: 15px;
  padding: 8px 12px;
  position: absolute;
  bottom: 8px;
  width: 100%;
  text-align: center;
}

/* Number text (1/3 etc) */
.numbertext {
  color: #f2f2f2;
  font-size: 12px;
  padding: 8px 12px;
  position: absolute;
  top: 0;
}

/* The dots/bullets/indicators */
.dot {
  height: 15px;
  width: 15px;
  margin: 0 2px;
  background-color: #bbb;
  border-radius: 50%;
  display: inline-block;
  transition: background-color 0.6s ease;
}

.active {
  background-color: #717171;
}

/* Fading animation */
.fade {
  -webkit-animation-name: fade;
  -webkit-animation-duration: 1.5s;
  animation-name: fade;
  animation-duration: 1.5s;
}

@-webkit-keyframes fade {
  from {opacity: .4} 
  to {opacity: 1}
}

@keyframes fade {
  from {opacity: .4} 
  to {opacity: 1}
}

/* On smaller screens, decrease text size */
@media only screen and (max-width: 300px) {
  .text {font-size: 11px}
}

</style>
</head>
<body style=""background-color:black;"">

<div class=""slideshow-container"">

<div class=""mySlides fade"">
  <div class=""numbertext"">1 / 3</div>
  <img src=""" & Application.StartupPath & "\Data\Launcher\images\slide1.jpg"" style=""width:100%"">
  <div class=""text"">Caption Text</div>
</div>

<div class=""mySlides fade"">
  <div class=""numbertext"">2 / 3</div>
  <img src=""" & Application.StartupPath & "\Data\Launcher\images\slide2.jpg"" style=""width:100%"">
  <div class=""text"">Caption Two</div>
</div>

<div class=""mySlides fade"">
  <div class=""numbertext"">3 / 3</div>
  <img src=""" & Application.StartupPath & "\Data\Launcher\images\slide3.jpg"" style=""width:100%"">
  <div class=""text"">Caption Three</div>
</div>

</div>
<br>

<div style=""text-align:center"">
  <span class=""dot""></span> 
  <span class=""dot""></span> 
  <span class=""dot""></span> 
</div>

<script>
var slideIndex = 0;
showSlides();

function showSlides() {
  var i;
  var slides = document.getElementsByClassName(""mySlides"");
  var dots = document.getElementsByClassName(""dot"");
  for (i = 0; i < slides.length; i++) {
    slides[i].style.display = ""none"";  
  }
  slideIndex++;
  if (slideIndex > slides.length) {slideIndex = 1}    
  for (i = 0; i < dots.length; i++) {
    dots[i].className = dots[i].className.replace("" active"", """");
  }
  slides[slideIndex-1].style.display = ""block"";  
  dots[slideIndex-1].className += "" active"";
  setTimeout(showSlides, 4000); // Change image every 4 seconds
}
</script>

</body>
</html>"

    <Extension>
    Public Sub RunPage(browser As WebBrowser, html As String)
        browser.Navigate(Application.StartupPath)
        Dim hdoc As HtmlDocument = browser.Document
        hdoc.Write(String.Empty)
        browser.DocumentText = html
    End Sub

End Module
