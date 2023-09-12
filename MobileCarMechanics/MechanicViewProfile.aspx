<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="MechanicViewProfile.aspx.cs" Inherits="MechanicViewProfile" %>

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
                            <asp:Image ID="Image1" runat="server" style="max-width: 100px; max-height: 100px" src='<%# "mechanicuploads/" + Eval("MechanicPhoto") %>'/>
                            </div>
                        </div>

                        <div class="control-group">
                            <label class="control-label" for="focusedInput">
                                Mechanic</label>
                            <div class="controls">
                                <asp:Label ID="txtMechanicName" style="text-align:left" class="control-label" runat="server"></asp:Label>
                            </div>
                        </div>
                        <div class="control-group">
                            <label class="control-label" for="focusedInput">
                                Address</label>
                            <div class="controls">
                                <asp:Label ID="txtMechanicAddress" style="text-align:left" class="control-label" runat="server"></asp:Label>
                            </div>
                        </div>
                        <div class="control-group">
                            <label class="control-label" for="focusedInput">
                                City </label>
                            <div class="controls">
                                <asp:Label ID="txtCity" style="text-align:left" class="control-label" runat="server"></asp:Label>
                            </div>
                        </div>

                        <div class="control-group">
                            <label class="control-label" for="focusedInput">
                                Email</label>
                            <div class="controls">
                                <asp:Label ID="txtMechanicEmail" style="text-align:left" class="control-label" runat="server"></asp:Label>
                            </div>
                        </div>

                        <div class="control-group">
                            <label class="control-label" for="focusedInput">
                                Username</label>
                            <div class="controls">
                                <asp:Label ID="txtMechanicUsername" style="text-align:left" class="control-label" runat="server"></asp:Label>
                            </div>
                        </div>


                        <div class="control-group">
                            <label class="control-label" for="focusedInput">
                                Contact No</label>
                            <div class="controls">
                                <asp:Label ID="txtMechanicMobileNo" style="text-align:left" class="control-label" runat="server"></asp:Label>
                            </div>
                        </div>

                        <div class="control-group">
                            <label class="control-label" for="focusedInput">
                                AVG Rating(/5)</label>
                            <div class="controls">
                                <asp:Label ID="lblAvgRating" style="text-align:left" class="control-label" runat="server"></asp:Label>
                            </div>
                        </div>
                                                
                    </fieldset>
                    
                </div>
            </div>
        </div>
        <!--/span-->
    </div>

</asp:Content>

