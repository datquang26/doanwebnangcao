<%@ Page Title="" Language="C#" MasterPageFile="~/login-register-main.Master" AutoEventWireup="true" CodeBehind="loginAD.aspx.cs" Inherits="doanwebnangcao.loginAD" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

       <div class="content-pane active " >
                <div class="box-admin">
                    <div class="grid">
                        <div class="box-login-ad">
                            <div class="box-content-login-ad">
                                <span class="title-login-ad">Admin </span>
                                <div class="box-input-login-ad">
                                    <asp:Label ID="Label3" runat="server" Text="" style="font-size: 10px; color: red; padding-top: 2px; padding-left: 3px;"></asp:Label>
                                    <asp:TextBox ID="tbTaiKhoanAD" class="input-login-ad" runat="server"></asp:TextBox>
                                    <%--<input type="text" class="input-login-ad">--%>
                                       <asp:Label ID="Label1" runat="server" Text="" style="font-size: 10px; color: red; padding-top: 2px; padding-left: 3px;"></asp:Label>
                                   
                                    <asp:TextBox ID="tbMatKhauAD" runat="server" TextMode="Password" class="input-login-ad"></asp:TextBox>
                                    <%--<input type="text" class="input-login-ad">--%>
                                       <asp:Label ID="Label2" runat="server" Text="" style="font-size: 10px; color: red; padding-top: 2px; padding-left: 3px;"></asp:Label>

                                </div>
                                  
                              <div class="text-ad-login-capcha">This site is protected by Google Privacy Policy .</div>
                                
                                <asp:Button ID="Button1" runat="server" Text="Login AD" class="btn-login-ad" OnClick="Button1_Click" />
                               <%--<button class="btn-login-ad">Login AD</button>--%>

                                </div>
                                  
                              
                                
                               
                            </div>
                        </div>
                    </div>
                </div>
           </div>

</asp:Content>
