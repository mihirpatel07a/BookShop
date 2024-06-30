using BookShop.Views.Admin;
using BookShop1.Views.Admin;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace BookShop1.Views.Seller
{
    public partial class Selling : System.Web.UI.Page
    {
        BookShop.Models.functions Con;
        int seller = Login.User;
        string SName = Login.uname;
        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new BookShop.Models.functions();
            if (!IsPostBack)
            {
                ShowBooks();
                DataTable dt = new DataTable();
                dt.Columns.AddRange(new DataColumn[5]
                    {
                       new DataColumn("ID"),
                       new DataColumn("Book"),
                       new DataColumn("Price"),
                       new DataColumn("Qunatity"),
                       new DataColumn("Total")
                    }
                    );

                ViewState["Bill"] = dt;
                this.BindGrid();
                

            }
        }

        protected void BindGrid()
        {
            BillList.DataSource = ViewState["Bill"];
            BillList.DataBind();
        }
        private void ShowBooks()
        {
            string query = "Select Bid as code , BName as Name , BQty as Stock , BPrice as Price  from BookTb";
            Booklist.DataSource = Con.GetData(query);
            Booklist.DataBind();
        }

        int key = 0;
            int stock = 0;
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            BnameTb.Value = Booklist.SelectedRow.Cells[2].Text;
            stock  = Convert.ToInt32(Booklist.SelectedRow.Cells[3].Text);
            BpriceTb.Value = Booklist.SelectedRow.Cells[4].Text;
          
            if (BnameTb.Value == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(Booklist.SelectedRow.Cells[1].Text);
            }
        }

        private void updatestock()
        {

            int newqty;
            newqty = (Convert.ToInt32(Booklist.SelectedRow.Cells[5].Text)) - (Convert.ToInt32(BQtyT.Value));

            if(newqty > 0)
            {
                string query = "update BookTb set BQty='{0}' where Bid = '{1}'";
                query = string.Format(query, newqty, Booklist.SelectedRow.Cells[1].Text);
                Con.SetData(query);
                ShowBooks();
            }
              
            else if(newqty == 0)
            {
                ErrMsg.Text = "The book is out of stock";
            }
            else
            {
                ErrMsg.Text = "sufficient book is not available";
            }
          
        }

        protected void PrintBtn_Click(object sender, EventArgs e)
        {

        }
        int grdtotal = 0;
        int amount;
        protected void AddtobillBtn_Click(object sender, EventArgs e)
        {
            
            if (BnameTb.Value == "" || BpriceTb.Value == "" || BQtyT.Value == ""  )
            {
                ErrMsg.Text = "missing details !!";
            }

            else
            {
                int total = Convert.ToInt32(BQtyT.Value) * Convert.ToInt32(BpriceTb.Value);
                DataTable dt = (DataTable)ViewState["Bill"];
                dt.Rows.Add(BillList.Rows.Count + 1,
                    BnameTb.Value.Trim(),
                    BpriceTb.Value.Trim(),
                    BQtyT.Value.Trim(),
                    total);

                ViewState["Bill"] = dt;
                this.BindGrid();

                grdtotal = 0;

                for (int i = 0; i <= BillList.Rows.Count - 1; i++)
                {
                    grdtotal = grdtotal + Convert.ToInt32(BillList.Rows[i].Cells[5].Text);
                }

                amount = grdtotal;
                Total.Text = "Rs" + grdtotal;
                BnameTb.Value = "";
                BpriceTb.Value = "";
                BQtyT.Value = "";
                grdtotal = 0;

                updatestock();
            }
          
        }

    }
}