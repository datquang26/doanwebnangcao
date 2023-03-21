<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="homepage.aspx.cs" Inherits="doanwebnangcao.homepage1" %>
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

    
         .box-img-change{
             min-height: 293px;
         } 
         .product-item-adv-link{
             height: 100%;
         }

          .product-item-adv-link:hover .product-item-content-adv {
            transform: translateY(-60px);
        }

           .product-item-adv-link:hover .box-img-change {
            animation: fadeIn 0.3s linear;
        }

           .img-product-default {
             width: 100%;
            animation: fadeIn 0.3s linear;

}




           
           .box-product-img-adv{
               position: relative;
           }

           .box-product-img-adv::before{
                content: " ";
    display: block;
    position: absolute;
    top: 0; right: 0; bottom: 0; left: 0;
    inset: 0 0 0 0;
    background-color:  rgba(255, 254, 254, 0.1);
    z-index: 2;
    transition: transform 0.5s ease;
           }

           .box-product-img-adv::before {
                 transform: scaleX(1);
    transform-origin: bottom ;

           }

            .box-product-img-adv:hover::before {
                 transform: scaleX(0);
    transform-origin: bottom  ;
            }


           .box-product-img-adv:hover .img-product-adv {
        transform: scale(1.2);
        animation: none;
    }





.box-banner-home-page {
   position: relative;
}

.box-banner-home-page::before{
       content: " ";
    display: block;
    position: absolute;
    top: 0; right: 0; bottom: 0; left: 0;
    inset: 0 0 0 0;
    background-color:  rgba(255, 254, 254, 0.1);
    z-index: 1;
    transition: transform 1s ease;
}

.box-banner-home-page::before{
      transform: scaleX(1);
      transform-origin: bottom right;
}

.box-banner-home-page:hover::before{
     transform: scaleX(0);
     transform-origin: bottom right;
}



.box-banner-home-page:hover .img-banner-homepage {
    animation: none;
}





       
    </style>
       <div class="content-pane active">
            
            <div class="content-home-page">

                <asp:GridView ID="gvSL"  AutoGenerateColumns="false" runat="server"  EnableViewState="false" DataKeyNames="MaSliderAnh" RepeatDirection="Horizontal">
                    <Columns >
                        <asp:TemplateField>
                            <ItemTemplate>


                             <div class="slider-auto" style=" width:1460px; height: 471px; ">
                    <div id="carouselExampleIndicators" class="carousel slide" data-ride="carousel">
                        <ol class="carousel-indicators">
                          <li data-target="#carouselExampleIndicators" data-slide-to="0" class="active"></li>
                          <li data-target="#carouselExampleIndicators" data-slide-to="1"></li>
                          <li data-target="#carouselExampleIndicators" data-slide-to="2"></li>
                          <li data-target="#carouselExampleIndicators" data-slide-to="3"></li>
                        </ol>
                           <div class="carousel-inner">
                          <div class="carousel-item active">
                              <asp:Image ID="Image1"  class="d-block w-100" style="height: 471px;" alt="..." runat="server" ImageUrl='<%#"~/img/"+Eval("Anh1") %>' />
                          </div>
                          <div class="carousel-item">
                              <asp:Image ID="Image2" runat="server"  class="d-block w-100" style="height: 471px; " alt="..." ImageUrl='<%#"~/img/"+Eval("Anh2") %>' />
                          </div>
                          <div class="carousel-item">
                              <asp:Image ID="Image3" runat="server"  class="d-block w-100" style="height: 471px;" alt="..." ImageUrl='<%#"~/img/"+Eval("Anh3") %>' />
                          </div>
                          <div class="carousel-item">
                              <asp:Image ID="Image4" runat="server"  class="d-block w-100" style="height: 471px;" alt="..." ImageUrl='<%#"~/img/"+Eval("Anh4") %>' />
                          </div>
                        </div>
                        <button class="carousel-control-prev" type="button" data-target="#carouselExampleIndicators" data-slide="prev">
                          <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                          <span class="sr-only">Previous</span>
                        </button>
                        <button class="carousel-control-next" type="button" data-target="#carouselExampleIndicators" data-slide="next">
                          <span class="carousel-control-next-icon" aria-hidden="true"></span>
                          <span class="sr-only">Next</span>
                        </button>
                      </div>
                </div>


                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
             

                <div class="collection">
                    <div class="grid">
                        <div class="box-collection">
                            <div class="collection-content">
                                <div class="img-collection1">
                                    <div class="text-collection">
                                        <span class="title-collection">Pop Up Parade</span>
                                        <span class="content-collection">Dòng scale figure kích thước sinh viên,
                                            giá tiểu học</span>
                                         <a href="../pop-up-parade.aspx" class="link-collection click1">Xem ngay 
                                             <i class="fa-solid fa-arrow-right icon-right"></i>
                                         </a>
                                     </div>
                                </div>
                               
                            
                            </div>
     
                            <div class="collection-content ">
                                <div class="img-collection2 ">
                                    <div class="text-collection">
                                        <span class="title-collection">Figma</span>
                                        <span class="content-collection">Dòng chibi figure được yêu thích nhất,
                                         nhiều gương mặt, thoả sức tạo dáng</span>
                                         <a href="../figma.aspx" class="link-collection click2">Xem ngay 
                                             <i class="fa-solid fa-arrow-right icon-right"></i>
                                         </a>
                                     </div>
                                </div>
                               
                            
                            </div>
                        </div>

                    </div>
                </div>

                <div class="product-adv">
                   <div class="grid">

                       <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                       <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                           <ContentTemplate>

                          


                    <div class="box-drop-product-home"  style="display: flex; width: 100%; justify-content:center;">

                        



                        <asp:DropDownList ID="DropDownList1" runat="server"  style=" outline: none;border: none; width: 240px;" class="title-product-adv" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="true"> </asp:DropDownList>

                                    
                

                    </div>

                       <div class="product-content-adv">

                         <asp:GridView ID="gvBH" AutoGenerateColumns="false" runat="server" 
                   EnableViewState="false" DataKeyNames="MaBannerHome"  RepeatDirection="Horizontal">
                             <Columns>
                                 <asp:TemplateField>
                                     <ItemTemplate>
                                          <div class="box-product-img-adv">
                                               <asp:Image ID="Image5" runat="server" class="img-product-adv" ImageUrl='<%#"~/img/"+Eval("Anh1") %>' />

                                      </div>
                                     </ItemTemplate>
                                 </asp:TemplateField>
                             </Columns>
                         </asp:GridView>
                      
                        <div class="box-product-adv">

                           <asp:GridView ID="gvSP" DataKeyNames="MaSanPham"  AutoGenerateColumns="false" runat="server" 
                   EnableViewState="false"  RepeatDirection="Horizontal">
                               <Columns>
                                   <asp:TemplateField>
                                       <ItemTemplate>
                                           <div style="    width: 192px;height: 351px; padding: 4px 7px;">
                                           <a  href="/product.aspx?productID=<%#Eval("MaSanPham")%>" class="product-item-adv-link">
                                                <div class="box-img-change">
                                       
                                             <asp:Image ID="Image6" runat="server" class="img-product-default" ImageUrl='<%#"~/img/"+Eval("Anh1") %>' />
                                        
                                                 <asp:Image ID="Image7" runat="server" class="img-product-change" ImageUrl='<%#"~/img/"+Eval("Anh2") %>' />
                                             </div>
                                             <div class="product-item-content-adv">
                                              <div class="product-item-content-title"><%#Eval("TenSanPham") %></div>
                                             <div class="product-item-content-cost"><%#Eval("GiaTien", "{0:N0}") %>₫</div>
                                             <button  class="product-item-content-buy">
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
                     </div>


                                   </ContentTemplate>
                       </asp:UpdatePanel>
                   </div>

                </div>
                <div class="product-adv">
                   
                    <div class="grid">
                     <div class="title-product-adv">New </div>

                     <div class="product-content-adv">

                          <div class="box-product-adv">
                              

                     <asp:GridView ID="gvSP2" DataKeyNames="MaSanPham" AutoGenerateColumns="false" runat="server" EnableViewState="false" RepeatDirection="Horizontal">
                         <Columns>
                             <asp:TemplateField>
                                 <ItemTemplate>
                                       <div style="width: 192px ; height: 351px; padding: 4px 7px; ">
                                <a  href="/product.aspx?productID=<%#Eval("MaSanPham")%>" class="product-item-adv-link">
                                   <div class="box-img-change">
                                       
                                       <asp:Image ID="Image11" runat="server" class="img-product-default" ImageUrl='<%#"~/img/"+Eval("Anh1") %>' />
                                        
                                       <asp:Image ID="Image9" runat="server" class="img-product-change" ImageUrl='<%#"~/img/"+Eval("Anh2") %>' />
                                   </div>
                                   <div class="product-item-content-adv">
                                    <div class="product-item-content-title"><%#Eval("TenSanPham") %></div>
                                    <div class="product-item-content-cost"><%#Eval("GiaTien", "{0:N0}")   %>₫</div>
                                    <button  class="product-item-content-buy">
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
                         
                        <asp:GridView ID="gvBH2" DataKeyNames="MaBannerHome" runat="server" AutoGenerateColumns="false" EnableViewState="false" RepeatDirection="Horizontal">
                            <Columns>
                                <asp:TemplateField>
                                    <ItemTemplate>

                                         <div class="box-product-img-adv" style="height: 693px;">
                                            <asp:Image ID="Image10" runat="server" Class="img-product-adv" ImageUrl='<%#"~/img/"+Eval("Anh2") %>' style="height:100%" />
                                         </div>

                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                        </asp:GridView>
                       
                       
                     </div>
                    </div>
 
                 </div>
             
               <div style="padding: 40px 0px;">
             <asp:GridView  ID="gvBA"   AutoGenerateColumns="false" runat="server" 
                   EnableViewState="false" DataKeyNames="MaBanner"  RepeatDirection="Horizontal"  > 
             <Columns>

                 
                 <asp:TemplateField >
                    <ItemTemplate>
                        
                       

                    <div class="box-banner-home-page" style="margin: 0px; width:100%" >
                        <asp:Image ID="Image8" runat="server" class="img-banner-homepage" ImageUrl='<%#"~/img/"+Eval("AnhBanner") %>' style="width: 100%;" />
                   
                </div>
                   
                      
                    </ItemTemplate>
                   
                </asp:TemplateField> 
                 
         
             </Columns>
                    
        </asp:GridView>
                    </div>



            </div>

           


           </div>
    <div class="display-adv ">

        <div class="box-img-sale" style=" position: fixed; top: 100px ; left: 350px">
            <a href="https://www.google.com.vn/search?q=eimi+fukada&sxsrf=AJOqlzWQzbt80pLhiGW1J-UFneDzoljsKw:1678821973481&source=lnms&tbm=isch&sa=X&ved=2ahUKEwio__qak9z9AhVQ-mEKHep6BFMQ_AUoAXoECAEQAw&biw=1366&bih=625&dpr=1">
        <img src="../img/quangcao.jpg" alt="Alternate Text" class="img-sale-adv"  />
            </a>
        </div>

        </div>

    <style>

        html {
            position: relative;
        
            
        }
        html .display-adv{
            position: absolute; 
            background-color: rgba(0, 0, 0, 0.1); 
            display: flex; 
          
            z-index: 100000;
            top: 0; 
            left : 0; 
            right: 0; 
            bottom: 0;
            display: none;
             
          
        }

         html .display-adv.active{
           position: absolute; 
            background-color: rgba(0, 0, 0, 0.5); 
            display: flex; 
          
            z-index: 100000;
            top: 0; 
            left : 0; 
            right: 0; 
            bottom: 0;
        }

         @keyframes advmove {
         from {
         transform: rotateX(0deg);
       
              }

         to {
         transform:   rotateX(15deg)  ;
       
            }
         }

         @keyframes fefe {
             from {
                 transform: scale(0);
             }
             to {
                 transform: scale(1.1);
             }
         }


         .box-img-sale{
             animation: fefe 0.5s linear;
            transform-origin: bottom left;

         }
         

         .img-sale-adv{
            
             
             animation: advmove 0.4s infinite linear;
             margin-left: 100px;
            
         }

    </style>

    <script>
        const $ = document.querySelector.bind(document);
        const $$ = document.querySelectorAll.bind(document);

        const tabclick = $$(".display-adv");

        tabclick.forEach((tab, index) => {
            

            tab.onclick = function () {
                $(".display-adv.active").classList.remove("active");
              
            };
        });

        setTimeout(() => {
            $(".display-adv").classList.add("active");
        }, 5000);
  
    </script>

</asp:Content>
