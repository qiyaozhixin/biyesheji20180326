﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Masterpage.Master" AutoEventWireup="true" CodeBehind="Baobiaoyuliang.aspx.cs" Inherits="System003.Baobiaoyuliang" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMain" runat="server">
    <asp:Label ID="Label3" runat="server" Text="部门" Width="100px"></asp:Label>
    <asp:Label ID="Label4" runat="server"></asp:Label>
    <br />
    <asp:Label ID="Label5" runat="server" Text="员工OA" Width="100px"></asp:Label>
    <asp:Label ID="Label6" runat="server"></asp:Label>
    <br />
    <asp:Label ID="Label7" runat="server" Text="剩余卡数量" Width="100px"></asp:Label>
    <asp:Label ID="Label8" runat="server"></asp:Label>
    <br />
    <asp:Label ID="Label9" runat="server" Text="统计时间" Width="100px"></asp:Label>
    <asp:Label ID="Label10" runat="server"></asp:Label>
    <br />
    <asp:Button ID="Button9" runat="server" Text="返回" OnClick="Button9_Click" class="button"/>
</asp:Content>