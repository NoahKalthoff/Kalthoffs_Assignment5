<%@ Page Title="" Language="C#" MasterPageFile="~/Master-Page/MusicStoreMain.Master" AutoEventWireup="true" CodeBehind="SearchPage.aspx.cs" Inherits="MusicShop.SearchPage.SearchPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="position: fixed; width: 80%; height: 60%; background-color: rgba(255, 255, 255, 0.8); margin-left: 10%; margin-top: 5%;">
        <div style="margin-left: 5%; margin-top: 10%; height: auto; width: auto;">
            <div class="dropdown">
                <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
            </div>
        </div>
        <div style="margin-left: 5%; margin-top: 10%; height: auto; width: auto;">
            <div class="dropdown">
                <asp:DropDownList ID="DropDownList2" runat="server"></asp:DropDownList>
            </div>
        </div>
    </div>
</asp:Content>
