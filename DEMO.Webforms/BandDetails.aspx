<%@ Page Title="Band Details" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" 
        CodeBehind="BandDetails.aspx.cs" Inherits="DEMO.Webforms.BandDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:FormView ID="bandDetail" runat="server" ItemType="DEMO.Webforms.Models.Band" SelectMethod ="GetBand" RenderOuterTable="false">
        <ItemTemplate>
            <div>
                <h1><%#:Item.BandName %></h1>
            </div>
            <br />
            <table>
                <tr>
                    <td style="vertical-align: top; text-align:left;">
                        <b>Biography:</b><br /><%#:Item.Bio %>
                    </td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:FormView>
</asp:Content>
