<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeFile="ServiceRequestDetail.aspx.cs" Inherits="ServiceRequestDetail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="row-fluid sortable ui-sortable">
        <div class="box span12">
            <div class="box-header" data-original-title>
                <h2>
                    <i class="halflings-icon edit"></i><span class="break"></span>Search Service Request</h2>
            </div>
            <div class="box-content">
                <div class="form-horizontal">
                    <fieldset>
                        <div class="control-group">
                            <label class="control-label" for="focusedInput">
                                Vehicle Number</label>
                            <div class="controls">
                                <asp:DropDownList ID="ddlVehicle" runat="server">
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="control-group">
                            <label class="control-label" for="focusedInput">
                                Request Time</label>
                            <div class="controls">
                                <asp:TextBox ID="txtRequestTime" CssClass="input-xlarge focused" placeholder="Request Time"
                                    runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div class="control-group">
                            <label class="control-label" for="focusedInput">
                                Create Time</label>
                            <div class="controls">
                                <asp:TextBox ID="txtCreateTime" CssClass="input-xlarge focused" Enabled="false" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div class="control-group">
                            <label class="control-label" for="focusedInput">
                                Request Details</label>
                            <div class="controls">
                                <asp:TextBox ID="txtServiceRequestDetails" CssClass="input-xlarge focused" placeholder="Service Request Details"
                                    runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div class="control-group">
                            <label class="control-label" for="focusedInput">
                                Status</label>
                            <div class="controls">
                                <asp:DropDownList ID="ddlStatus" runat="server">
                                    <asp:ListItem>Pending</asp:ListItem>
                                    <asp:ListItem>Approved</asp:ListItem>
                                    <asp:ListItem>InProgress</asp:ListItem>
                                    <asp:ListItem>Completed</asp:ListItem>
                                    <asp:ListItem>Cancelled</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="control-group">
                            <label class="control-label" for="focusedInput">
                                Mechanic Reply</label>
                            <div class="controls">
                                <asp:TextBox ID="txtReply" CssClass="input-xlarge focused" TextMode="MultiLine" runat="server"></asp:TextBox>
                                <asp:Button Visible="false" ID="btnSubmitReply" runat="server" Text="Submit Reply" OnClick="btnSubmitReply_Click" />
                            </div>
                        </div>
                        <div class="control-group">
                            <label class="control-label" for="focusedInput">
                                Completion Time</label>
                            <div class="controls">
                                <asp:TextBox ID="txtCompletionTime" CssClass="input-xlarge focused" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div class="control-group">
                            <label class="control-label" for="focusedInput">
                                Feedback</label>
                            <div class="controls">
                                <asp:TextBox ID="txtFeedback" CssClass="input-xlarge focused" TextMode="MultiLine"
                                    runat="server"></asp:TextBox>
                            </div>
                            </div>
                            <div class="control-group">                            
                            <label class="control-label" for="focusedInput">
                                Rating</label>
                                <div class="controls">
                                <asp:DropDownList ID="ddlRating" runat="server">
                                    <asp:ListItem>1</asp:ListItem>
                                    <asp:ListItem>2</asp:ListItem>
                                    <asp:ListItem>3</asp:ListItem>
                                    <asp:ListItem>4</asp:ListItem>
                                    <asp:ListItem>5</asp:ListItem>
                                </asp:DropDownList>
                                </div>
                                <asp:Button Visible="false" ID="btnSubmitFeedbackRating" runat="server" Text="Submit Feedback" OnClick="btnSubmitFeedbackRating_Click" />
                            </div>                        
                    </fieldset>
                </div>
            </div>
        </div>
        <!--/span-->
    </div>
</asp:Content>
