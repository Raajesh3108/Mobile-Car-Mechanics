<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="MyVehicle.aspx.cs" Inherits="MyVehicle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<div class="row-fluid sortable ui-sortable">
<div class="box span12">
					<div class="box-header" data-original-title>
						<h2><i class="halflings-icon edit"></i><span class="break"></span>Add Vehicle</h2>
						
					</div>
					<div class="box-content">
						<div class="form-horizontal">
							<fieldset>
							  <div class="control-group">
								<label class="control-label" for="focusedInput">Vehicle Number</label>
								<div class="controls">
                                  <asp:TextBox ID="txtVehicleNumber" CssClass="input-xlarge focused" placeholder="Enter Vehicle Number" Runat="Server"></asp:TextBox> 
								   
								</div>
							  </div>
							  <div class="control-group">
								<label class="control-label" for="focusedInput">Company Name</label>
								<div class="controls">
                                 <asp:TextBox ID="txtMake" CssClass="input-xlarge focused" placeholder="Enter Company Name" runat="server"></asp:TextBox>
                              
								</div>
							  </div>

                               <div class="control-group">
								<label class="control-label" for="focusedInput">Car Model</label>
								<div class="controls">
                                 <asp:TextBox ID="txtModel" CssClass="input-xlarge focused" placeholder="Enter Model Detail" runat="server"></asp:TextBox>
                              
								</div>
							  </div>
                                
                             <div class="control-group">
                            <label class="control-label" for="focusedInput">Vehicle Photo</label>
                            <div class="controls">
                                <asp:FileUpload ID="VehiclePhoto" runat="server" />
                            </div>
                        </div>
                                
							 
							  <div class="form-actions">
								<asp:Button ID="btnSave" class="btn btn-primary" runat="server" 
                                      Text="Save changes" onclick="btnSave_Click"/>
								<asp:Button ID="btnDelete" class="btn btn-danger" runat="server" Text="Delete" 
                                      onclick="btnDelete_Click" />

							  </div>
                          
							</fieldset>
						  </div>
					
					</div>
				</div>

</div>

</asp:Content>

