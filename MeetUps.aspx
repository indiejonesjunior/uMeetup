<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MeetUps.aspx.cs" Inherits="LuminousAcuity.Meetup.MeetUps" %>
<%@ Register Src="~/uMeetup.ascx" TagPrefix="uc" TagName="Meetup" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <uc:Meetup runat="server" />
    </div>
    </form>
</body>
</html>
