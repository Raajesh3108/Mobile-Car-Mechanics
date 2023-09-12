<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="MechanicRegistration.aspx.cs" Inherits="MechanicRegistration" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
<style>
    label.control-label
    {
        text-align:left;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<%--<div class="row-fluid sortable ui-sortable">
        <div class="box span12">
            <div class="box-header" data-original-title>--%>
              <div style="margin-left:350px;margin-right:350px">  <h2 style="color:White">
                    <i class="icon-edit"></i><span class="break"></span><strong>Mechanic Register Here..</strong></h2>
                    <br /></div>

                   <div style="margin-left:350px;margin-right:350px"> 
                   <h2 runat="server" id="successMsg"  class="alert alert-success" visible="false">Successfully Registered!! Please <a href="CustomerLogin.aspx">Login</a> Now!!</h2>
                   </div>
            
      
                <div class="form-horizontal">
                    <fieldset>
                     <div style="margin-left:350px;margin-right:350px;background-color:White;position:relative;top:10px;opacity:0.9">
                              
                        <div class="control-group">
                            <label class="control-label" for="focusedInput">
                                Name</label>
                            <div class="controls">
                                <asp:TextBox ID="txtMechanicName" CssClass="input-xlarge focused" placeholder="Enter Name" runat="Server"></asp:TextBox>
                                     <asp:RequiredFieldValidator ControlToValidate="txtMechanicName" ID="RequiredFieldValidator1" SetFocusOnError="true" EnableClientScript="true" ForeColor="Red" ValidationGroup="save" runat="server" ErrorMessage="Required"></asp:RequiredFieldValidator>
								
                            </div>
                        </div>
                        <div class="control-group">
                            <label class="control-label" for="focusedInput">
                                Address</label>
                            <div class="controls">
                                <asp:TextBox ID="txtMechanicAddress" CssClass="input-xlarge focused" placeholder="Enter Address"
                                    TextMode="MultiLine" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div class="control-group">
                            <label class="control-label" for="focusedInput">
                                City</label>
                            <div class="controls">
                                <asp:DropDownList ID="ddlCity" runat="server">
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="control-group">
                            <label class="control-label" for="focusedInput">
                                Email</label>
                            <div class="controls">
                                <asp:TextBox ID="txtMechanicEmail" CssClass="input-xlarge focused" placeholder="Enter Email"
                                    runat="Server">
								</asp:TextBox>
                                    <asp:RequiredFieldValidator ControlToValidate="txtMechanicEmail" ID="RequiredFieldValidator2" SetFocusOnError="true" EnableClientScript="true" ForeColor="Red" ValidationGroup="save" runat="server" ErrorMessage="Required"></asp:RequiredFieldValidator>
                                    <asp:RegularExpressionValidator ControlToValidate="txtMechanicEmail" ID="RegularExpressionValidator1" runat="server" 
                                        ErrorMessage="Invalid" SetFocusOnError="true" EnableClientScript="true" 
                                        ForeColor="Red" ValidationGroup="save" 
                                        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
								
                            </div>
                        </div>

                        <div class="control-group">
                            <label class="control-label" for="focusedInput">
                                Contact No</label>
                            <div class="controls">
                                <asp:TextBox ID="txtMechanicMobileNo" CssClass="input-xlarge focused" placeholder="Enter Contact No"
                                    runat="Server">
                                    </asp:TextBox>
                                    <asp:RequiredFieldValidator ControlToValidate="txtMechanicMobileNo" ID="RequiredFieldValidator3" SetFocusOnError="true" EnableClientScript="true" ForeColor="Red" ValidationGroup="save" runat="server" ErrorMessage="Required"></asp:RequiredFieldValidator>
								
                                   <asp:RegularExpressionValidator ControlToValidate="txtMechanicMobileNo" ID="RegularExpressionValidator2" runat="server" 
                                        ErrorMessage="Invalid" SetFocusOnError="true" EnableClientScript="true" 
                                        ForeColor="Red" ValidationGroup="save" 
                                        ValidationExpression="^[0-9]{10,10}$"></asp:RegularExpressionValidator>
								
                            </div>
                        </div>

                        <div class="control-group">
                            <label class="control-label" for="focusedInput">
                                Username</label>
                            <div class="controls">
                                <asp:TextBox ID="txtMechanicUsername" CssClass="input-xlarge focused" placeholder="Enter Username"
                                    runat="Server"></asp:TextBox>
                            </div>
                        </div>
                        <div class="control-group">
                            <label class="control-label" for="focusedInput">
                                Password</label>
                            <div class="controls">
                                <asp:TextBox ID="txtMechanicPassword" CssClass="input-xlarge focused" placeholder="Enter Password"
                                    TextMode="Password" runat="Server"></asp:TextBox>
                            </div>
                            </div>
                            <div class="control-group">
                            <label class="control-label" for="focusedInput">
                                Confirm Password</label>
                            <div class="controls">
                               <asp:TextBox ID="txtMechanicConfirmPassword" CssClass="input-xlarge focused" placeholder="Re-enter Password"
                                    TextMode="Password" runat="Server"></asp:TextBox>                                    
                                  <asp:CompareValidator id="comparePasswords" runat="server" ControlToCompare="txtMechanicPassword"
                                  ControlToValidate="txtMechanicConfirmPassword" ErrorMessage="Your passwords do not match up!" Display="Dynamic" />
                            </div>
                                
                        </div>
                        <div class="control-group">
                            <label class="control-label" for="focusedInput">
                                Photo</label>
                            <div class="controls">
                                <asp:FileUpload ID="MechanicPhoto" runat="server" />
                            </div>
                        </div>
                        
                        <div class="control-group">
                            <label class="control-label" for="focusedInput">
                                Photo Proof</label>
                            <div class="controls">
                                <asp:FileUpload ID="MechanicPhotoProof" runat="server" />
                            </div>
                        </div>
                       
                      
                            <asp:Button ID="btnSignUp" class="btn btn-primary" runat="server" style="position:relative;left:200px" Text="SignUp" ValidationGroup="save" onclick="btnSignUp_Click"/>
                            
                            </div>
                            
                    </fieldset>
                </div>
           
        

</asp:Content>

