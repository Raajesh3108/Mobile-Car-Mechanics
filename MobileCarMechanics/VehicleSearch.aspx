<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="VehicleSearch.aspx.cs" Inherits="VehicleSearch" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<div class="row-fluid sortable ui-sortable">
				<div class="box span12">
					<div class="box-header" data-original-title>
						<h2><i class="halflings-icon edit"></i><span class="break"></span>Search Vehicle</h2>
						
					</div>
					<div class="box-content">
						<div class="form-horizontal">
							<fieldset>
							  <div class="control-group">
								<label class="control-label" for="focusedInput">Vehicle Number</label>
								<div class="controls">
                                  <asp:TextBox ID="txtVehicleSearchNumber" CssClass="input-xlarge focused" placeholder="Enter Vehicle Number" Runat="Server"></asp:TextBox> 
								<asp:Button ID="btnSearch" class="btn btn-primary" runat="server" Text="Search" 
                                      onclick="btnSearch_Click"/>
								</div>
							  </div>
						
                          
							</fieldset>
                          
                          <br /><br />
                            <asp:GridView ID="GridViewCity" CssClass="table table-bordered" runat="server" 
                                AutoGenerateColumns="false" GridLines="None" 
                               >

                        <Columns>
                           
                            <asp:TemplateField HeaderText="Vehicle Number">
                                <ItemTemplate>
                                    <%# Eval("VehicleNumber")%>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Company">
                                <ItemTemplate>
                                    <%# Eval("Make") %>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Model">
                                <ItemTemplate>
                                    <%# Eval("Model") %>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Customer">
                                <ItemTemplate>
                                    <%# Eval("CustomerName") %>
                                </ItemTemplate>
                            </asp:TemplateField>
                             <asp:TemplateField HeaderText="Vehicle Photo">
                                <ItemTemplate>
                                    <img style="max-width: 100px; max-height: 100px" src='<%# "vehicleuploads/" + Eval("VehiclePhoto") %>' />
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <a href='<%# "VehicleDetail.aspx?ID=" + Eval("VehicleID") %>'>EDIT</a>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>

                        </asp:GridView>
						  </div>
					
					</div>
				</div><!--/span-->
			
			</div>

</asp:Content>

