<%@ Page Title="" Language="C#" MasterPageFile="~/LoanCalculator.Master" AutoEventWireup="true" CodeBehind="loanPage.aspx.cs" Inherits="LoanCalculatorProject.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Loan Page
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="loanFormTitle" runat="server">
    Loan
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="loanFormContent" runat="server">
    <!--Balance -->
    <div class="form-group">
        <label runat="server" for="textLoanAmount">Loan Amount<span class="required-field">*</span></label>
        <asp:TextBox runat="server" id="textLoanAmount"   class="form-control" placeholder="Loan Amount"></asp:TextBox>
    </div>
    <div class="form-group">
        <label runat="server" for="textPaymentPerInstallment">Payment Per Installment<span class="required-field">*</span></label>
        <asp:TextBox runat="server" id="textPaymentPerInstallment"   class="form-control" placeholder="Enter Payment Per Installment"></asp:TextBox>
    </div>
    <div class="form-group">
        <label runat="server" for="textNumberOfPayment">Number Of Payment</label>
        <asp:TextBox runat="server" id="textNumberOfPayment"   class="form-control" placeholder="Number Of Payment" ReadOnly="true"></asp:TextBox>
    </div>
    <asp:Button ID="btnNumOfPayment" class="btn btn-primary" runat="server" Text="Find Number Of Payment Required" OnClick="btnNumOfPayment_Click"/>
    <br />
    <br />
        <asp:Label class="alert alert-danger" runat="server" Id="labelErrorMsg" Text=""></asp:Label>  
</asp:Content>
