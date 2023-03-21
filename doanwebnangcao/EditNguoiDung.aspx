<%@ Page Title="" Language="C#" MasterPageFile="~/admin.Master" AutoEventWireup="true" CodeBehind="EditNguoiDung.aspx.cs" Inherits="doanwebnangcao.EditNguoiDung" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <style>
        .box-insert{
            display:flex;
            width: 100%; 
            justify-content: center ; 
            align-items: center;
        }
        .box-content-insert{
            display: flex; 
           width: 470px;
    padding: 15px 100px 15px 10px;
            flex-direction: column;
            justify-content: center;
            border-radius: 5px;

            box-shadow: 0px 0px 10px 3px gray;

        }
        .box-content-input{
            width: 100%; 
            display: flex;
            justify-content: space-between;
            align-items: center;
            padding: 7px 0px;
        }
        .text-insert-input{
         font-family: Comic Sans, Comic Sans MS, cursive;
         font-size: 14px; 
         font-weight: 700;
       
         min-width: 122px; 
         text-align: right;

        }
       .box-insert-input{
           display: flex; 
           width: 230px; 
           height: 35px; 
           display: flex; 
           align-items:center; 
           border: 2px solid gray; 
           border-radius: 5px;
           transition: all 0.3s ease;
       }
       .box-insert-input:hover {
           box-shadow: 0px 0px 5px 2px gray;
       }
       .input-input-text{
           display: flex; 
           align-items: center;
           width: 100%;
           padding: 0px 5px;
           border: none;
           outline: none;
           color:  #444141;
             font-family: Comic Sans, Comic Sans MS, cursive;
       }

       .btn-insert-product{
           width: 150px;
           height: 40px;
           border: 2px solid gray ;
           background-color: #ffffff;
           color: gray;
           font-size: 18px;
           font-weight: 700;
           
           margin: 20px 0px 15px 150px;
           transition: all 0.3s ease;
       }
       .btn-insert-product:hover {
           border-color: #ffffff;
           background-color: red; 
           color: #ffffff;
           box-shadow: 0px 0px 5px 2px gray;
       }

    </style>
        <div class="content-pane active ">
                    <div class="box-manage">
                        <div class="grid">
                            <div class="box-manage-banner-all">
                                <span class="title-banner-all">Sửa Nguoi Dung</span>
                                <div class="box-insert">
                                    <div class="box-content-insert">
                                       <asp:Label ID="Label1" runat="server" Text="" style="font-size: 10px; color: red; padding-top: 2px; padding-right: 22px; text-align: right;"></asp:Label>

                                         <div class="box-content-input">
                                            <span class="text-insert-input">ID:</span>
                                            <div class="box-insert-input">
                                                <asp:TextBox class="input-input-text" ID="tbID" runat="server"></asp:TextBox>
                                            </div>
                                        </div>

                                                                       
                                          

                                         <div class="box-content-input">
                                            <span class="text-insert-input">Email:</span>
                                            <div class="box-insert-input">
                                                <asp:TextBox class="input-input-text" ID="tbEmail" runat="server"></asp:TextBox>
                                            </div>
                                        </div>

                                          <div class="box-content-input">
                                            <span class="text-insert-input">Mat khau:</span>
                                            <div class="box-insert-input">
                                                <asp:TextBox class="input-input-text" ID="tbMatKhau" runat="server"></asp:TextBox>
                                            </div>
                                        </div>

                                      

                                          <div class="box-content-input">
                                            <span class="text-insert-input">Full Name:</span>
                                            <div class="box-insert-input">
                                                <asp:TextBox class="input-input-text" ID="tbFullName" runat="server"></asp:TextBox>
                                            </div>
                                        </div>
                                       

                                       

                                         

                                        <asp:Button ID="Button1" class="btn-insert-product" runat="server" Text="Sửa"  OnClick="Button1_Click"/>
                                    </div>
                                </div>
                            </div>

                        </div>
                    </div>
               </div>
</asp:Content>
