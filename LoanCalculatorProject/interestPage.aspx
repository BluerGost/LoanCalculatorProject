<%@ Page Title="" Language="C#" MasterPageFile="~/LoanCalculator.Master" AutoEventWireup="true" CodeBehind="interestPage.aspx.cs" Inherits="LoanCalculatorProject.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Interest Calculate
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="loanFormTitle" runat="server">
    Interest Calculate
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="loanFormContent" runat="server">
    <!--Balance -->
    <div class="form-group">
        <label runat="server" for="textLoanAmount">Loan Amount<span class="required-field">*</span></label>
        <asp:TextBox runat="server" id="textLoanAmount"   class="form-control" placeholder="Loan Amount"></asp:TextBox>
    </div>
    <div class="form-group">
        <label runat="server" for="textNumberOfInstallment">Number Of Installment<span class="required-field">*</span></label>
        <asp:TextBox runat="server" id="textNumberOfInstallment"   class="form-control" placeholder="Enter Number Of Installment"></asp:TextBox>
    </div>
    <div class="form-group">
        <label runat="server" for="textInterestRate">Interest Rate(In Percent %)<span class="required-field">*</span></label>
        <asp:TextBox runat="server" id="textInterestRate"   class="form-control" placeholder="Enter Interest Rate"></asp:TextBox>
    </div>
    <div class="form-group">
        <label runat="server" for="textTotalInterest">Total Interest</label>
        <asp:TextBox runat="server" id="textTotalInterest" class="form-control" placeholder="Total Interest" ReadOnly="true"></asp:TextBox>
    </div>
    <asp:Button ID="btnInterestCal" class="btn btn-primary" runat="server" Text="Calculate Interest" OnClick="btnInterestCal_Click"/>
    <br />
    <br />
        <asp:Label class="alert alert-danger" runat="server" Id="labelErrorMsg" Text=""></asp:Label>  
</asp:Content>
