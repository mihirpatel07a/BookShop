<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Seller/SellerMaster.Master" AutoEventWireup="true" CodeBehind="Selling.aspx.cs" Inherits="BookShop1.Views.Seller.Selling" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MyContent" runat="server">
    <div class="container-fluid">
        <div class="row">

        </div>
        <div class="row">
            <div class="col-md-5">
                <h3 class="text-center" style="color:teal;" > Book Details</h3>
                
                <div class="row">
                    <div class="col">
                        <div class="mt-3">
                          <label for=""  class="col-form-label text-success" >Book Name</label>   
                          <input type ="text" placeholder="book Name" autocomplete="off" class="form-control" runat="server" id="BnameTb"/>
                        </div>
                    </div>

                    <div class ="col">
                        <div class="mt-3">
                                 <label for=""  class="col-form-label text-success" >Book price</label>   
                          </label>
                          <input type ="text" placeholder="Book price" autocomplete="off" class="form-control" runat="server" id="BpriceTb"/>
                        </div>
                    </div>
                </div>

                 <div class="row">
                    <div class="col">
                        <div class="mt-3">
                          <label for=""  class="col-form-label text-success" >Quntity</label>   
                          <input type ="text" placeholder="quntity" autocomplete="off" class="form-control" runat="server" id="BQtyT"/>
                        </div>
                    </div>

                    <div class ="col">
                        <div class="mt-3">
                                 <label for=""  class="col-form-label text-success" >Billing Date</label>   
                          </label>
                          <input type ="date" placeholder="" autocomplete="off" class="form-control" runat="server" id="DateTb"/>
                        </div>
                    </div>

                  
                </div>

                <br />

                   <div class="row">
                         <div class="col d-grid">
                              <asp:Button ID="AddtobillBtn" runat="server" Text="AddtoBill" CssClass="btn-warning btn-block btn" OnClick="AddtobillBtn_Click"  />
                         </div>
                     </div>

                
                       <div class ="row">
                       <asp:Label runat ="server" ID="ErrMsg" CssClass="text-danger" ></asp:Label>
                </div>

                <div class="row mt-5">
                      <div class="col-md-12">
                     <h4 class="text-center" style="color:teal;" > Book List</h4>
                          </div>
                    <div class="col">
                           <asp:GridView ID="Booklist" runat="server" AutoGenerateSelectButton="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" CellPadding="4" ForeColor="#333333" GridLines="None" Width="564px">
                        <AlternatingRowStyle BackColor="White" />
                        <EditRowStyle BackColor="#7C6F57" />
                        <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="#E3EAEB" />
                        <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                        <SortedAscendingCellStyle BackColor="#F8FAFA" />
                        <SortedAscendingHeaderStyle BackColor="#246B61" />
                        <SortedDescendingCellStyle BackColor="#D4DFE1" />
                        <SortedDescendingHeaderStyle BackColor="#15524A" />
                    </asp:GridView>
                    </div>

                </div>
            </div>
            <div class="col-md-7">
                 <h4 class="text-center" style="color:crimson;" > Client's Bill</h4>
                  <div class="col">
                           <asp:GridView ID="BillList" runat="server" AutoGenerateSelectButton="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" CellPadding="4" ForeColor="#333333" GridLines="None" Width="564px">
                        <AlternatingRowStyle BackColor="White" />
                        <EditRowStyle BackColor="#7C6F57" />
                        <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="#E3EAEB" />
                        <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                        <SortedAscendingCellStyle BackColor="#F8FAFA" />
                        <SortedAscendingHeaderStyle BackColor="#246B61" />
                        <SortedDescendingCellStyle BackColor="#D4DFE1" />
                        <SortedDescendingHeaderStyle BackColor="#15524A" />
                    </asp:GridView>
                      <br />
                       <div class="col d-grid">

                        <asp:Label ID="Total" runat="server"  CssClass=" text-danger text-center" ></asp:Label>
                           
                        <asp:Button ID="PrintBtn" runat="server" Text="print" CssClass="btn-warning btn-block btn" OnClick="PrintBtn_Click" Width="483px"  />
 
                    </div>
                    </div>
            </div>
        </div>
    </div>
</asp:Content>
