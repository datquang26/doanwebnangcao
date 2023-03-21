<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeBehind="GridviewSanPham.aspx.cs" Inherits="doanwebnangcao.GridviewSanPham" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="content-pane active ">
                    <div class="box-manage">
                        <div class="grid">
                            <div class="box-manage-banner-all">
                                <span class="title-banner-all">San Pham</span>
                                <a href="InsertSanPham.aspx" class="insert-product-link">Thêm</a>
                                <div class="box-gridview-banner-all long">


                                    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                        <ContentTemplate>


                                             <asp:GridView  ID="gvSP"   AutoGenerateColumns="false" runat="server" Width="100%" CellPadding="4" 
                   EnableViewState="false" DataKeyNames="MaSanPham" ForeColor="#000000" BackColor="#f5f5f5" BorderColor="gray" GridLines="Both" OnRowDeleting="gvSP_RowDeleting" OnRowEditing="gvSP_RowEditing" OnPageIndexChanging="gvSP_PageIndexChanging" AllowPaging="true"> 
             <Columns>

                    <asp:TemplateField HeaderText="MaSanPham" HeaderStyle-HorizontalAlign="Center">
                    <ItemTemplate>
                   
                          <%#Eval("MaSanPham") %>
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center"   />
                </asp:TemplateField> 
                  <asp:TemplateField HeaderText="TenSanPham" HeaderStyle-HorizontalAlign="Center">
                    <ItemTemplate>
                   
                       <%#Eval("TenSanPham") %>
                         
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center"   />
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="GiaTien" HeaderStyle-HorizontalAlign="Center">
                    <ItemTemplate>
                   
                       <%#Eval("GiaTien") %>
                         
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center"   />
                </asp:TemplateField> 
               <asp:TemplateField HeaderText="NhanVat" HeaderStyle-HorizontalAlign="Center">
                    <ItemTemplate>
                   
                          <%#Eval("NhanVat") %>
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center"   />
                </asp:TemplateField> 
                  <asp:TemplateField HeaderText="HangSanXuat" HeaderStyle-HorizontalAlign="Center">
                    <ItemTemplate>
                   
                          <%#Eval("HangSanXuat") %>
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center"   />
                </asp:TemplateField> 
                  <asp:TemplateField HeaderText="KichThuoc" HeaderStyle-HorizontalAlign="Center">
                    <ItemTemplate>
                   
                          <%#Eval("KichThuoc") %>
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center"   />
                </asp:TemplateField> 

                  <asp:TemplateField HeaderText="PhatHanh" HeaderStyle-HorizontalAlign="Center">
                    <ItemTemplate>
                   
                          <%#Eval("PhatHanh") %>
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center"   />
                </asp:TemplateField> 

                  <asp:TemplateField HeaderText="Anh1" HeaderStyle-HorizontalAlign="Center">
                    <ItemTemplate>
                   
                          <asp:Image ID="Image2" runat="server" ImageUrl='<%#"~/img/"+Eval("Anh1") %>' style="width: 100px" />
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center"   />
                </asp:TemplateField> 

                 <asp:TemplateField HeaderText="Anh2" HeaderStyle-HorizontalAlign="Center">
                    <ItemTemplate>
                   
                          <asp:Image ID="Image1" runat="server" ImageUrl='<%#"~/img/"+Eval("Anh2") %>' style="width: 100px" />
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center"   />
                </asp:TemplateField> 

                 <asp:TemplateField HeaderText="Anh3" HeaderStyle-HorizontalAlign="Center">
                    <ItemTemplate>
                   
                          <asp:Image ID="Image3" runat="server" ImageUrl='<%#"~/img/"+Eval("Anh3") %>' style="width: 100px" />
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center"   />
                </asp:TemplateField> 

                 <asp:TemplateField HeaderText="Anh4" HeaderStyle-HorizontalAlign="Center">
                    <ItemTemplate>
                   
                          <asp:Image ID="Image4" runat="server" ImageUrl='<%#"~/img/"+Eval("Anh4") %>' style="width: 100px" />
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center"   />
                </asp:TemplateField>
                 
                 <asp:TemplateField HeaderText="Anh5" HeaderStyle-HorizontalAlign="Center">
                    <ItemTemplate>
                   
                          <asp:Image ID="Image5" runat="server" ImageUrl='<%#"~/img/"+Eval("Anh5") %>' style="width: 100px" />
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center"   />
                </asp:TemplateField> 

                 <asp:TemplateField HeaderText="Anh6" HeaderStyle-HorizontalAlign="Center">
                    <ItemTemplate>
                   
                          <asp:Image ID="Image6" runat="server" ImageUrl='<%#"~/img/"+Eval("Anh6") %>' style="width: 100px" />
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center"   />
                </asp:TemplateField> 
                  <asp:TemplateField HeaderText="LoaiSP" HeaderStyle-HorizontalAlign="Center">
                    <ItemTemplate>
                   
                          <%#Eval("LoaiSP") %>
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center"   />
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="Series" HeaderStyle-HorizontalAlign="Center">
                    <ItemTemplate>
                   
                          <%#Eval("Series") %>
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center"   />
                </asp:TemplateField> 

                 <asp:TemplateField HeaderText="CategoryId" HeaderStyle-HorizontalAlign="Center">
                    <ItemTemplate>
                   
                          <%#Eval("CategoryId") %>
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center"   />
                </asp:TemplateField> 

                 <asp:TemplateField HeaderText="MaLoaiSP" HeaderStyle-HorizontalAlign="Center">
                    <ItemTemplate>
                   
                          <%#Eval("MaLoaiSP") %>
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center"   />
                </asp:TemplateField> 

                 <asp:CommandField ControlStyle-CssClass="input_edit" ShowEditButton="true" ButtonType="Button" HeaderText="Thao tác" HeaderStyle-HorizontalAlign="Left"  />
                
                                 
                    <asp:CommandField ControlStyle-CssClass="input_delete" ShowDeleteButton="True" ButtonType="Button" HeaderText="Thao tác" HeaderStyle-HorizontalAlign="Left"  />
                                            
                 
             </Columns>
                                         <PagerSettings Mode ="NumericFirstLast" PageButtonCount="10"/>
                    <PagerStyle CssClass="pagecss" />
                    
        </asp:GridView>


                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                                        

                                   


                                            
                                    </div>
                            </div>

                        </div>
                    </div>
               </div>
</asp:Content>
