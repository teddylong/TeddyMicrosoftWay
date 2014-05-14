<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="TeddyMicrosoftWayWeb.Main._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <%-- Animate  --%>
    <link href="Style/animate.css" type="text/css" rel="stylesheet" />
    <%-- Teddy --%>
    <link href="Style/StyleSheet.css" type="text/css" rel="stylesheet" />
    <script src="Script/test.js" type="text/javascript"></script>
    <script src="Script/jquery-1.9.0.min.js" type="text/javascript"></script>
    <script>
        $(document).ready(function () {
            $("ul[data-liffect] li").each(function (i) {
                $(this).attr("style", "-webkit-animation-delay:" + i * 500 + "ms;"
                        + "-moz-animation-delay:" + i * 500 + "ms;"
                        + "-o-animation-delay:" + i * 500 + "ms;"
                        + "animation-delay:" + i * 500 + "ms;");
                if (i == $("ul[data-liffect] li").size() - 1) {
                    $("ul[data-liffect]").addClass("play")
                }
            });
        });
    </script>
    
</head>
<body onload="foo()">
    <form id="form1" runat="server">

        <div id="WelcomeWord" onclick="changeColor('red')">
            Welcome to Teddy's Word! Welcome to Teddy's Word!
        </div>


        <div id="TransformDiv" onclick="flashOfTransformDiv()">
            Welcome to Teddy's Word! Welcome to Teddy's Word!
        </div>

        <div class="i2Style" id="buttonOne">Ctrl ⌘</div>
        <div>
            <ul data-liffect="pageTop" style="width: 1000px; height: auto">
                <li>
                    <img src="images/galleryIcon1.jpg" alt="Lion" /></li>
                <li>
                    <img src="images/galleryIcon2.jpg" alt="Lion" /></li>
                <li>
                    <img src="images/galleryIcon3.jpg" alt="Lion" /></li>
                <li>
                    <img src="images/galleryIcon4.jpg" alt="Lion" /></li>
                <li>
                    <img src="images/galleryIcon5.jpg" alt="Lion" /></li>
                <li>
                    <img src="images/galleryIcon6.jpg" alt="Lion" /></li>
                <li>
                    <img src="images/galleryIcon7.jpg" alt="Lion" /></li>
                <li>
                    <img src="images/galleryIcon8.jpg" alt="Lion" /></li>
            </ul>
        </div>
        
    </form>
</body>
</html>
