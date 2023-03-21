<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="lien-he.aspx.cs" Inherits="doanwebnangcao.lien_he" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <div class="content-pane active ">
            <h2 style="font-size: 13px; margin-left: 115px; text-align: none; ">
                <a href="homepage.aspx" style="color: black;">Trang chủ</a> /
                <a href="" style="color: #777777;">Liên hệ</a>
            </h2>
            <div class="main1">

                <div class="content-LH">
                    <h3 class="text-LH">Thông tin liên hệ</h3>
                    <div class="image-LH">
                        <ul class="list-group">
                            <li class="list-group-item">
                                <i class="ti-location-pin"></i>
                                Địa chỉ 
                                <p class="m-0" style="color: #606060; font-size: 12px; padding-left: 20px;">Quận 10, Hồ Chí Minh</p>
                                
                            </li>
                                
                            <li class="list-group-item">
                                <i class="ti-email"></i>
                                Email 
                                <p class="m-0" style="color: #606060; font-size: 12px; padding-left: 20px;">support@japanfigure.vn</p>
                                
                            </li>
                            <li class="list-group-item">
                                <i class="fa-solid fa-phone"></i>
                                Điện thoại
                                <p class="m-0" style="color: #606060; font-size: 12px; padding-left: 20px;">0979797393</p>
                            </li>
                            
                            <li class="list-group-item">
                                <i class="ti-email"></i>
                                Thời gian làm việc
                                <p class="m-0" style="color: #606060; font-size: 12px; padding-left: 1px;">Japan Figure chưa có không gian trưng bày
                                    Bạn vui lòng hẹn trước khi đến xem sản phẩm, giao dịch, đặt cọc.</p>
                            </li>
                          </ul>
                    </div>
                </div>

                <div action="" method="POST" class="form" id="form-1">
                  <h3 class="heading">Gửi thắc mắc cho chúng tôi</h3>
                  <p class="desc">Nếu bạn có thắc mắc gì, có thể gửi yêu cầu cho chúng tôi, và chúng tôi sẽ liên lạc lại với bạn sớm nhất có thể . ❤️</p>
              
                        <asp:Label ID="Label1" runat="server" Text="" style="font-size: 10px; color: red; padding-top: 2px; padding-left: 3px;"></asp:Label>                    
                 
              
                  <div class="form-group">
                      <asp:TextBox ID="tbFullName"  runat="server" placeholder="Tên của bạn" class="form-control"></asp:TextBox>
                   <%-- <input id="fullname" name="fullname" type="text" placeholder="Tên của bạn" class="form-control">--%>
                    <span class="form-message"></span>
                  </div>
              
                  <div class="form-group">
                    <asp:TextBox ID="tbEmail"  runat="server" placeholder="Email của bạn" class="form-control"></asp:TextBox>
                   <%-- <input id="email" name="email" type="text" placeholder="Email của bạn" class="form-control">--%>
                    <span class="form-message"></span>
                  </div>
              
                  <div class="form-group">
                   <asp:TextBox ID="tbSoDienThoai"  runat="server" placeholder="Số điện thoại của bạn" class="form-control"></asp:TextBox>
                    <%--<input id="phone" name="phone" type="text" placeholder="Số điện thoại của bạn" class="form-control">--%>
                    <span class="form-message"></span>
                  </div>
              
                  <div class="form-group">
                    <asp:TextBox ID="tbNoiDung"  runat="server" placeholder="Nội dung" class="form-control"></asp:TextBox>
                    <%--<input id="content" name="content" placeholder="Nội dung" type="text" class="form-control">--%>
                    <span class="form-message"></span>
                  </div>

                        <div class="form-this">This site is protected by reCAPTCHA and the Google
                             <a href="google.com">Privacy Policy</a> and 
                             <a href="google.com">Terms of Service </a> apply.</div>
                    <asp:Button ID="Button1" runat="server" Text="Gửi cho chúng tôi" class="form-submit" OnClick="Button1_Click"   />
                  <%--<button class="form-submit">Gửi cho chúng tôi</button>--%>
                </div>

                
              
              </div>
                          
           </div>
</asp:Content>
