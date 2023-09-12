<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ServiceCategorySearch.aspx.cs" Inherits="ServiceCategorySearch" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<div class="row-fluid sortable ui-sortable">
				<div class="box span12">
					<div class="box-header" data-original-title>
						<h2><i class="halflings-icon edit"></i><span class="break"></span>Service Category Search</h2>
						
					</div>
					<div class="box-content">
						<div class="form-horizontal">
							<fieldset>
							  <div class="control-group">
								<label class="control-label" for="focusedInput">Category </label>
								<div class="controls">
                                  <asp:TextBox ID="txtServiceCategorySearchName" CssClass="input-xlarge focused" placeholder="Enter Category Name" Runat="Server"></asp:TextBox> 
								</div>
							  </div>
							  
							  <div class="form-actions">
								<asp:Button ID="btnSearch" class="btn btn-primary" runat="server" Text="Search" 
                                      onclick="btnSearch_Click"/>
								
                          
							</fieldset>
                             <br /><br />

                            <asp:GridView ID="GridViewServiceCategory" CssClass="table table-striped" runat="server" 
                                AutoGenerateColumns="false" GridLines="None"  >

                        <Columns>
                            
                            <asp:TemplateField HeaderText="Category">
                                <ItemTemplate>
                                    <%# Eval("ServiceCategoryName")%>
                                </ItemTemplate>
                            </asp:TemplateField>
                             
                            <asp:TemplateField HeaderText="Category Photo">
                                <ItemTemplate>
                                    <img style="max-width: 100px; max-height: 100px" src='<%# "servicecategoryuploads/" + Eval("ServiceCategoryPhoto") %>' />
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Category Details">
                                <ItemTemplate>
                                    <%# Eval("ServiceCategoryDetails") %>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <a href='<%# "ServiceCategoryDetail.aspx?ID=" + Eval("ServiceCategoryID") %>'>EDIT</a>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>

                        </asp:GridView>
						  </div>
					
					</div>
				</div><!--/span-->
			
			</div>					  

</asp:Content>
