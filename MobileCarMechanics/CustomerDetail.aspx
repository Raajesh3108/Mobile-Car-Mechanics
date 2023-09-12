<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="CustomerDetail.aspx.cs" Inherits="CustomerDetail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<div class="row-fluid sortable ui-sortable">
				<div class="box span12">
					<div class="box-header" data-original-title>
						<h2><i class="halflings-icon edit"></i><span class="break"></span>Add Customer</h2>
						
					</div>
					<div class="box-content">
						<div class="form-horizontal">
							<fieldset>
							  <div class="control-group">
								<label class="control-label" for="focusedInput">Name</label>
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
								<label class="control-label" for="focusedInput">Mobile</label>
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
                            <label class="control-label" for="focusedInput">Customer Photo</label>
                            <div class="controls">
                                <asp:FileUpload ID="CustomerPhoto" runat="server" />
                            </div>
                        </div>
                                
							 
							  <div class="form-actions">
								<asp:Button ID="btnSave" class="btn btn-primary" runat="server" ValidationGroup="save"
                                      Text="Save changes" onclick="btnSave_Click"/>
								<asp:Button ID="btnDelete" class="btn btn-danger" runat="server" Text="Delete" 
                                      onclick="btnDelete_Click" />
							  </div>
                          
							</fieldset>
						  </div>
					
					</div>
				</div><!--/span-->
			
			</div>

</asp:Content>

