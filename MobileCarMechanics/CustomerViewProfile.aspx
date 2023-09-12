<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="CustomerViewProfile.aspx.cs" Inherits="CustomerViewProfile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<div class="row-fluid sortable ui-sortable">
        <div class="box span12">
            <div class="box-header" data-original-title>
                <h2>
                    <i class="halflings-icon edit"></i><span class="break"></span>View Profile</h2>
            </div>
            <div class="box-content">
                <div class="form-horizontal">
                    <fieldset>                                           
                        
                        <div class="control-group">                            
                            <div class="controls">
                            <asp:Image ID="Image1" runat="server" style="max-width: 100px; max-height: 100px" src='<%# "customeruploads/" + Eval("CustomerPhoto") %>'/>
                            </div>
                        </div>

                        <div class="control-group">
                            <label class="control-label" for="focusedInput">
                                Name</label>
                            <div class="controls">
                                <asp:Label ID="txtCustomerName" style="text-align:left" class="control-label" runat="server"></asp:Label>
                            </div>
                        </div>
                        <div class="control-group">
                            <label class="control-label" for="focusedInput">
                                Address</label>
                            <div class="controls">
                                <asp:Label ID="txtCustomerAddress" style="text-align:left" class="control-label" runat="server"></asp:Label>
                            </div>
                        </div>
                        <div class="control-group">
                            <label class="control-label" for="focusedInput">
                                Area</label>
                            <div class="controls">
                                <asp:Label ID="txtArea" style="text-align:left" class="control-label" runat="server"></asp:Label>
                            </div>
                        </div>

                        <div class="control-group">
                            <label class="control-label" for="focusedInput">
                                Email</label>
                            <div class="controls">
                                <asp:Label ID="txtCustomerEmail" style="text-align:left" class="control-label" runat="server"></asp:Label>
                            </div>
                        </div>

                        <div class="control-group">
                            <label class="control-label" for="focusedInput">
                                Username</label>
                            <div class="controls">
                                <asp:Label ID="txtCustomerUsername" style="text-align:left" class="control-label" runat="server"></asp:Label>
                            </div>
                        </div>


                        <div class="control-group">
                            <label class="control-label" for="focusedInput">
                                Contact No</label>
                            <div class="controls">
                                <asp:Label ID="txtCustomerMobileNo" style="text-align:left" class="control-label" runat="server"></asp:Label>
                            </div>
                        </div>
                                                <div class="form-actions">
								<asp:Button ID="btnEdit" class="btn btn-primary" runat="server" 
                                      Text="Edit" onclick="btnEdit_Click"/>
							  </div>
                    </fieldset>
                    
                </div>
            </div>
        </div>
        <!--/span-->
    </div>

</asp:Content>

