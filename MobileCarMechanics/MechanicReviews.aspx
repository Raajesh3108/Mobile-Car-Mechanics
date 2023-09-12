<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="MechanicReviews.aspx.cs" Inherits="MechanicReviews" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<div class="row-fluid sortable ui-sortable">
				<div class="box span12">
					<div class="box-header" data-original-title>
						<h2><i class="halflings-icon edit"></i><span class="break"></span>Mechanic Reviews</h2>
						
					</div>
					<div class="box-content">
						<div class="form-horizontal">
                         <asp:GridView ID="GridView1" CssClass="table table-bordered" runat="server" 
                                AutoGenerateColumns="false" GridLines="None">

                        <Columns>
                           
                            <asp:TemplateField HeaderText="Customer">
                                <ItemTemplate>
                                    <%# Eval("CustomerName")%>
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

