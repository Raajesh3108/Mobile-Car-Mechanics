<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeFile="CityDetail.aspx.cs" Inherits="CityDetail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="row-fluid sortable ui-sortable">
        <div class="box span12">
            <div class="box-header" data-original-title>
                <h2>
                    <i class="halflings-icon edit"></i><span class="break"></span>Add City</h2>
            </div>
            <div class="box-content">
                <div class="form-horizontal">
                    <fieldset>
                        <div class="control-group">
                            <label class="control-label" for="focusedInput">
                                City </label>
                            <div class="controls">
                                <asp:TextBox ID="txtCityName" CssClass="input-xlarge focused" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div class="control-group">
                            <label class="control-label" for="focusedInput">
                                City Details</label>
                            <div class="controls">
                                <asp:TextBox ID="TxtCityDetails" CssClass="input-xlarge focused" TextMode="MultiLine"
                                    runat="server"></asp:TextBox>
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
