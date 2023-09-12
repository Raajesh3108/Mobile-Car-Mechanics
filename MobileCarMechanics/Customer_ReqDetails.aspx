<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Customer_ReqDetails.aspx.cs" Inherits="Customer_ReqDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="row-fluid sortable ui-sortable">
            <div class="box-content">
                <div class="form-horizontal">
                    
                        <div class="alert alert-success">
                            <asp:Button ID="btnClose" runat="server" class="close" data-dismiss="alert" Text="×" />
							
							<h3><strong>Congratulations!</strong>Your Request Has successfully Submitted</h3>
						</div>
                        <div>
                      
						<h3>To View Status..<a href="Customer_MyRequest.aspx">Click Here</a></h3>
					
                        </div>
                </div>
            </div>
        </div>
        <!--/span-->
</asp:Content>

