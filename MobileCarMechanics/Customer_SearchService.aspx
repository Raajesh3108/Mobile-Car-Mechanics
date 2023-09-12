<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeFile="Customer_SearchService.aspx.cs" Inherits="Customer_SearchService" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="row-fluid sortable ui-sortable">
        <div class="box span12">
            <div class="box-header" data-original-title>
                <h2>
                    <i class="halflings-icon edit"></i><span class="break"></span>Search Services</h2>
            </div>
            <div class="box-content">
                <div class="form-horizontal">
                    <fieldset>
                        <div class="control-group">
                            <label class="control-label" for="focusedInput">
                                City </label>
                            <div class="controls">
                                <asp:DropDownList ID="ddlCity" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlCity_SelectedIndexChanged">
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="control-group">
                            <label class="control-label" for="focusedInput">
                                Area </label>
                            <div class="controls">
                                <asp:DropDownList ID="ddlArea" runat="server">
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="control-group">
                            <label class="control-label" for="focusedInput">
                                Service Category</label>
                            <div class="controls">
                                <asp:DropDownList ID="ddlServiceCategory" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlServiceCategory_SelectedIndexChanged">
                                </asp:DropDownList>
                            </div>
                        </div>
                    </fieldset>
                    <div class="box-content">
                        <asp:GridView ID="GridView1" CssClass="table table-striped" runat="server" AutoGenerateColumns="false"
                            GridLines="None">
                            <Columns>
                                <asp:TemplateField HeaderText="Services">
                                    <ItemTemplate>
                                        <%# Eval("ServiceName") %>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:Button ID="btnSelectService" runat="server" Text="Select" OnCommand="btnSelectService_Command"
                                    CommandArgument='<%# Eval("ServiceID") %>' />
                                    </ItemTemplate>
                                </asp:TemplateField>

                            </Columns>
                        </asp:GridView>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
