<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ServiceSearch.aspx.cs" Inherits="ServiceSearch" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<div class="row-fluid sortable ui-sortable">
				<div class="box span12">
					<div class="box-header" data-original-title>
						<h2><i class="halflings-icon edit"></i><span class="break"></span>Search Service</h2>
						
					</div>
					<div class="box-content">
						<div class="form-horizontal">
							<fieldset>
							  <div class="control-group">
								<label class="control-label" for="focusedInput">Service</label>
								<div class="controls">
                                  <asp:TextBox ID="txtServiceSearchName" CssClass="input-xlarge focused" placeholder="Enter Service Name" Runat="Server"></asp:TextBox> 
								<asp:Button ID="btnSearch" class="btn btn-primary" runat="server" Text="Search" 
                                      onclick="btnSearch_Click"/>
								
                                </div>
							  </div>
							  
							  
							</fieldset>

                             <br /><br />
                            <asp:GridView ID="GridViewService" CssClass="table table-striped" runat="server" 
                                AutoGenerateColumns="false" GridLines="None" 
                               >

                        <Columns>
                            
                            <asp:TemplateField HeaderText="Service">
                                <ItemTemplate>
                                    <%# Eval("ServiceName") %>
                                </ItemTemplate>
                            </asp:TemplateField>
                             <asp:TemplateField HeaderText="Photo">
                                <ItemTemplate>
                                    <img style="max-width: 100px; max-height: 100px" src='<%# "serviceuploads/" + Eval("ServicePhoto") %>' />
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Service Details">
                                <ItemTemplate>
                                    <%# Eval("ServiceDetails") %>
                                </ItemTemplate>
                            </asp:TemplateField>
                              <asp:TemplateField HeaderText="Category">
                                <ItemTemplate>
                                    <%# Eval("ServiceCategoryName") %>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <a href='<%# "ServiceDetail.aspx?ID=" + Eval("ServiceID") %>'>EDIT</a>
                                </ItemTemplate>
                            </asp:TemplateField>
                            
                        </Columns>

                        </asp:GridView>
						  </div>
					
					</div>
				</div><!--/span-->
			
			</div>

</asp:Content>

