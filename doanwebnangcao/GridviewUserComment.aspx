<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeBehind="GridviewUserComment.aspx.cs" Inherits="doanwebnangcao.GridviewUserComment" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <div class="content-pane active ">
                    <div class="box-manage">
                        <div class="grid">
                            <div class="box-manage-banner-all">
                                <span class="title-banner-all">UserComment</span>
                                <div class="box-gridview-banner-all long">
                                    <asp:GridView  ID="gvUC"   AutoGenerateColumns="false" runat="server" Width="100%" CellPadding="4" 
                   EnableViewState="false" DataKeyNames="MaComment" ForeColor="#000000" BackColor="#f5f5f5" BorderColor="gray" GridLines="Both"       > 
             <Columns>
                    <asp:TemplateField HeaderText="MaComment" HeaderStyle-HorizontalAlign="Center">
                    <ItemTemplate>
                   
                          <%#Eval("MaComment") %>
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center"   />
                </asp:TemplateField> 

                   <asp:TemplateField HeaderText="ID" HeaderStyle-HorizontalAlign="Center">
                    <ItemTemplate>
                   
                          <%#Eval("ID") %>
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center"   />
                </asp:TemplateField>

                  <asp:TemplateField HeaderText="MaSanPham" HeaderStyle-HorizontalAlign="Center">
                    <ItemTemplate>
                   
                          <%#Eval("MaSanPham") %>
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center"   />
                </asp:TemplateField>


                 <asp:TemplateField HeaderText="TextComment" HeaderStyle-HorizontalAlign="Center">
                    <ItemTemplate>
                   
                       <%#Eval("TextComment") %>
                         
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
