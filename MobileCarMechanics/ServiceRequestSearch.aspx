<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ServiceRequestSearch.aspx.cs" Inherits="ServiceRequestSearch" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


<div class="row-fluid sortable ui-sortable">
				<div class="box span12">
					<div class="box-header" data-original-title>
						<h2><i class="halflings-icon edit"></i><span class="break"></span>Search Service Request</h2>
					
					</div>
					<div class="box-content">
						<div class="form-horizontal">
							<fieldset>
							  <div class="control-group">
								<label class="control-label" for="focusedInput">Service Request</label>
								<div class="controls">
                                  <asp:TextBox ID="txtServiceRequestName" CssClass="input-xlarge focused" placeholder="Search Service Request" Runat="Server"></asp:TextBox> 
								</div>
							  </div>
							  
							  <div class="form-actions">
								<asp:Button ID="btnSearch" class="btn btn-primary" runat="server" Text="Search" 
                                      onclick="btnSearch_Click"/>
								
                          
							</fieldset>

                             <br /><br />
                        <asp:GridView ID="GridViewArea" CssClass="table table-striped" runat="server" AutoGenerateColumns="false" GridLines="None">

                        <Columns>
                            <asp:TemplateField HeaderText="Vehicle_ID">
                                <ItemTemplate>
                                    <%# Eval("VehicleID") %>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Service_ID">
                                <ItemTemplate>
                                    <%# Eval("MechanicServiceID") %>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Service Details">
                                <ItemTemplate>
                                    <%# Eval("ServiceRequestDetails") %>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Status">
                                <ItemTemplate>
                                    <%# Eval("Status") %>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Reply">
                                <ItemTemplate>
                                    <%# Eval("Reply") %>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <a href='<%# "ServiceRequestDetail.aspx?ID=" + Eval("ServiceRequestID") %>'>EDIT</a>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>

                        </asp:GridView>
						  </div>
					
					</div>
				</div><!--/span-->
			
			</div>

</asp:Content>

