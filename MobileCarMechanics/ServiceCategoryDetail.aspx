<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ServiceCategoryDetail.aspx.cs" Inherits="ServiceCategoryDetail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<div class="row-fluid sortable ui-sortable">
				<div class="box span12">
					<div class="box-header" data-original-title>
						<h2><i class="halflings-icon edit"></i><span class="break"></span>Add Service Category</h2>
						
					</div>
					<div class="box-content">
						<div class="form-horizontal">
							<fieldset>
							  <div class="control-group">
								<label class="control-label" for="focusedInput">Category</label>
								<div class="controls">
                                  <asp:TextBox ID="txtServiceCategoryName" CssClass="input-xlarge focused" placeholder="Enter Service Category Name" Runat="Server"></asp:TextBox> 
								</div>
							  </div>
                               <div class="control-group">
                            <label class="control-label" for="focusedInput">
                                Category Photo</label>
                            <div class="controls">
                                <asp:FileUpload ID="ServiceCategoryPhoto" runat="server" />
                            </div>
                        </div>
                             <div class="control-group">
								<label class="control-label" for="focusedInput">Category Details</label>
								<div class="controls">
                                  <asp:TextBox ID="txtServiceCategoryDetails" CssClass="input-xlarge focused" placeholder="Enter Description" Runat="Server"></asp:TextBox> 
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
				</div><!--/span-->
			
			</div>

</asp:Content>

