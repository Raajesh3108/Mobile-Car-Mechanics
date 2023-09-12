<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" MaintainScrollPositionOnPostback="true"
    CodeFile="MechanicProfile.aspx.cs" Inherits="MechanicProfile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="row-fluid sortable ui-sortable">
        <div class="box span12">
            <div class="box-header" data-original-title>
                <h2>
                    <i class="halflings-icon edit"></i><span class="break"></span>Update Profile</h2>
            </div>
            <div>
                <h2 runat="server" id="SuccessMsg" class="alert alert-success" visible="false">
                    <tt></tt>Successfully Updateded!!</h2>
            </div>
            <div class="box-content">
                <div class="form-horizontal">
                    <fieldset>
                        <div class="control-group">
                            <label class="control-label" for="focusedInput">
                                Mechanic </label>
                            <div class="controls">
                                <asp:TextBox ID="txtMechanicName" CssClass="input-xlarge focused" placeholder="Enter Name"
                                    runat="Server"></asp:TextBox>
                            </div>
                        </div>
                        <div class="control-group">
                            <label class="control-label" for="focusedInput">
                                Address</label>
                            <div class="controls">
                                <asp:TextBox ID="txtMechanicAddress" CssClass="input-xlarge focused" placeholder="Enter Address"
                                    TextMode="MultiLine" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div class="control-group">
                            <label class="control-label" for="focusedInput">
                                City</label>
                            <div class="controls">
                                <asp:DropDownList ID="ddlCity" runat="server">
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="control-group">
                            <label class="control-label" for="focusedInput">
                                Email</label>
                            <div class="controls">
                                <asp:TextBox ID="txtMechanicEmail" CssClass="input-xlarge focused" placeholder="Enter Email"
                                    runat="Server"></asp:TextBox>
                            </div>
                        </div>
                        <div class="control-group">
                            <label class="control-label" for="focusedInput">
                                Mechanic Photo</label>
                            <div class="controls">
                                <asp:FileUpload ID="MechanicPhoto" runat="server" />
                            </div>
                        </div>
                        <div class="control-group">
                            <label class="control-label" for="focusedInput">
                                Contact No</label>
                            <div class="controls">
                                <asp:TextBox ID="txtMechanicMobileNo" CssClass="input-xlarge focused" placeholder="Enter Contact No"
                                    runat="Server"></asp:TextBox>
                            </div>
                        </div>
                        <div class="control-group">
                            <label class="control-label" for="focusedInput">
                                Photo Proof</label>
                            <div class="controls">
                                <asp:FileUpload ID="MechanicPhotoProof" runat="server" />
                            </div>
                        </div>
                        <div class="form-actions">
                            <asp:Button ID="btnSave" class="btn btn-primary" runat="server" Text="Save changes"
                                OnClick="btnSave_Click" />
                        </div>
                        <br />
                        <br />
                        <div class="box-header" data-original-title>
                            <h2>
                                <i class="halflings-icon edit"></i><span class="break"></span>Change Password</h2>
                        </div><br />
                        <div>
                <h2 runat="server" id="SuccessMsg1" class="alert alert-success" visible="false">
                    <tt></tt>Password Successfully Changed!!</h2>
            </div>
            <div>
                <h2 runat="server" id="FailMsg1" class="alert alert-success" visible="false">
                    <tt></tt>Incorrect Passoword!!</h2>
            </div>
                        <div class="control-group">
                            <label class="control-label" for="focusedInput">
                                Old Password</label>
                            <div class="controls">
                                <asp:TextBox ID="txtMechanicOldPassword" CssClass="input-xlarge focused" placeholder="Enter Old Password"
                                    TextMode="Password" runat="Server"></asp:TextBox>
                            </div>
                        </div>
                        <div class="control-group">
                            <label class="control-label" for="focusedInput">
                                New Password</label>
                            <div class="controls">
                                <asp:TextBox ID="txtMechanicNewPassword" CssClass="input-xlarge focused" placeholder="Enter New Password"
                                    TextMode="Password" runat="Server"></asp:TextBox>
                            </div>
                        </div>
                        <div class="control-group">
                            <label class="control-label" for="focusedInput">
                                Confirm Password</label>
                            <div class="controls">
                                <asp:TextBox ID="txtMechanicConfirmPassword" CssClass="input-xlarge focused" placeholder="Re-enter Password"
                                    TextMode="Password" runat="Server"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-actions">
                            <asp:Button ID="btnChangePassword" class="btn btn-primary" runat="server" Text="Change Password"
                                OnClick="btnChangePassword_Click" />
                        </div>
                    </fieldset>
                </div>
            </div>
        </div>
        <!--/span-->
    </div>
    <div class="row-fluid sortable ui-sortable">
        <div class="box span12">
            <div class="box-header" data-original-title>
                <h2>
                    <i class="halflings-icon edit"></i><span class="break"></span>Manage Areas</h2>
            </div>
            <div class="box-content">
                <div class="form-horizontal">
                    <fieldset>
                        <div class="control-group">
                            <label class="control-label" for="focusedInput">
                                Area</label>
                            <div class="controls">
                                <asp:DropDownList ID="ddlAreas" runat="server">
                                </asp:DropDownList>
                                 <asp:Button ID="btnAddArea" class="btn btn-primary" runat="server" Text="Add Area"
                                OnClick="btnAddArea_Click" />
                            </div>
                        </div>
                        <div class="form-actions">
                           
                        </div>
                    </fieldset>
                </div>
            </div>
            <div class="box-content">
                <asp:GridView ID="GridView1" CssClass="table table-striped" runat="server" AutoGenerateColumns="false"
                    GridLines="None">
                    <Columns>
                        <asp:TemplateField HeaderText="Area Name">
                            <ItemTemplate>
                                <%# Eval("AreaName") %>
                            </ItemTemplate>
                        </asp:TemplateField>
                        
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:Button ID="btnRemoveArea" runat="server" Text="Remove" OnCommand="btnRemoveArea_Command"
                                    CommandArgument='<%# Eval("MechanicAreaID") %>' />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </div>
        </div>
        <!--/span-->
    </div>


    <div class="row-fluid sortable ui-sortable">
        <div class="box span12">
            <div class="box-header" data-original-title>
                <h2>
                    <i class="halflings-icon edit"></i><span class="break"></span>Manage Categories</h2>
            </div>
            <div class="box-content">
                <div class="form-horizontal">
                    <fieldset>
                        <div class="control-group">
                            <label class="control-label" for="focusedInput">
                                Category</label>
                            <div class="controls">
                                <asp:DropDownList ID="ddlCategories" runat="server">
                                </asp:DropDownList>
                            <asp:Button ID="btnAddCategory" class="btn btn-primary" runat="server" 
                                Text="Add Category" onclick="btnAddCategory_Click"/>
                        </div>
                    </fieldset>
                </div>
            </div>
            <div class="box-content">
                <asp:GridView ID="GridView2" CssClass="table table-striped" runat="server" AutoGenerateColumns="false"
                    GridLines="None">
                    <Columns>
                        <asp:TemplateField HeaderText="Category Name">
                            <ItemTemplate>
                                <%# Eval("ServiceCategoryName") %>
                            </ItemTemplate>
                        </asp:TemplateField>
                        
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:Button ID="btnRemoveCategory" runat="server" Text="Remove" OnCommand="btnRemoveCategory_Command"
                                    CommandArgument='<%# Eval("MechanicCategoryID") %>' />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </div>
        </div>
        <!--/span-->
    </div>


    <div class="row-fluid sortable ui-sortable">
        <div class="box span12">
            <div class="box-header" data-original-title>
                <h2>
                    <i class="halflings-icon edit"></i><span class="break"></span>Manage Categories</h2>
            </div>
            <div class="box-content">
                <div class="form-horizontal">
                    <fieldset>
                        <div class="control-group">
                            <label class="control-label" for="focusedInput">
                                Service</label>
                            <div class="controls">
                                <asp:DropDownList ID="ddlServices" runat="server">
                                </asp:DropDownList>

                                <asp:TextBox ID="txtPrice" runat="server" PlaceHolder="Price" />

                            <asp:Button ID="btnAddService" class="btn btn-primary" runat="server" 
                                Text="Add Service" onclick="btnAddService_Click"/>
                        </div>
                    </fieldset>
                </div>
            </div>
            <div class="box-content">
                <asp:GridView ID="GridView3" CssClass="table table-striped" runat="server" AutoGenerateColumns="false"
                    GridLines="None">
                    <Columns>
                        <asp:TemplateField HeaderText="Service Name">
                            <ItemTemplate>
                                <%# Eval("ServiceName") %>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Price">
                            <ItemTemplate>
                                <%# Eval("Price")%>
                            </ItemTemplate>
                        </asp:TemplateField>

                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:Button ID="btnRemoveService" runat="server" Text="Remove" OnCommand="btnRemoveService_Command"
                                    CommandArgument='<%# Eval("MechanicServiceID") %>' />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </div>
        </div>
        <!--/span-->
    </div>

</asp:Content>
