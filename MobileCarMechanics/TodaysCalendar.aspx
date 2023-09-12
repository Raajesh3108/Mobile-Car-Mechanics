<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="TodaysCalendar.aspx.cs" Inherits="TodaysCalendar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<div class="row-fluid sortable ui-sortable">
				<div class="box span12">
					<div class="box-header" data-original-title>
						<h2><i class="halflings-icon edit"></i><span class="break"></span>Today's Calendar</h2>
						
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
                             <asp:TemplateField HeaderText="Request Details">
                                <ItemTemplate>
                                    <%# Eval("ServiceRequestDetails") %>                                    
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>

                        </asp:GridView>
						  </div>
					
					</div>
				</div><!--/span-->
			
			</div>

</asp:Content>

