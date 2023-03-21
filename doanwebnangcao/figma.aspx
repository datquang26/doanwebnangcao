<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="figma.aspx.cs" Inherits="doanwebnangcao.figma" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
         <style>
       
         
         th 
        {
            width: 0px; 
            height: 0px; 
            border: none;
            margin: 0px; 
            padding: 0px;
        }
        tbody
        {
            display: flex; 
            width: 100%; 
           background-color:#ffffff;
           flex-wrap: wrap;
            
         border: none;
        

        }
        tr {
            display: flex;
            flex-direction:column;
          border:none;
        }
        td 
        {
            display:flex;
           width: 100%;
           border:none;
             
        }
      
        table 
        {
          border:none;
           
        }

    </style>
      <div class="figma content-pane active ">
            <div class="content-pane-figma">

                <asp:GridView  ID="gvBA"   AutoGenerateColumns="false" runat="server" 
                   EnableViewState="false" DataKeyNames="MaBanner"  RepeatDirection="Horizontal"  > 
             <Columns>

                 
                 <asp:TemplateField >
                    <ItemTemplate>
                          <div class="img-banner-figma" style="width: 1517px; height: 362px;background-image: url('<%#"../img/"+Eval("AnhBanner") %>')">
                    <div class="box-title-banner-parade">
                        <span class="title-parade"><%#Eval("TenBanner")%></span>
                        <span class="text-banner-parade"><%#Eval("MoTaBanner") %></span>
                    </div>
                          </div>
                   
                      
                    </ItemTemplate>
                   
                </asp:TemplateField> 
                 
         
             </Columns>
                    
        </asp:GridView>

               

               <div class="content-product-parade">
               <div class="grid">


                    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                   <asp:UpdatePanel ID="UpdatePanel1" runat="server">

                       <ContentTemplate>


                     <div class="box-title-product-parade">
                    <span class="title-product-parade">Figma</span>
                      <div class="box-input figma" style="width: 567px; margin: 0px; position: relative; top: -513px; left: 22px; z-index: 2000; ">
                        
                          <asp:TextBox ID="TextBox1" class="input-text"  runat="server"></asp:TextBox>

                        <div class="search">
                            <asp:Button ID="Button1" runat="server" Text="" style="width: 100%; height:100%; border: none; background-color: transparent; z-index: 1;" OnClick="Button1_Click"/>
                            <i class="fa-solid fa-magnifying-glass icon-search" style="position: relative; left: -17px;"></i>
                        </div>
                     </div>
                    <asp:DropDownList ID="DropDownList1" class="select-parade"  runat="server" AutoPostBack="true" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">

                    </asp:DropDownList>
                    
                </div>
                
                <div class="box-item-product-parade">
                        <asp:GridView  ID="gvSP"   AutoGenerateColumns="false" runat="server" 
                   EnableViewState="false" DataKeyNames="MaSanPham"  RepeatDirection="Horizontal"  > 
             <Columns>

                 
                 <asp:TemplateField >
                    <ItemTemplate>
                        <div style=" width: 298px ;  height: 537px; padding: 0px 10px ; margin-bottom: 20px;  ">
                        <a href="/product.aspx?productID=<%#Eval("MaSanPham")%>" class="product-item-adv-link-parade">
                            <div class="box-img-change-parade">
                                 <asp:Image ID="Image3"  runat="server" ImageUrl='<%#"~/img/"+Eval("Anh1") %>'  class="img-product-default-parade" />        
                                     <asp:Image ID="Image4" runat="server"  ImageUrl='<%#"~/img/"+Eval("Anh2") %>' class="img-product-change-parade" />
                               
                            </div>
                            <div class="product-item-content-adv-parade">
                             <div class="product-item-content-title-parade"><%#Eval("TenSanPham") %></div>
                             <div class="product-item-content-cost-parade"><%#Eval("GiaTien " , "{0:N0}" ) %>₫</div>
                             <button  class="product-item-content-buy-parade">
                                 <i class="fa-solid fa-bag-shopping icon-buy"></i>
                             </button>
                            </div>

                         </a>
                   </div>
                      
                    </ItemTemplate>
                   
                </asp:TemplateField> 
                 
         
             </Columns>
                    
        </asp:GridView>
                </div>
</ContentTemplate>
                   </asp:UpdatePanel>
               </div>
               </div>

              </div>
     
            
           </div>
</asp:Content>
