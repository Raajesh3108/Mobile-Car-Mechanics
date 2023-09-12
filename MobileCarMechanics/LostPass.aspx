<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="LostPass.aspx.cs" Inherits="LostPass" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<div class="row-fluid sortable ui-sortable">
        <div class="box span12">
            <div class="box-header" data-original-title>
                <h2>
                    <i class="halflings-icon edit"></i><span class="break"></span>Password Recovery</h2>
                    <br /></div>
                   
            
            <div class="box-content">
                <div class="form-horizontal">
                    <fieldset>

                        <div class="control-group">
                            <label class="control-label" for="focusedInput">
                                Enter Username</label>
                            <div class="controls">
                                <asp:TextBox ID="txtUsername" CssClass="input-xlarge focused" placeholder="Enter Username"
                                    runat="Server"></asp:TextBox>
                            </div>
                        </div>

                        
                        
                        
                        <div class="form-actions">
                            <asp:Button ID="btnSubmit" class="btn btn-primary" runat="server" Text="Submit" 
                                onclick="btnSubmit_Click" />
                            </div>
                    </fieldset>
                </div>
            </div>
        </div>
        <!--/span-->
    </div>

</asp:Content>

