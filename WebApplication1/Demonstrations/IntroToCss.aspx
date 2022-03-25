 <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IntroToCss.aspx.cs" Inherits="WebApplication1.Test1" %>

<!DOCTYPE html>

<style type="text/css">
    .innerelement {
        border:5px solid black;
        background-color:yellow;
        width:200px;
        padding:50px;
        margin:100px;
    }
    .outerelement {
    border:5px solid red;
    background-color:green;
    width:200px;
    }
</style>
<html xmlns="http://www.w3.org/1999/xhtml">
   
<head runat="server">
    <link href="Content/IntroToCss.css" type="text/css" rel="stylesheet"/>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
   <h1 class="introduction">introduction to CSS</h1>
    I am test Text
   <p class="special">Hey,I am not styled.</p>
    <p>but,<span class="special">I am</span>because I am inherited</p>
    <form id="form1" runat="server">
        <div class="special">
        And I am a text!
            I am not red text<span id="mainArticle">but I am</span>
            I am not red text<span class='special'>but I am</span>
        <h1>I am not a red header</h1>
            <h1 class="special">But I am a red header </h1>
        </div>
    </form>
    <div class="outerelement">
        <div class="innerelement">
            content
        </div>
    </div>
</body>
</html>
