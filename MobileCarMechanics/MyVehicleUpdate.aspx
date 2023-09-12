<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="MyVehicleUpdate.aspx.cs" Inherits="MyVehicleUpdate" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<div class="row-fluid sortable ui-sortable">
				<div class="box span12">
					<div class="box-header" data-original-title>
						<h2><i class="halflings-icon edit"></i><span class="break"></span>Update Vehicle</h2>
						
					</div>
					<div class="box-content">
						<div class="form-horizontal">
                         <asp:GridView ID="GridView1" CssClass="table table-bordered" runat="server" 
                                AutoGenerateColumns="false" GridLines="None">

                        <Columns>
                           
                            <asp:TemplateField HeaderText="Vehicle Number">
                                <ItemTemplate>
                                    <%# Eval("VehicleNumber")%>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Company Name">
                                <ItemTemplate>
                                    <%# Eval("Make") %>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Model">
                                <ItemTemplate>
                                    <%# Eval("Model") %>
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

