<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Categories.aspx.cs" Inherits="BookShop.Views.Admin.Categories" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MyContent" runat="server">
     <div class="container-fluid">
        <div class="row">
            <div class="col">
                 <h1 class="text-center"> Manage Categories </h1>
            </div>

        </div>
        <div class="row">
            <div class="col-md-4">
                <div class =" mb-3">
                       <label for=""  class="col-form-label text-success">Category Name</label>
                          <input type ="text" placeholder="Name" autocomplete="off" class="form-control" runat ="server" id ="CatName" />
                </div>
                  <div class =" mb-3">
                       <label for=""  class="col-form-label text-success">Category Description</label>
                        <input type ="text" placeholder="Description" autocomplete="off" class="form-control" runat ="server" id="C_des"/>
                       
                </div>
               
                 

                 
                <div class="row ">
                    <div class="col d-flex">
                        <asp:Button ID="UpdateBtn" runat="server" Text="Update" CssClass="btn-warning btn-block btn" OnClick="UpdateBtn_Click" />
 
                    </div>
                     <div class="col d-flex">
                           <asp:Button ID="DeleteBtn" runat="server" Text="Delete"  CssClass="btn-danger btn-block btn" OnClick="DeleteBtn_Click"    />
                    </div>
                     <div class="col d-flex">
                          <asp:Button ID="SaveBtn" runat="server" Text="Save"  CssClass="btn-success btn-block btn" OnClick="SaveBtn_Click"  />
                   
                    </div>
                </div>
                <br />

                <div class="row">
                    <asp:Label ID="ErrMsg" runat="server" CssClass="text-danger"></asp:Label>
                </div>

                <br />
                
                <div class="col-md-8" > 
                    <asp:GridView ID="Categorylist" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Width="440px" AutoGenerateSelectButton="True" OnSelectedIndexChanged="Categorylist_SelectedIndexChanged">
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
    </div>
</asp:Content>
