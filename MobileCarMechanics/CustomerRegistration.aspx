<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="CustomerRegistration.aspx.cs" Inherits="CustomerRegistration" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
<style>
    label.control-label
    {
        text-align:left;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<%--
<div class="row-fluid sortable ui-sortable" >
				<div class="box span12">
					<div class="box-header" data-original-title>--%>
                    <div style="margin-left:350px;margin-right:350px">
						<h2 style="color:White"><strong><i class="icon-edit"></i><span class="break"></span>Customer Register Here..</strong></h2>
						<br />
                       </div>
                        <div style="margin-left:350px;margin-right:350px">
                        <h2  runat="server" id="successMsg" class="alert alert-success" visible="false"><tt></tt> Successfully Registered!! Please <a href="CustomerLogin.aspx">Login</a> Now!!</h2>
                        </div>
					<%--<div class="box-content">--%>
						<div class="form-horizontal"  >
							<fieldset>
							  <div style="margin-left:350px;margin-right:350px;background-color:White;position:relative;top:10px;opacity:0.9">
                              <div class="control-group">
								<label class="control-label"  for="focusedInput">Name</label>
								<div class="controls">
                                  <asp:TextBox ID="txtCustomerName" CssClass="input-xlarge focused" placeholder="Enter Your Name" Runat="Server"></asp:TextBox> 
								  <asp:RequiredFieldValidator ControlToValidate="txtCustomerName" ID="RequiredFieldValidator1" SetFocusOnError="true" EnableClientScript="true" ForeColor="Red" ValidationGroup="save" runat="server" ErrorMessage="Required"></asp:RequiredFieldValidator>
								 
								</div>
							  </div>
							  <div class="control-group">
								<label class="control-label" for="focusedInput">EmailID</label>
								<div class="controls">
                                 <asp:TextBox ID="txtCustomerEmail" CssClass="input-xlarge focused" placeholder="Enter Your EmailID" runat="server"></asp:TextBox>
                                 <asp:RequiredFieldValidator ControlToValidate="txtCustomerEmail" ID="RequiredFieldValidator2" SetFocusOnError="true" EnableClientScript="true" ForeColor="Red" ValidationGroup="save" runat="server" ErrorMessage="Required"></asp:RequiredFieldValidator>
                                    <asp:RegularExpressionValidator ControlToValidate="txtCustomerEmail" ID="RegularExpressionValidator1" runat="server" 
                                        ErrorMessage="Invalid" SetFocusOnError="true" EnableClientScript="true" 
                                        ForeColor="Red" ValidationGroup="save" 
                                        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
								
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
                             <asp:TextBox ID="txtCustomerMobileNo" CssClass="input-xlarge focused" placeholder="Enter Your Contact No" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ControlToValidate="txtCustomerMobileNo" ID="RequiredFieldValidator3" SetFocusOnError="true" EnableClientScript="true" ForeColor="Red" ValidationGroup="save" runat="server" ErrorMessage="Required"></asp:RequiredFieldValidator>
								
                                   <asp:RegularExpressionValidator ControlToValidate="txtCustomerMobileNo" ID="RegularExpressionValidator2" runat="server" 
                                        ErrorMessage="Invalid" SetFocusOnError="true" EnableClientScript="true" 
                                        ForeColor="Red" ValidationGroup="save" 
                                        ValidationExpression="^[0-9]{10,10}$"></asp:RegularExpressionValidator>
								
								</div>
							  </div>
                             

                              <div class="control-group">
								<label class="control-label" for="focusedInput">Address</label>
								<div class="controls">
                                    <asp:TextBox ID="txtCustomerAddress" CssClass="input-xlarge focused" TextMode="MultiLine" runat="server"></asp:TextBox>
								 
								</div>
							  </div>


                              <div class="control-group">
								<label class="control-label" for="focusedInput">User Name</label>
								<div class="controls">
                                 <asp:TextBox ID="txtCustomerUsername" CssClass="input-xlarge focused" placeholder="Enter Username" runat="server"></asp:TextBox>
                              
								</div>
							  </div>

                              <div class="control-group">
								<label class="control-label" for="focusedInput">Password</label>
								<div class="controls">
                                 <asp:TextBox ID="txtPassword" CssClass="input-xlarge focused" TextMode="Password" placeholder="Enter Password" runat="server"></asp:TextBox>
                              </div>
							  </div>
                                

                                 <div class="control-group">
								<label class="control-label" for="focusedInput">Confirm Password</label>
								<div class="controls">
                                  <asp:TextBox ID="txtConfirm" TextMode="Password"  placeholder="Re-Enter Password" CssClass="input-text" runat="server"></asp:TextBox>
                                  <asp:CompareValidator id="comparePasswords" runat="server" ControlToCompare="txtPassword"
                                  ControlToValidate="txtConfirm" ErrorMessage="Your passwords do not match up!" Display="Dynamic" />
                              </div>
							  </div>




                             <div class="control-group">
                            <label class="control-label" for="focusedInput">Photo</label>
                            <div class="controls">
                                <asp:FileUpload ID="CustomerPhoto" runat="server" />
                            </div>
                        </div>
                                
							
							 
								<asp:Button ID="btnSignUp" class="btn btn-primary" style="position:relative;left:200px" runat="server" ValidationGroup="save"
                                      Text="SignUp" onclick="btnSignUp_Click" />
                                    
                                   </div>   
                                    </fieldset>  
							
                         
							 </div>
						

</asp:Content>

