<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SendEmail.aspx.cs" Inherits="testProject.SendEmail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

          <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                                     <asp:GridView ID="grdClientDetails" CssClass="table table-striped table-bordered table-hover" HeaderStyle-BackColor="#14a45f" ForeColor="White" Font-Size="11px" DataKeyNames="EmployeeId"  AutoGenerateColumns="false" runat="server" ShowHeaderWhenEmpty="true" EmptyDataRowStyle-BackColor="#ff1a1a">
                                        <Columns>
                                            <asp:TemplateField HeaderText="Select">
                                                <ItemTemplate>
                                                    <asp:CheckBox ID="chkEmployeeId" runat="server" />
                                                </ItemTemplate>
                                            </asp:TemplateField>

                                          
                                             <asp:TemplateField HeaderText="Model">
                                                <ItemTemplate>
                                                    <asp:LinkButton ID="EmployeeId" runat="server" CommandName="Select" CommandArgument='<%# Eval("EmployeeId")%>' Text='<%#Eval("EmployeeId") %>'></asp:LinkButton>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                             <asp:BoundField DataField="FirstName" HeaderText="FirstName" ItemStyle-ForeColor="#14a45f"/>
                                            <asp:BoundField DataField="Email" HeaderText="Email" HeaderStyle-Width="5px" ItemStyle-ForeColor="#14a45f" />
                                          
                                        </Columns>
                                        <EmptyDataTemplate>
                                            No records found
                                        </EmptyDataTemplate>
                                    </asp:GridView>
                               <asp:Button ID="btnSendEmail" runat="server" CssClass="btn btn-danger btn-sm" Text="Send Mail" OnClick="btnSendEmail_Click"/>
    </form>
</body>
</html>
