<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeBehind="GridviewNguoiDung.aspx.cs" Inherits="doanwebnangcao.GridviewNguoiDung" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="content-pane active ">
                    <div class="box-manage">
                        <div class="grid">
                            <div class="box-manage-banner-all">
                                <span class="title-banner-all">Nguoi Dung</span>
                                <div class="box-gridview-banner-all">
                                    <asp:GridView  ID="gvND"   AutoGenerateColumns="false" runat="server" Width="100%" CellPadding="4" 
                   EnableViewState="false" DataKeyNames="ID" ForeColor="#000000" BackColor="#f5f5f5" BorderColor="gray" GridLines="Both" OnRowDeleting="gvND_RowDeleting" OnRowEditing="gvND_RowEditing"> 
             <Columns>
                    <asp:TemplateField HeaderText="ID" HeaderStyle-HorizontalAlign="Center">
                    <ItemTemplate>
                   
                          <%#Eval("ID") %>
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center"   />
                </asp:TemplateField> 

                  <asp:TemplateField HeaderText="Email" HeaderStyle-HorizontalAlign="Center">
                    <ItemTemplate>
                   
                          <%#Eval("Email") %>
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center"   />
                </asp:TemplateField> 


                 <asp:TemplateField HeaderText="MatKhau" HeaderStyle-HorizontalAlign="Center">
                    <ItemTemplate>
                   
                          <%#Eval("MatKhau") %>
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center"   />
                </asp:TemplateField> 

               <asp:TemplateField HeaderText="FullName" HeaderStyle-HorizontalAlign="Center">
                    <ItemTemplate>
                   
                          <%#Eval("FullName") %>
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center"   />
                </asp:TemplateField> 
                 <asp:CommandField ControlStyle-CssClass="input_edit" ShowEditButton="true" ButtonType="Button" HeaderText="Thao tác" HeaderStyle-HorizontalAlign="Left"  />


                 <asp:CommandField ControlStyle-CssClass="input_delete" ShowDeleteButton="true" ButtonType="Button" HeaderText="Thao tác" HeaderStyle-HorizontalAlign="Left"  />

                 
             </Columns>
                    
        </asp:GridView>
                                    </div>
                            </div>

                        </div>
                    </div>
               </div>
</asp:Content>
