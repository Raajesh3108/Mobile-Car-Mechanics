<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeFile="CitySearch.aspx.cs" Inherits="CitySearch" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="row-fluid sortable ui-sortable">
        <div class="box span12">
            <div class="box-header" data-original-title>
                <h2>
                    <i class="halflings-icon edit"></i><span class="break"></span>Search City</h2>
            </div>
            <div class="box-content">
                <div class="form-horizontal">
                    <fieldset>
                        <div class="control-group">
                            <label class="control-label" for="focusedInput">
                                City</label>
                            <div class="controls">
                                <asp:TextBox ID="txtCitySearchName" CssClass="input-xlarge focused" placeholder="Enter City Name"
                                    runat="Server"></asp:TextBox>
                                <asp:Button ID="btnSearch" class="btn btn-primary" runat="server" Text="Search" OnClick="btnSearch_Click" />
                            </div>
                        </div>
                    </fieldset>
                    <br />
                    <br />
                    <asp:GridView ID="GridViewCity" CssClass="table table-bordered" runat="server" AutoGenerateColumns="false"
                        GridLines="None">
                        <Columns>
                            <asp:TemplateField HeaderText="City">
                                <ItemTemplate>
                                    <%# Eval("CityName") %>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="City Details">
                                <ItemTemplate>
                                    <%# Eval("CityDetails") %>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <a href='<%# "CityDetail.aspx?ID=" + Eval("CityID") %>'>EDIT</a>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
        </div>
        <!--/span-->
    </div>
</asp:Content>
