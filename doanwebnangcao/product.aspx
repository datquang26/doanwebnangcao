<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="product.aspx.cs" Inherits="doanwebnangcao.product" %>
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
           background-color:transparent;
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
           
           border:none;
             
        }
      
        table 
        {
          border:none;
          background-color: transparent;
           
        }

        .input_delete{
            font-size: 13px; 
            font-weight: 700;
             background: linear-gradient( 90deg, red, blue);
             color: #ffffff;
             border-color: #ffffff;
             border-radius: 4px;
             box-shadow: 0px 0px 3px 1px gray;
             transition: all 0.3s ease;
            margin-left: 1140px; 
            position: relative;
            top: -46px;
        }
         .input_delete:hover {
             background: linear-gradient( 90deg, blue, red);
             box-shadow:  0px 0px 5px 2px gray;


         }



    
        
    </style>
      <div class="content-pane active ">
            <div class="box-pane-product-detail">
               <div class="grid">
                       <asp:GridView  ID="gvSP"   AutoGenerateColumns="false" runat="server" 
                   EnableViewState="false" DataKeyNames="MaSanPham"  RepeatDirection="Horizontal"  > 
             <Columns>

                 
                 <asp:TemplateField >
                    <ItemTemplate>
                        
                           <div class="box-product-detail">
                    <div class="box-product-detail-img">
                     <div class="box-product-detail-list-img" >
                         <asp:Image ID="Image1" runat="server" alt="" class="product-detail-list-img active" ImageUrl='<%#"~/img/"+Eval("Anh1") %>' />
                         <asp:Image ID="Image2" runat="server" alt="" class="product-detail-list-img" ImageUrl='<%#"~/img/"+Eval("Anh2") %>'/>
                         <asp:Image ID="Image3" runat="server" alt="" class="product-detail-list-img" ImageUrl='<%#"~/img/"+Eval("Anh3") %>'/>
                         <asp:Image ID="Image4" runat="server" alt="" class="product-detail-list-img" ImageUrl='<%#"~/img/"+Eval("Anh4") %>'/>
                         <asp:Image ID="Image5" runat="server" alt="" class="product-detail-list-img" ImageUrl='<%#"~/img/"+Eval("Anh5") %>'/>
                         <asp:Image ID="Image6" runat="server" alt="" class="product-detail-list-img" ImageUrl='<%#"~/img/"+Eval("Anh6") %>'/>
                     </div>
                     <div class="box-product-detail-img-main " style="overflow:hidden" >
                         <asp:Image ID="Image7" runat="server" alt="" class="product-detail-img-main active" ImageUrl='<%#"~/img/"+Eval("Anh1") %>' />
                         <asp:Image ID="Image8" runat="server" alt="" class="product-detail-img-main" ImageUrl='<%#"~/img/"+Eval("Anh2") %>' />
                         <asp:Image ID="Image9" runat="server" alt="" class="product-detail-img-main" ImageUrl='<%#"~/img/"+Eval("Anh3") %>' />
                         <asp:Image ID="Image10" runat="server" alt="" class="product-detail-img-main" ImageUrl='<%#"~/img/"+Eval("Anh4") %>' />
                         <asp:Image ID="Image11" runat="server" alt="" class="product-detail-img-main" ImageUrl='<%#"~/img/"+Eval("Anh5") %>' />
                         <asp:Image ID="Image12" runat="server" alt="" class="product-detail-img-main" ImageUrl='<%#"~/img/"+Eval("Anh6") %>' />
                            <div class="box-choose-img-product">
                                <span class="choose-product-img active"></span>
                                <span class="choose-product-img"></span>
                                <span class="choose-product-img"></span>
                                <span class="choose-product-img"></span>
                                <span class="choose-product-img"></span>
                                <span class="choose-product-img"></span>
                            </div>
                     </div>
                    </div>
                    <div class="box-product-detail-content" >
                        <span class="title-product-detail"> <%#Eval("TenSanPham") %></span>
                        <span class="cost-product-detail"><%#Eval("GiaTien", "{0:N0}") %>₫</span>
                      

                        <div class="box-service-product-detail">
                            <div class="box-content-service-product">
                                <i class="fa-solid fa-envelope icon-service"></i>
                                 <div class="box-para-product-service">
                                    
                                        <span class="text-product-service-bold">
                                            <i class="fa-solid fa-check"></i> Sản phẩm chính hãng từ Nhật Bản.
                                        </span>
                                        <br>
                                        <span class="text-product-service-bold">
                                            <i class="fa-solid fa-check"></i> Trước khi bạn đặt mua:
                                        </span>
                                        <span class="text-product-service">vui lòng check lại giá hiện tại với admin, vì khả năng giá đã thay đổi so với lần cập nhật gần nhất, hoặc hết hàng, hết suất order. Do giới hạn số lượng, figure Nhật sẽ hiếm dần theo thời gian, dẫn tới giá tăng.</span>
                                 </div>
                            </div>

                            <div class="box-content-service-product">
                                <i class="fa-solid fa-truck-fast icon-service"></i>
                                 <div class="box-para-product-service">
                                    
                                        <span class="text-product-service-bold">
                                            <i class="fa-solid fa-check"></i> Với sản phẩm CÓ SẴN, bạn sẽ được giao ngay.
                                        </span>
                                        <br>
                                        <span class="text-product-service-bold">
                                            <i class="fa-solid fa-check"></i> Với sản phẩm ĐẶT TRƯỚC, bạn cần cọc 50% giá trị sản phẩm. 
                                        </span>
                                        <span class="text-product-service"> Hàng về VN khoảng 2-3 tuần sau khi phát hành. Lịch phát hành dự kiến như thông tin chi tiết bên dưới.</span>
                                 </div>
                            </div>
                            
                            <div class="box-content-service-product">
                                <i class="fa-solid fa-phone-volume  icon-service"></i>
                                 <div class="box-para-product-service">
                                    
                                        <span class="text-product-service-bold">
                                            <i class="fa-solid fa-check"></i> Giao hàng tận nơi
                                        </span>
                                        <br>
                                        <span class="text-product-service-bold">
                                            <i class="fa-solid fa-check"></i> Miễn phí ship với các đơn hàng >1000K
                                        </span>
                                        <br>
                                        <span class="text-product-service-bold">
                                            <i class="fa-solid fa-check"></i> Vui lòng kiểm tra sản phẩm khi nhận bưu kiện
                                        </span>
                                       
                                 </div>
                            </div>

                        </div>

                        <div class="box-information-product-detail">
                            <span class="text-information-product-detail">THÔNG TIN SẢN PHẨM</span>
                            <span class="cost-update-product-detail">Giá cập nhật tháng   <%# Convert.ToDateTime(Eval("PhatHanh")).ToString("dd/MM/yyyy") %>: <%#Eval("GiaTien", "{0:N0}") %>đ</span>
                            <span class="text-char-product-detail">Nhân vật: <%#Eval("NhanVat") %></span>
                            <span class="text-char-product-detail">Series:  <%#Eval("Series") %></span>

                            <span class="text-char-product-detail">Hãng sản xuất:  <%#Eval("HangSanXuat") %></span>
                            <span class="text-char-product-detail">Kích thước: <%#Eval("KichThuoc") %>cm </span>
                            <span class="text-char-product-detail">Phát hành:  <%# Convert.ToDateTime(Eval("PhatHanh")).ToString("dd/MM/yyyy") %></span>



                        </div>
                        

                    </div>
                </div>

                    
                   
                      
                    </ItemTemplate>
                   
                </asp:TemplateField> 
                 
         
             </Columns>
                    
        </asp:GridView>
           <div class="box-add-cart-product-detail">
                            <div class="box-input-number-product">
                                <span class="text-input-number-product">So luong :</span>
                               
                             <asp:TextBox ID="TextBox2" runat="server" class="input-number-product" ></asp:TextBox>
                        <asp:Label ID="Label2" runat="server" Text="" style="font-size: 10px; color: red; padding-top: 2px; padding-left: 3px;"></asp:Label>

                               
                            </div>

                            <asp:Button ID="Button2" runat="server" Text="THEM VAO GIO" class="btn-add-cart-product-detail" OnClick="Button2_Click" />
                           
                        </div>
           </div>

    </div>
          </div>
</asp:Content>
