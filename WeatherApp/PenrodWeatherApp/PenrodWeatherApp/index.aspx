<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="PenrodWeatherApp.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="JS.js"></script>
     <link type="text/css" href="style/salesforce-lightning-design-system.min.css" rel="stylesheet"/>
</head>
<body style="background-image:url(Images/clouds-in-heaven.png); background-repeat:no-repeat;">

  <div class="slds-box slds-box_x-small slds-text-align_center slds-p-around_xx-large">
    <div class="slds-p-around_medium" style="background-color:orange;"><h1 class="slds-text-align_center slds-m-around_xx-large slds-text-heading_large slds-text-font_monospace" style="color:white;">Penrod's Weather Forcast</h1></div>
  </div>

    <form id="form1" runat="server">
        <div>

            <div style="display:none;" id="mil" class="slds-size_2-of-2">
                  <div class="slds-box slds-box_x-small slds-text-align_left slds-m-around_x-small" style="background-color:lightblue;">
                        <asp:Label ID="milwaukeeCity"  class="slds-text-heading_medium" runat="server"></asp:Label>
                        <br />
                        <asp:Label ID="milwaukeeCountry" class="slds-text-heading_medium" runat="server" ForeColor="Black"></asp:Label>
                        <br />
                        <asp:Label ID="milwaukeeTemp" class="slds-text-heading_medium" runat="server" ForeColor="White"></asp:Label>
                        <br />
                      <asp:Label ID="milwaukeeDesc" class="slds-text-heading_medium" runat="server"></asp:Label>
                        <br />
                       <asp:Image ID="milwImage" runat="server" />
                  </div>
             </div>

          <div style="display:none;" id="minn" class="slds-size_2-of-2">
             <div class="slds-box slds-box_x-small slds-text-align_left slds-m-around_x-small" style="background-color:cornflowerblue;">
                <asp:Label ID="minneapolisCity" class="slds-text-heading_medium" runat="server"></asp:Label>
                <br />
                <asp:Label ID="minneapolisCountry" class="slds-text-heading_medium" runat="server"></asp:Label>
                <br />
                <asp:Label ID="minneapolisTemp" class="slds-text-heading_medium" runat="server" ForeColor="White"></asp:Label>
                <br />
                  <asp:Label ID="minniDesc" class="slds-text-heading_medium" runat="server"></asp:Label>
                        <br />
                       <asp:Image ID="minniImage" runat="server" />
            </div>
          </div>
            
          <div style="display:none;" id="chi" class="slds-size_2-of-2">
              <div class="slds-box slds-box_x-small slds-text-align_left slds-m-around_x-small" style="background-color:lightblue;">
                <asp:Label ID="chicagoCity" class="slds-text-heading_medium" runat="server"></asp:Label>
                <br />
                <asp:Label ID="chicagoCountry" class="slds-text-heading_medium" runat="server"></asp:Label>
                <br />
                <asp:Label ID="chicagoTemp" class="slds-text-heading_medium" runat="server" ForeColor="White"></asp:Label>
                <br />
                 <asp:Label ID="chiDesc" class="slds-text-heading_medium" runat="server"></asp:Label>
                    <br />
                 <asp:Image ID="chiImage" runat="server" />
            </div>
        </div>
             
          <div style="display:none;" id="dall" class="slds-size_2-of-2">
            <div class="slds-box slds-box_x-small slds-text-align_left slds-m-around_x-small" style="background-color:cornflowerblue;">
                <asp:Label ID="dallasCity" class="slds-text-heading_medium" runat="server"></asp:Label>
                <br />
                <asp:Label ID="dallasCountry" class="slds-text-heading_medium" runat="server"></asp:Label>
                <br />
                <asp:Label ID="dallasTemp" class="slds-text-heading_medium" runat="server" ForeColor="White"></asp:Label>
                <br />
                 <asp:Label ID="dallDesc" class="slds-text-heading_medium" runat="server"></asp:Label>
                  <br />
                <asp:Image ID="dallImage" runat="server" />
            </div>
        </div>

            <div style="display:none;" id="weatherMan" class="slds-size_2-of-2">
                <div>
                    <img src="Images/weatherMan.png"  style="height:450px; float:right; margin-top:-170px;"/>
                </div>
            </div>
       
          
        </div>
    </form>

</body>
</html>
