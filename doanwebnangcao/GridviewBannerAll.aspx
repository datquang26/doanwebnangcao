<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeBehind="GridviewBannerAll.aspx.cs" Inherits="doanwebnangcao.GridviewBannerAll" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

        <div class="content-pane active ">
                    <div class="box-manage">
                        <div class="grid">
                            <div class="box-manage-banner-all">
                                <span class="title-banner-all">Banner All</span>
                                <a href="InsertBannerAll.aspx" class="insert-product-link">Thêm</a>
                                <div class="box-gridview-banner-all long">
                                    <asp:GridView  ID="gvBA"   AutoGenerateColumns="false" runat="server" Width="100%" CellPadding="4" 
                   EnableViewState="false" DataKeyNames="MaBanner" ForeColor="#000000" BackColor="#f5f5f5" BorderColor="gray" GridLines="Both" OnRowDeleting="gvBA_RowDeleting" OnRowEditing="gvBA_RowEditing"> 
             <Columns>
                    <asp:TemplateField HeaderText="MaBanner" HeaderStyle-HorizontalAlign="Center">
                    <ItemTemplate>
                   
                          <%#Eval("MaBanner") %>
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center"   />
                </asp:TemplateField> 

                  <asp:TemplateField HeaderText="TenBanner" HeaderStyle-HorizontalAlign="Center">
                    <ItemTemplate>
                   
                          <%#Eval("TenBanner") %>
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center"   />
                </asp:TemplateField> 


                 <asp:TemplateField HeaderText="AnhBanner" HeaderStyle-HorizontalAlign="Center">
                    <ItemTemplate>
                   
                        <asp:Image ID="Image1" runat="server" ImageUrl='<%#"~/img/"+Eval("AnhBanner") %>' style="width: 100px" />
                         
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center"   />
                </asp:TemplateField> 

               <asp:TemplateField HeaderText="MoTaBanner" HeaderStyle-HorizontalAlign="Center">
                    <ItemTemplate>
                   
                          <%#Eval("MoTaBanner") %>
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center"   />
                </asp:TemplateField> 


                     <asp:TemplateField HeaderText="LoaiBanner" HeaderStyle-HorizontalAlign="Center">
                    <ItemTemplate>
                   
                          <%#Eval("LoaiBanner") %>
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
