using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BookShop1.Views.Admin
{
    public partial class Books : System.Web.UI.Page
    {
        BookShop.Models.functions Con;
        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new BookShop.Models.functions();
            if (!IsPostBack)
            {
                ShowBooks();
                Getcategories();
                GetAuthors();
            }
        }

        private void ShowBooks()
        {
            string query = "Select * from BookTb";
            Booklist.DataSource = Con.GetData(query);
            Booklist.DataBind();
        }

        private void Getcategories()
        {
            string query = "select * from CategoryTbl";
            bcategories.DataTextField = Con.GetData(query).Columns["CatName"].ToString();
            bcategories.DataValueField = Con.GetData(query).Columns["Catid"].ToString();


            bcategories.DataSource = Con.GetData(query);
            bcategories.DataBind();

        }

        private void GetAuthors()
        {
            string query = "select * from AuthorTb";
            bauthor.DataTextField = Con.GetData(query).Columns["AutName"].ToString();
            bauthor.DataValueField = Con.GetData(query).Columns["Autid"].ToString();

            bauthor.DataSource = Con.GetData(query);
            bauthor.DataBind();
        }
        protected void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (bname.Value == "" || bauthor.SelectedIndex == -1 || bcategories.SelectedIndex == -1 || bquntity.Value == "" || bprice == null)
                {
                    ErrMsg.Text = "Missing Detail!!!";

                }
                else
                {
                    string Bname = bname.Value;
                    string Bauthor = bauthor.SelectedValue.ToString();
                    string Bcategory = bcategories.SelectedValue.ToString();
                    int quantity = Convert.ToInt32(bquntity.Value);
                    int price = Convert.ToInt32(bprice.Value);



                    string query = "update BookTb set BName = '{0}' , BAuthor = '{1}' , BCategory = '{2}' , BQty = '{3}' , BPrice = '{4}' where Bid = '{5}' ";
                    query = string.Format(query, Bname, Bauthor, Bcategory, quantity, price , Booklist.SelectedRow.Cells[1].Text);
                    Con.SetData(query);
                    ShowBooks();
                    ErrMsg.Text = "Book Updated";
                    bname.Value = "";
                    bauthor.SelectedIndex = -1;
                    bcategories.SelectedIndex = -1;
                    bquntity.Value = "";
                    bprice.Value = "";
                }

            }
            catch (Exception ex)
            {
                ErrMsg.Text = ex.Message;
            }
        }

        protected void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (bname.Value == "" || bauthor.SelectedIndex == -1 || bcategories.SelectedIndex == -1 || bquntity.Value == "" || bprice == null)
                {
                    ErrMsg.Text = "Missing Detail!!!";

                }
                else
                {
                    string Bname = bname.Value;
                    string Bauthor = bauthor.SelectedValue.ToString();
                    string Bcategory = bcategories.SelectedValue.ToString();
                    int quantity = Convert.ToInt32(bquntity.Value);
                    int price = Convert.ToInt32(bprice.Value);



                    string query = "delete from BookTb where Bid = '{0}' ";
                    query = string.Format(query, Booklist.SelectedRow.Cells[1].Text);
                    Con.SetData(query);
                    ShowBooks();
                    ErrMsg.Text = "Book Deleted !!!";
                    bname.Value = "";
                    bauthor.SelectedIndex = -1;
                    bcategories.SelectedIndex = -1;
                    bquntity.Value = "";
                    bprice.Value = "";
                }

            }
            catch (Exception ex)
            {

                ErrMsg.Text = ex.Message;
            }
        }

        protected void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (bname.Value == "" || bauthor.SelectedIndex == -1 || bcategories.SelectedIndex == -1 || bquntity.Value == "" || bprice == null)
                {
                    ErrMsg.Text = "Missing Detail!!!";

                }
                else
                {
                    string Bname = bname.Value;
                    string Bauthor = bauthor.SelectedValue.ToString();
                    string Bcategory = bcategories.SelectedValue.ToString();
                    int quantity = Convert.ToInt32(bquntity.Value);
                    int price = Convert.ToInt32(bprice.Value);

                   

                    string query = "insert into BookTb values('{0}' , '{1}' , '{2}' , '{3}' , '{4}')";
                    query = string.Format(query, Bname, Bauthor, Bcategory , quantity , price);
                    Con.SetData(query);
                    ShowBooks();
                    ErrMsg.Text = "Book inserted";
                    bname.Value = "";
                    bauthor.SelectedIndex = -1;
                    bcategories.SelectedIndex = -1;
                    bquntity.Value = "";
                    bprice.Value = "";
                }

            }
            catch (Exception ex)
            {

                ErrMsg.Text = ex.Message;
            }
        }
        int key = 0;
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bname.Value = Booklist.SelectedRow.Cells[2].Text;
            bauthor.SelectedValue = Booklist.SelectedRow.Cells[3].Text;
            bcategories.SelectedValue = Booklist.SelectedRow.Cells[4].Text;
            bquntity.Value = Booklist.SelectedRow.Cells[5].Text;
            bprice.Value = Booklist.SelectedRow.Cells[6].Text;
            if (bname.Value == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(Booklist.SelectedRow.Cells[1].Text);
            }
        }
    }
}