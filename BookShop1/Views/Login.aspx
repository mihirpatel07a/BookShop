<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="BookShop1.Views.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="../Assets/lib/css/bootstrap.min.css" />


</head>
<body>
    <div  class="container-fluid" >
        <div class="row">

        </div>
        <div class="row">
          

            <div class =" col-md-4">
        

         
                 <form id="form1" runat="server">
                    <div class =" mt-3">
                        


                        <asp:Image ID="Image1" runat="server" ImageUrl="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTC0HlQ_ckX6HqCAlqroocyRDx_ZRu3x3ezoA&amp;usqp=CAU" />
                        


                    </div>



                     <div class ="mt-3">
                          <label for=""  class="col-form-label">Email<asp:Image ID="Image2" runat="server" />
                          </label>
                          <input type ="email" placeholder="enter your email" autocomplete="off" class="form-control" runat="server" id="U_name"/>
                     </div>

                     <div class="mt-3">
                         <label for="" class="form-check-label">Password </label>
                         <input type ="password" placeholder="Password" autocomplete ="off" class="form-control"  runat="server" id="Password"/>
                      </div>

                     
                     <div class="mt-3 d-grid">
                     
                         <asp:Button  runat="server" CssClass="btn-success" Text="Login" ID="loginbtn" OnClick="loginbtn_Click"   />
                     
                      </div>

                       <div class ="row">
                       <asp:Label runat ="server" ID="ErrMsg" CssClass="text-danger" ></asp:Label>
                </div>

    
                 </form>
                          
            </div>
          
            
        </div>
    </div>
</body>
</html>
