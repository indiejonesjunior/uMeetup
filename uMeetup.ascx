<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="uMeetup.ascx.cs" Inherits="LuminousAcuity.Meetup.uMeetup" %>
<section>

    <asp:Repeater runat="server" ID="eventRepeater">
        <HeaderTemplate>
            <h2>Our events</h2>
            <asp:Label ID="noDataLabel" runat="server" Text="We don't have any MeetUp events right now" Visible='<%# bool.Parse((eventRepeater.Items.Count == 0).ToString()) %>'></asp:Label>
        </HeaderTemplate>
        <ItemTemplate>
            <article>
                <h3><%# Eval("Name") %></h3>
                <p><%# Eval("Description") %></p>
                <p><a href="<%# Eval("Event_Url") %>" title="<%# Eval("Name") %>"><%# Eval("Name") %></a></p>
                <p>Status: <%# Eval("Status") %></p>
                <p>Venue: <%# Eval("Venue.Name") %></p>
            </article>

        </ItemTemplate>

    </asp:Repeater>

    <asp:Repeater runat="server" ID="openEventRepeater">
        <HeaderTemplate>
            <h2>Nearest events like ours</h2>
        </HeaderTemplate>
        <ItemTemplate>
            <article>
                <h3><%# Eval("Name") %></h3>
                <p><%# Eval("Description") %></p>
                <p><a href="<%# Eval("Event_Url") %>" title="<%# Eval("Name") %>"><%# Eval("Name") %></a></p>
                <p>Status: <%# Eval("Status") %></p>
                <p>Venue: <%# Eval("Venue.Name") %></p>
            </article>

        </ItemTemplate>

    </asp:Repeater>
</section>
