<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeBehind="~/GridviewGioiThieu.aspx.cs" Inherits="doanwebnangcao.GridviewGioiThieu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="content-pane active ">
                    <div class="box-manage">
                        <div class="grid">
                            <div class="box-manage-banner-all">
                                <span class="title-banner-all">Gioi Thieu</span>
                                <div class="box-gridview-banner-all long">
                                    <asp:GridView  ID="gvGT"   AutoGenerateColumns="false" runat="server" Width="100%" CellPadding="4" 
                   EnableViewState="false" DataKeyNames="MaGioiThieu" ForeColor="#000000" BackColor="#f5f5f5" BorderColor="gray" GridLines="Both" OnRowEditing="gvGT_RowEditing"> 
             <Columns>
                    <asp:TemplateField HeaderText="MaGioiThieu" HeaderStyle-HorizontalAlign="Center">
                    <ItemTemplate>
                   
                          <%#Eval("MaGioiThieu") %>
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center"   />
                </asp:TemplateField> 

                  <asp:TemplateField HeaderText="IntroBannerImg" HeaderStyle-HorizontalAlign="Center">
                    <ItemTemplate>
                   
                          <asp:Image ID="Image1" runat="server" ImageUrl='<%#"~/img/"+Eval("IntroBannerImg") %>' style="width: 100px" />
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center"   />
                </asp:TemplateField> 


                 <asp:TemplateField HeaderText="IntroVideo" HeaderStyle-HorizontalAlign="Center">
                    <ItemTemplate>
                   
                       <%#Eval("IntroVideo") %>
                         
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center"   />
                </asp:TemplateField> 

               <asp:TemplateField HeaderText="TextIntroVideo" HeaderStyle-HorizontalAlign="Center">
                    <ItemTemplate>
                   
                          <%#Eval("TextIntroVideo") %>
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center"   />
                </asp:TemplateField> 

                  <asp:TemplateField HeaderText="AnhGT1" HeaderStyle-HorizontalAlign="Center">
                    <ItemTemplate>
                   
                          <asp:Image ID="Image2" runat="server" ImageUrl='<%#"~/img/"+Eval("AnhGT1") %>' style="width: 100px" />
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center"   />
                </asp:TemplateField> 

                  <asp:TemplateField HeaderText="IntroFigureImg" HeaderStyle-HorizontalAlign="Center">
                    <ItemTemplate>
                   
                          <asp:Image ID="Image3" runat="server" ImageUrl='<%#"~/img/"+Eval("JapanFigureImg") %>' style="width: 100px" />
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center"   />
                </asp:TemplateField> 

                  <asp:TemplateField HeaderText="IntroFigureImg2" HeaderStyle-HorizontalAlign="Center">
                    <ItemTemplate>
                   
                          <asp:Image ID="Image4" runat="server" ImageUrl='<%#"~/img/"+Eval("JapanFigureImg2") %>' style="width: 100px" />
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center"   />
                </asp:TemplateField> 

                  <asp:TemplateField HeaderText="IntroFigureImg3" HeaderStyle-HorizontalAlign="Center">
                    <ItemTemplate>
                   
                          <asp:Image ID="Image5" runat="server" ImageUrl='<%#"~/img/"+Eval("JapanFigureImg3") %>' style="width: 100px" />
                    </ItemTemplate>
                    <ItemStyle HorizontalAlign="Center"   />
                </asp:TemplateField> 

                       <asp:TemplateField HeaderText="JapanFigureText" HeaderStyle-HorizontalAlign="Center">
                    <ItemTemplate>
                   
                          <%#Eval("JapanFigureText") %>
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

