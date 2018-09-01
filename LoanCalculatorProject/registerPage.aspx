<%@ Page Title="" Language="C#" MasterPageFile="~/LoanCalculator.Master" AutoEventWireup="true" CodeBehind="registerPage.aspx.cs" Inherits="LoanCalculatorProject.WebForm6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Register Page
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="loanFormTitle" runat="server">
    Register
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="loanFormContent" runat="server">
    <!--User Name -->
    <div class="form-group"> 
        <label runat="server" for="textUserName">Username<span class="required-field">*</span></label>
        <asp:TextBox runat="server" id="textUserName"   class="form-control" placeholder="Choose a Username"></asp:TextBox>
    </div>
    <!--Balance -->
    <div class="form-group"> 
        <label runat="server" for="textBalance">Balance<span class="required-field">*</span></label>
        <asp:TextBox runat="server" id="textBalance"   class="form-control" placeholder="Enter Balance"></asp:TextBox>
    </div>
    <div class="form-group">
        <label runat="server" for="textFirstName">First Name<span class="required-field">*</span></label>
        <asp:TextBox runat="server" id="textFirstName"   class="form-control" placeholder="Enter First Name"></asp:TextBox>
    </div>
    <div class="form-group">
        <label runat="server" for="textLastName">Last Name<span class="required-field">*</span></label>
        <asp:TextBox runat="server" id="textLastName"   class="form-control" placeholder="Enter Last Name"></asp:TextBox>
    </div>
    <div class="form-group">
        <label runat="server" for="textPassword">Password<span class="required-field">*</span></label>
        <asp:TextBox runat="server" id="textPassword"   type="password" class="form-control" placeholder="Enter Password"></asp:TextBox>
    </div>
    <asp:Button ID="btnRegister" class="btn btn-primary" runat="server" Text="Register" OnClick="btnRegister_Click"/>
    <br />
    <br />
        <asp:Label class="alert alert-success" runat="server" Id="labelSuccess" Text="" ></asp:Label>          
        <asp:Label class="alert alert-danger" runat="server" Id="labelErrorMsg" Text=""></asp:Label>  
</asp:Content>
