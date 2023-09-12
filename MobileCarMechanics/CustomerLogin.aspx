<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="CustomerLogin.aspx.cs" Inherits="CustomerLogin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


   <div class="container-fluid-full" >
		<div class="row-fluid" >
					
			<div class="row-fluid" >
				<div class="login-box" style="background-color:White;position:relative;top:10px;opacity:0.9">
					<div class="icons">
					</div>
					<h2><b>Login to your account</b></h2>
                    <h2 runat="server" style="position:relative;left:-15px" id="failMsg" class="alert alert-error" visible="false">Invalid Username or Password!!</h2>
					<div class="form-horizontal">
						<fieldset>
							
							<div class="input-prepend" title="Username">
								<asp:TextBox ID="txtCustomerUsername" class="input-large span10" name="Username" placeholder="Enter Username" runat="server"></asp:TextBox>
								</div>
							<div class="clearfix"></div>
           
							<div class="input-prepend" title="Password">
								<asp:TextBox ID="txtCustomerPassword" class="input-large span10" name="Password" placeholder="Enter Password" TextMode="Password" runat="server"></asp:TextBox>
							</div>
							
							<div class="button-login">                           
                                <asp:Button ID="btnCustomerLogin" class="btn btn-primary" runat="server" 
                                    Text="Login" Width="91px"  style="position:relative;top:-20px" onclick="btnCustomerLogin_Click" />
                                    <br />
                                    <br />
							</div>
                            <br />
						
					<p>
						<h3><a href="LostPass.aspx">Forgot Password?</a></h3>
					</p>
                            </fieldset>
					</div>
						
				</div><!--/span-->
			</div><!--/row-->
			

	</div><!--/.fluid-container-->
	
		</div>

</asp:Content>

