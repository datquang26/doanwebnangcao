<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeBehind="GridviewLienHe.aspx.cs" Inherits="doanwebnangcao.GridviewLienHe" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
          <div class="content-pane active ">
                    <div class="box-manage">
                        <div class="grid">
                            <div class="box-manage-banner-all">
                                <span class="title-banner-all">Lien He</span>
                                <div class="box-gridview-banner-all long">
                                    <asp:GridView  ID="gvLH"   AutoGenerateColumns="false" runat="server" Width="100%" CellPadding="4" 
                   EnableViewState="false" DataKeyNames="MaLienHe" ForeColor="#000000" BackColor="#f5f5f5" BorderColor="gray" GridLines="Both" OnRowDeleting="gvLH_RowDeleting"       > 
             <Columns>
                    <asp:TemplateField HeaderText="MaLienHe" HeaderStyle-HorizontalAlign="Center">
                    <ItemTemplate>
                   
                          <%#Eval("MaLienHe") %>
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center"   />
                </asp:TemplateField> 


                 <asp:TemplateField HeaderText="FullName" HeaderStyle-HorizontalAlign="Center">
                    <ItemTemplate>
                   
                       <%#Eval("FullName") %>
                         
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center"   />
                </asp:TemplateField> 

               <asp:TemplateField HeaderText="Email" HeaderStyle-HorizontalAlign="Center">
                    <ItemTemplate>
                   
                          <%#Eval("Email") %>
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center"   />
                </asp:TemplateField> 

                  <asp:TemplateField HeaderText="SoDienThoai" HeaderStyle-HorizontalAlign="Center">
                    <ItemTemplate>
                   
                          <%#Eval("SoDienThoai") %>
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center"   />
                </asp:TemplateField> 

                
                       <asp:TemplateField HeaderText="NoiDung" HeaderStyle-HorizontalAlign="Center">
                    <ItemTemplate>
                   
                          <%#Eval("NoiDung") %>
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center"   />
                </asp:TemplateField> 

                
                   <asp:CommandField ControlStyle-CssClass="input_delete" ShowDeleteButton="True" ButtonType="Button" HeaderText="Thao tác" HeaderStyle-HorizontalAlign="Left"  />
             </Columns>
                    
        </asp:GridView>
                                    </div>
                            </div>

                        </div>
                    </div>
               </div>
</asp:Content>
