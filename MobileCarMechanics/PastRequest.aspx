<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="PastRequest.aspx.cs" Inherits="PastRequest" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<div class="row-fluid sortable ui-sortable">
				<div class="box span12">
					<div class="box-header" data-original-title>
						<h2><i class="halflings-icon edit"></i><span class="break"></span>Past Requests</h2>
						
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
                            <asp:TemplateField HeaderText="Request Time">
                                <ItemTemplate>
                                    <%# Eval("RequestTime", "{0:dd-MM-yyyy HH:mm}")%>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Status">
                                <ItemTemplate>
                                    <%# Eval("Status") %>
                                </ItemTemplate>
                            </asp:TemplateField>                            
                             <asp:TemplateField HeaderText="Completion Time">
                                <ItemTemplate>
                                    <%# Eval("CompletionTime", "{0:dd-MM-yyyy HH:mm}")%>                                    
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Feedback">
                                <ItemTemplate>
                                    <%# Eval("Feedback") %>                                    
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Rating">
                                <ItemTemplate>
                                    <%# Eval("Rating") %>                                    
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>

                        </asp:GridView>
						  </div>
					
					</div>
				</div><!--/span-->
			
			</div>

</asp:Content>

