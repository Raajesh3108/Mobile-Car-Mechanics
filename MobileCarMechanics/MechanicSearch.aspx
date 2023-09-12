<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="MechanicSearch.aspx.cs" Inherits="MechanicSearch" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<div class="row-fluid sortable ui-sortable">
				<div class="box span12">
					<div class="box-header" data-original-title>
						<h2><i class="halflings-icon edit"></i><span class="break"></span>Search Mecahnic</h2>
						
					</div>
					<div class="box-content">
						<div class="form-horizontal">
							<fieldset>
							  <div class="control-group">
								<label class="control-label" for="focusedInput">Mechanic</label>
								<div class="controls">
                                  <asp:TextBox ID="txtMechanicSearchName" CssClass="input-xlarge focused" placeholder="Enter Mechanic Name" Runat="Server"></asp:TextBox> 
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
                           
                            <asp:TemplateField HeaderText="Name">
                                <ItemTemplate>
                                    <%# Eval("MechanicName") %>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Address">
                                <ItemTemplate>
                                    <%# Eval("MechanicAddress")%>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="City">
                                <ItemTemplate>
                                    <%# Eval("CityName")%>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Email">
                                <ItemTemplate>
                                    <%# Eval("MechanicEmail")%>
                                </ItemTemplate>
                            </asp:TemplateField>

                              <asp:TemplateField HeaderText="MobileNo">
                                <ItemTemplate>
                                    <%# Eval("MechanicMobileNo")%>
                                </ItemTemplate>
                            </asp:TemplateField>


                             <asp:TemplateField HeaderText="Username">
                                <ItemTemplate>
                                    <%# Eval("MechanicUsername")%>
                                </ItemTemplate>
                            </asp:TemplateField>

                             <asp:TemplateField HeaderText="Photo">
                                <ItemTemplate>
                                   <img style="max-width: 100px; max-height: 100px" src='<%# "mechanicuploads/" + Eval("MechanicPhoto") %>' />
                                </ItemTemplate>
                            </asp:TemplateField>

                            
                              <asp:TemplateField HeaderText="Photo Proof">
                                <ItemTemplate>
                                     <img style="max-width: 100px; max-height: 100px" src='<%# "mechanicuploads/" + Eval("MechanicPhotoProof") %>' />
                                </ItemTemplate>
                            </asp:TemplateField>
                            


                            <asp:TemplateField>
                                <ItemTemplate>
                                    <a href='<%# "MechanicDetail.aspx?ID=" + Eval("MechanicID") %>'>EDIT</a>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>

                        </asp:GridView>
						  </div>
					
					</div>
				</div><!--/span-->
			
			</div>
</asp:Content>

