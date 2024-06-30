<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Author.aspx.cs" Inherits="BookShop1.Views.Admin.Author" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MyContent" runat="server">
       <div class="container-fluid">
        <div class="row">
            <div class="col">
                 <h1 class="text-center"> Manage Authors </h1>
            </div>

        </div>
        <div class="row">
            <div class="col-md-4">
                <div class =" mb-3">
                       <label for=""  class="col-form-label text-success">Author Name</label>
                          <input type ="text" placeholder="Name" autocomplete="off" class="form-control" runat="server" id="ANameTb"/>
                </div>
                  <div class =" mb-3">
                       <label for=""  class="col-form-label text-success">Author Gender </label><br />
                        <asp:DropDownList  runat="server" Height="35px" Width="384px" id="Genb">
                            <asp:ListItem>Male</asp:ListItem>
                            <asp:ListItem>Female</asp:ListItem>
                            <asp:ListItem>other</asp:ListItem>
                       </asp:DropDownList>
                </div>
                  <div class =" mb-3">
                       <label for=""  class="col-form-label text-success">Country</label><br />
                      <asp:DropDownList  runat="server"  Height="35px" Width="384px" id="CountryCb" >
                          <asp:ListItem>USA</asp:ListItem>
                          <asp:ListItem>INDIA</asp:ListItem>
                          <asp:ListItem>FRANCE</asp:ListItem>
                          <asp:ListItem>UK</asp:ListItem>
                          <asp:ListItem>SPAIN</asp:ListItem>
                          <asp:ListItem>Other</asp:ListItem>

                      </asp:DropDownList>
                </div>
               
                <br />
                 
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

                <div class ="row">
                       <asp:Label runat ="server" ID="ErrMsg" CssClass="text-danger" ></asp:Label>
                </div>


                <br />
                
                <div class="row">
                      <div class="col-md-8" > 
                    <asp:GridView ID="AuthorsList" runat="server" Height="243px" Width="406px" CssClass="table table-bordered" CellPadding="4" GridLines="None" AutoGenerateSelectButton="True" ForeColor="#333333" OnSelectedIndexChanged="AuthorsList_SelectedIndexChanged" >
                        <AlternatingRowStyle BackColor="White" />
                        <EditRowStyle BackColor="#7C6F57" />
                        <FooterStyle BackColor="#1C5E55" ForeColor="White" Font-Bold="True" />
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
    </div>
</asp:Content>
