<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="CustomerSearch.aspx.cs" Inherits="CustomerSearch" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<div class="row-fluid sortable ui-sortable">
				<div class="box span12">
					<div class="box-header" data-original-title>
						<h2><i class="halflings-icon edit"></i><span class="break"></span>Search Customer</h2>
					
					</div>
					<div class="box-content">
						<div class="form-horizontal">
							<fieldset>
							  <div class="control-group">
								<label class="control-label" for="focusedInput">Customer Name</label>
								<div class="controls">
                                  <asp:TextBox ID="txtCustomerSearchName" CssClass="input-xlarge focused" placeholder="Enter Customer Name" Runat="Server"></asp:TextBox> 
								</div>
							  </div>
							  
							  <div class="form-actions">
								<asp:Button ID="btnSearch" class="btn btn-primary" runat="server" Text="Search" 
                                      onclick="btnSearch_Click"/>
								
                          
							</fieldset>

                             <br /><br />
                        <asp:GridView ID="GridViewArea" CssClass="table table-striped" runat="server" AutoGenerateColumns="false" GridLines="None">

                        <Columns>
                            <asp:TemplateField HeaderText="Name">
                                <ItemTemplate>
                                    <%# Eval("CustomerName") %>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Email">
                                <ItemTemplate>
                                    <%# Eval("CustomerEmail") %>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Area ">
                                <ItemTemplate>
                                    <%# Eval("AreaName") %>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Mobile No">
                                <ItemTemplate>
                                    <%# Eval("CustomerMobileNo") %>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Address">
                                <ItemTemplate>
                                    <%# Eval("CustomerAddress") %>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="User Name">
                                <ItemTemplate>
                                    <%# Eval("CustomerUsername") %>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Password">
                                <ItemTemplate>
                                    <%# Eval("CustomerPassword") %>
                                </ItemTemplate>
                            </asp:TemplateField>
                             <asp:TemplateField HeaderText="Customer Photo">
                                <ItemTemplate>
                                    <img style="max-width: 100px; max-height: 100px" src='<%# "Customeruploads/" + Eval("CustomerPhoto") %>' />
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <a href='<%# "CustomerDetail.aspx?ID=" + Eval("CustomerID") %>'>EDIT</a>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>

                        </asp:GridView>
						  </div>
					
					</div>
				</div><!--/span-->
			
			</div>
</asp:Content>

