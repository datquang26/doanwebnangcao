<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="cart.aspx.cs" Inherits="doanwebnangcao.cart" %>
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
           flex-direction: column;
         border: none;

            
       
        

        }
        tr {
            display: flex;
           width: 100%; 
           justify-content: space-between;
           align-items: center;
           border: 1px solid #ccc;
         
        }
        td 
        {
         padding-right: 30px;
         border: none;
        
             
        }
      
        table 
        {
          display:flex;
           width: 100%;
         border: none;

        }

     .input_delete{
            font-size: 13px; 
            font-weight: 700;
             background: linear-gradient( 90deg, blue, red);
             color: #ffffff;
             border-color: #ffffff;
             border-radius: 4px;
             box-shadow: 0px 0px 3px 1px gray;
             transition: all 0.3s ease;
             
          
        }
         .input_delete:hover {
             background:linear-gradient( 90deg, red, blue);
             box-shadow:  0px 0px 5px 2px gray;


         }

         .input_edit{
            font-size: 13px; 
            font-weight: 700;
             background: linear-gradient( 90deg, red, blue);
             color: #ffffff;
             border-color: #ffffff;
             border-radius: 4px;
             box-shadow: 0px 0px 3px 1px gray;
             transition: all 0.3s ease;
            
          
        }
         .input_edit:hover {
             background: linear-gradient( 90deg, blue, red);
             box-shadow:  0px 0px 5px 2px gray;


         }
     
         .btn-order{
             background-color: #ddd; 
             font-size: 22px; 
             font-weight: 700; 
             color: #ffffff;
             padding: 7px 30px;
             border: 2px solid gray;
             transition: all 0.3s ease; 
            
         }
         .btn-order:hover {
             border-color: #ffffff;
             box-shadow: 0px 0px 7px 2px gray;
             background-color: red;
         }
       
    </style>
           <div class="content-pane active ">
                <h1 style=" font-weight: 800; display:flex; justify-content: center;padding: 30px 0px 20px;   text-shadow: 5px 5px 5px gray; font-family: Comic Sans, Comic Sans MS, cursive;"> Cart</h1>
               <div class="grid">
               <div style="margin: 15px 20px; box-shadow: 0px 0px 10px 3px gray; border-radius: 15px; border: 3px solid #ccc; overflow: hidden;"  >
                  <asp:GridView  ID="gvGH"   AutoGenerateColumns="false" runat="server" 
                   EnableViewState="false" DataKeyNames="MaGioHang"  RepeatDirection="Horizontal" OnRowDeleting="gvGH_RowDeleting"   > 
             <Columns>

                 
                 <asp:TemplateField >
                    <ItemTemplate>
                        <div  style="width: 1000px; display: flex;  ">
                        <a  href="/product.aspx?productID=<%#Eval("MaSanPham")%> " class="product-item-adv-link" style="width: 180px ;height: 190px;" >
                                   <div class="box-img-change"   style="width: 100%; height: 100%; min-height: 100%; ">
                                       
                                       <asp:Image ID="Image6" runat="server" class="img-product-default" ImageUrl='<%#"~/img/"+Eval("Anh1") %>' style="height: 100%;" />
                                        
                                       <asp:Image ID="Image7" runat="server" class="img-product-change" ImageUrl='<%#"~/img/"+Eval("Anh2") %>'   style="height: 100%;"/>
                                   </div>
                            </a>
                                   <div class="product-item-content-cart" style="padding-left: 5px; display:flex; flex-direction: column; justify-content: center;">
    
                                    <div class="product-item-content-title" style="font-size: 17px; font-weight: 700; text-shadow: 0px 0px 3px gray; font-family: Comic Sans, Comic Sans MS, cursive;"><%#Eval("TenSanPham") %></div>
                                    <div class="product-item-content-cost" style="font-size: 15px; font-weight: 700;  color: red; font-family: Comic Sans, Comic Sans MS, cursive;"><%#Eval("ThanhTien", "{0:N0}") %>₫</div>
                                    <div class=""  style="font-size: 15px; font-weight: 700;  color: gray; font-family: Comic Sans, Comic Sans MS, cursive;">Số lượng: <%#Eval("SoLuong") %></div>

                                      
                                   </div>

                                
                            </div>

                    
                   
                      
                    </ItemTemplate>
                   
                </asp:TemplateField> 

              
                         
                        <asp:CommandField ControlStyle-CssClass="input_delete" ShowDeleteButton="True" ButtonType="Button"  />
             </Columns>
                    
        </asp:GridView>
                   </div>

               <div style=" display: flex; justify-content: flex-end; font-family: Comic Sans, Comic Sans MS, cursive; padding: 15px 40px; font-size: 25px; font-weight: 700;">
                   <span style="padding: 0px 10px;"> Tổng tiền:</span> <span style="color: red; text-shadow: 0px 0px 3px gray; "> <asp:Label ID="Label1" runat="server" Text="" style="margin-right: 3px; letter-spacing: 2px;"></asp:Label>đ</span>
               </div>

               <div  style=" display: flex; justify-content: center; align-items: center;padding: 10px 0px;">
                   <asp:Button ID="Button1" runat="server" Text="Đặt Hàng" class="btn-order" />
               </div>
                 
                   </div>
           </div>

</asp:Content>
