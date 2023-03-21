<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeBehind="GridviewBannerHome.aspx.cs" Inherits="doanwebnangcao.GridviewBannerHome" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
           <div class="content-pane active ">
                    <div class="box-manage">
                        <div class="grid">
                            <div class="box-manage-banner-all">
                                <span class="title-banner-all">Banner Home</span>
                                <div class="box-gridview-banner-all">
                                    <asp:GridView  ID="gvBH"   AutoGenerateColumns="false" runat="server" Width="100%" CellPadding="4" 
                   EnableViewState="false" DataKeyNames="MaBannerHome" ForeColor="#000000" BackColor="#f5f5f5" BorderColor="gray" GridLines="Both" OnRowEditing="gvBH_RowEditing" > 
             <Columns>
                    <asp:TemplateField HeaderText="MaBannerHome" HeaderStyle-HorizontalAlign="Center">
                    <ItemTemplate>
                   
                          <%#Eval("MaBannerHome") %>
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center"   />
                </asp:TemplateField> 

                 


                 <asp:TemplateField HeaderText="Anh1" HeaderStyle-HorizontalAlign="Center">
                    <ItemTemplate>
                   
                        <asp:Image ID="Image1" runat="server" ImageUrl='<%#"~/img/"+Eval("Anh1") %>' style="width: 100px" />
                         
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center"   />
                </asp:TemplateField> 

              
                 <asp:CommandField ControlStyle-CssClass="input_edit" ShowEditButton="true" ButtonType="Button" HeaderText="Thao tác" HeaderStyle-HorizontalAlign="Left"  />
                 
             </Columns>
                    
        </asp:GridView>
                                    </div>
                            </div>

                        </div>
                    </div>
               </div>
</asp:Content>
