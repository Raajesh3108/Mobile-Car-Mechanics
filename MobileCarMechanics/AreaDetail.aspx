<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeFile="AreaDetail.aspx.cs" Inherits="AreaDetail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="row-fluid sortable ui-sortable">
        <div class="box span12">
            <div class="box-header" data-original-title>
                <h2>
                    <i class="halflings-icon edit"></i><span class="break"></span>Add Area</h2>
            </div>
            <div class="box-content">
                <div class="form-horizontal">
                    <fieldset>
                        <div class="control-group">
                            <label class="control-label" for="focusedInput">
                                Area </label>
                            <div class="controls">
                                <asp:TextBox ID="txtAreaName" CssClass="input-xlarge focused" placeholder="Enter Area Name"
                                    runat="Server"></asp:TextBox>
                            </div>
                        </div>
                        <div class="control-group">
                            <label class="control-label" for="focusedInput">
                                City </label>
                            <div class="controls">
                                <asp:DropDownList ID="ddlCity" runat="server">
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="control-group">
                            <label class="control-label" for="focusedInput">
                                Area Type</label>
                            <div class="controls">
                                <asp:DropDownList ID="ddlAreaType" runat="server">
                                    <asp:ListItem>Small</asp:ListItem>
                                    <asp:ListItem>Medium</asp:ListItem>
                                    <asp:ListItem>Large</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="form-actions">
                            <asp:Button ID="btnSave" class="btn btn-primary" runat="server" Text="Save changes"
                                OnClick="btnSave_Click" />
                            <asp:Button ID="btnDelete" class="btn btn-danger" runat="server" Text="Delete" OnClick="btnDelete_Click" />
                        </div>
                    </fieldset>
                </div>
            </div>
        </div>
        <!--/span-->
    </div>
</asp:Content>
