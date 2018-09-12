<%@ Page Title="" Language="C#" MasterPageFile="~/LoanCalculator.Master" AutoEventWireup="true" CodeBehind="logInPage.aspx.cs" Inherits="LoanCalculatorProject.WebForm5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    LogIn Page
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="loanFormTitle" runat="server">
    LogIn
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="loanFormContent" runat="server">
    <!-- User Name -->
    <div class="form-group"> 
        <label id="labelUserName" runat="server" for="textUserName">Username<span class="required-field">*</span></label>
        <asp:TextBox runat="server" id="textUserName"   class="form-control" placeholder="Choose a Username"></asp:TextBox>
    </div>

    <!-- Password -->
    <div class="form-group">
        <label id="labelPassword" runat="server" for="textPassword">Password<span class="required-field">*</span></label>
        <asp:TextBox runat="server" id="textPassword"   type="password" class="form-control" placeholder="Enter Password"></asp:TextBox>
    </div>
   
    <asp:Button ID="btnLogin" class="btn btn-primary" runat="server" Text="Login" OnClick="btnLogin_Click"/>
    <br />
    <br />
        <asp:Label class="alert alert-success" runat="server" Id="labelSuccess" Text="" ></asp:Label>          
        <asp:Label class="alert alert-danger" runat="server" Id="labelErrorMsg" Text=""></asp:Label>  
</asp:Content>
