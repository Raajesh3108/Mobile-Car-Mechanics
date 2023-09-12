<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeFile="Customer_Feedback.aspx.cs" Inherits="Customer_Feedback" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="row-fluid sortable ui-sortable">
        <div class="box span12">
            <div class="box-header" data-original-title>
                <h2>
                    <i class="halflings-icon edit"></i><span class="break"></span>FEEDBACK FORM</h2>
            </div>
            <div class="box-content">
                <div class="form-horizontal">
                    <fieldset>
                        <div class="control-group">
                            <label class="control-label" for="focusedInput">
                                Feedback</label>
                            <div class="controls">
                                <asp:TextBox ID="txtFeedback" CssClass="input-xlarge focused" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div class="control-group">
                            <label class="control-label" for="focusedInput">
                                Rating</label>
                            <div class="controls">
                                <asp:DropDownList ID="ddlRating" runat="server">
                                    <asp:ListItem>1</asp:ListItem>
                                    <asp:ListItem>2</asp:ListItem>
                                    <asp:ListItem>3</asp:ListItem>
                                    <asp:ListItem>4</asp:ListItem>
                                    <asp:ListItem>5</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="form-actions">
                            <asp:Button ID="btnSubmit" class="btn btn-primary" runat="server" Text="SUBMIT FEEDBACK"
                                OnClick="btnSubmit_Click" />
                        </div>
                    </fieldset>
                </div>
            </div>
        </div>
        <!--/span-->
    </div>
</asp:Content>
