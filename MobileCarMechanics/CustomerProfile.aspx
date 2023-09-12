<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="CustomerProfile.aspx.cs" Inherits="CustomerProfile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


<div class="row-fluid sortable ui-sortable">
				<div class="box span12">
					<div class="box-header" data-original-title>
						<h2><i class="halflings-icon edit"></i><span class="break"></span>Add Customer</h2>
						
					</div>
                    <div>
                <h2 runat="server" id="SuccessMsg" class="alert alert-success" visible="false">
                    <tt></tt>Successfully Updateded!!</h2>
            </div>
					<div class="box-content">
						<div class="form-horizontal">
							<fieldset>
							  <div class="control-group">
								<label class="control-label" for="focusedInput">Customer Name</label>
								<div class="controls">
                                  <asp:TextBox ID="txtCustomerName" CssClass="input-xlarge focused" placeholder="Enter Your Name" Runat="Server"></asp:TextBox> 
								   
								</div>
							  </div>
							  <div class="control-group">
								<label class="control-label" for="focusedInput">EmailID</label>
								<div class="controls">
                                 <asp:TextBox ID="txtCustomerEmail" CssClass="input-xlarge focused" placeholder="Enter Your EmailID" runat="server"></asp:TextBox>
                              
								</div>
							  </div>
                                
                              


                              <div class="control-group">
								<label class="control-label" for="focusedInput">Area</label>
								<div class="controls">
                                    <asp:DropDownList ID="ddlArea" runat="server">
                                    </asp:DropDownList>
                                </div>
							  </div>


                              	  <div class="control-group">
								<label class="control-label" for="focusedInput">Contact No</label>
								<div class="controls">
                             <asp:TextBox ID="txtCustomerMobile" CssClass="input-xlarge focused" placeholder="Enter Your Contact No" runat="server"></asp:TextBox>
                              
								</div>
							  </div>
                             

                              <div class="control-group">
								<label class="control-label" for="focusedInput">Customer Address</label>
								<div class="controls">
                                    <asp:TextBox ID="txtCustomerAddress" CssClass="input-xlarge focused" TextMode="MultiLine" runat="server"></asp:TextBox>
								 
								</div>
							  </div>


                       
                             <div class="control-group">
                            <label class="control-label" for="focusedInput">Customer Photo</label>
                            <div class="controls">
                                <asp:FileUpload ID="CustomerPhoto" runat="server" />
                            </div>
                        </div>
                                
							 
							  <div class="form-actions">
								<asp:Button ID="btnSave" class="btn btn-primary" runat="server" 
                                      Text="Save changes" onclick="btnSave_Click"/>
							  </div>
                               <br />
                        <br />
                     
                         <div class="box-header" data-original-title>
                            <h2>
                                <i class="halflings-icon edit"></i><span class="break"></span>Change Password</h2>
                        </div>
                        <div>
                <h2 runat="server" id="SuccessMsg1" class="alert alert-success" visible="false">
                    <tt></tt>Password Successfully Changed!!</h2>
            </div>
             <div>
                <h2 runat="server" id="FailedMSg1" class="alert alert-success" visible="false">
                    <tt></tt>Incorrect Passoword!!</h2>
            </div>
                        <div class="control-group">
                            <label class="control-label" for="focusedInput">
                                Old Password</label>
                            <div class="controls">
                                <asp:TextBox ID="txtoCustomerOldPassword" CssClass="input-xlarge focused" placeholder="Enter Old Password"
                                    TextMode="Password" runat="Server"></asp:TextBox>
                            </div>
                        </div>
                        <div class="control-group">
                            <label class="control-label" for="focusedInput">
                                New Password</label>
                            <div class="controls">
                                <asp:TextBox ID="txtCustomerNewPassword" CssClass="input-xlarge focused" placeholder="Enter New Password"
                                    TextMode="Password" runat="Server"></asp:TextBox>
                            </div>
                        </div>
                        <div class="control-group">
                            <label class="control-label" for="focusedInput">
                                Confirm Password</label>
                            <div class="controls">
                                <asp:TextBox ID="txtCustomerConfirmPassword" CssClass="input-xlarge focused" placeholder="Re-enter Password"
                                    TextMode="Password" runat="Server"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-actions">
                            <asp:Button ID="btnChangePassword" class="btn btn-primary" runat="server" Text="Change Password"
                                OnClick="btnChangePassword_Click" />
                        </div>
						  
            </fieldset>
            
            </div>
            
            </div>
           

                
    

    

    
</asp:Content>

