<%@ Page Title="" Language="C#" MasterPageFile="~/LoanCalculator.Master" AutoEventWireup="true" CodeBehind="transferPage.aspx.cs" Inherits="LoanCalculatorProject.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Transfer Money
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="loanFormTitle" runat="server">
    Transfer Money
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="loanFormContent" runat="server">
    <!--Balance -->
    <div class="form-group">
        <label runat="server" for="textBalance">Your Balance<span class="required-field">*</span></label>
        <asp:TextBox runat="server" id="textBalance"   class="form-control" placeholder="Enter Balance"></asp:TextBox>
    </div>
    <div class="form-group">
        <label runat="server" for="textTransferAmount">Transfer Amount<span class="required-field">*</span></label>
        <asp:TextBox runat="server" id="textTransferAmount"   class="form-control" placeholder="Enter Transfer Amount"></asp:TextBox>
    </div>
    <div class="form-group">
        <label runat="server" for="textNewBalance">New Balance</label>
        <asp:TextBox runat="server" id="textNewBalance"   class="form-control" placeholder="New Balance" ReadOnly="true"></asp:TextBox>
    </div>
    <asp:Button ID="btnTrnasfer" class="btn btn-primary" runat="server" Text="Transfer" OnClick="btnTrnasfer_Click"/>
    <br />
    <br />
        <asp:Label class="alert alert-danger" runat="server" Id="labelErrorMsg" Text=""></asp:Label>  
</asp:Content>
