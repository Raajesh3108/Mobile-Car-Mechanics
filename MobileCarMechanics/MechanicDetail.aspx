<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeFile="MechanicDetail.aspx.cs" Inherits="MechanicDetail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="row-fluid sortable ui-sortable">
        <div class="box span12">
            <div class="box-header" data-original-title>
                <h2>
                    <i class="halflings-icon edit"></i><span class="break"></span>Add Mechanic</h2>
            </div>
            <div class="box-content">
                <div class="form-horizontal">
                    <fieldset>
                        <div class="control-group">
                            <label class="control-label" for="focusedInput">
                                Mechanic </label>
                            <div class="controls">
                                <asp:TextBox ID="txtMechanicName" CssClass="input-xlarge focused" placeholder="Enter Name"
                                    runat="Server"></asp:TextBox>
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
                                City </label>
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
                                    runat="Server"></asp:TextBox>
                                  <asp:RequiredFieldValidator ControlToValidate="txtMechanicEmail" ID="RequiredFieldValidator2" SetFocusOnError="true" EnableClientScript="true" ForeColor="Red" ValidationGroup="save" runat="server" ErrorMessage="Required"></asp:RequiredFieldValidator>
                                    <asp:RegularExpressionValidator ControlToValidate="txtMechanicEmail" ID="RegularExpressionValidator1" runat="server" 
                                        ErrorMessage="Invalid" SetFocusOnError="true" EnableClientScript="true" 
                                        ForeColor="Red" ValidationGroup="save" 
                                        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
								
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
                                Mechanic Photo</label>
                            <div class="controls">
                                <asp:FileUpload ID="MechanicPhoto" runat="server" />
                            </div>
                        </div>
                        <div class="control-group">
                            <label class="control-label" for="focusedInput">
                                Contact No</label>
                            <div class="controls">
                                <asp:TextBox ID="txtMechanicMobileNo" CssClass="input-xlarge focused" placeholder="Enter Contact No"
                                    runat="Server"></asp:TextBox>
                                    <asp:RequiredFieldValidator ControlToValidate="txtMechanicMobileNo" ID="RequiredFieldValidator3" SetFocusOnError="true" EnableClientScript="true" ForeColor="Red" ValidationGroup="save" runat="server" ErrorMessage="Required"></asp:RequiredFieldValidator>
								
                                   <asp:RegularExpressionValidator ControlToValidate="txtMechanicMobileNo" ID="RegularExpressionValidator2" runat="server" 
                                        ErrorMessage="Invalid" SetFocusOnError="true" EnableClientScript="true" 
                                        ForeColor="Red" ValidationGroup="save" 
                                        ValidationExpression="^[0-9]{10,10}$"></asp:RegularExpressionValidator>
								
                            </div>
                        </div>
                        <div class="control-group">
                            <label class="control-label" for="focusedInput">
                                Photo Proof</label>
                            <div class="controls">
                                <asp:FileUpload ID="MechanicPhotoProof" runat="server" />
                            </div>
                        </div>
                        <!--<div class="control-group">
                            <label class="control-label" for="date01">
                                Joining Datet</label>
                            <div class="controls">
                                <asp:TextBox ID="txtJoiningDate" class="input-xlarge datepicker" value="04/04/16"
                                    runat="server"></asp:TextBox>
                            </div>
                        </div>-->
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
