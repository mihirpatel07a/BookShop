using BookShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BookShop1.Views.Admin
{
    
    public partial class Author : System.Web.UI.Page
    {

        BookShop.Models.functions Con;
        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new BookShop.Models.functions();
            ShowAuthors();
        }

        private void ShowAuthors()
        {
            string query = "Select * from AuthorTb";
            AuthorsList.DataSource = Con.GetData(query);
            AuthorsList.DataBind();
        }

        protected void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if(ANameTb.Value == "" || Genb.SelectedIndex == -1 || CountryCb.SelectedIndex == -1)
                {
                    ErrMsg.Text = "Missing Detail!!!";

                }
                else
                {
                    string Aname = ANameTb.Value;
                    string gender = Genb.SelectedItem.ToString();
                    string country = CountryCb.SelectedItem.ToString();

                    string query = "insert into AuthorTb values('{0}' , '{1}' , '{2}')";
                    query = string.Format(query, Aname, gender, country);
                    Con.SetData(query);
                    ShowAuthors();
                    ErrMsg.Text = "Author inserted";
                    ANameTb.Value = "";
                    Genb.SelectedIndex = -1;
                    CountryCb.SelectedIndex = -1;
                }
               
            }
            catch(Exception ex)
            {

                ErrMsg.Text = ex.Message;
            }
        }
        int key = 0;
        protected void AuthorsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ANameTb.Value = AuthorsList.SelectedRow.Cells[2].Text;
            Genb.SelectedValue = AuthorsList.SelectedRow.Cells[3].Text;
            CountryCb.SelectedValue = AuthorsList.SelectedRow.Cells[4].Text;
            if(ANameTb.Value == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(AuthorsList.SelectedRow.Cells[1].Text);
            }
        }

        protected void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ANameTb.Value == "" || Genb.SelectedIndex == -1 || CountryCb.SelectedIndex == -1)
                {
                    ErrMsg.Text = "Missing Detail!!!";

                }
                else
                {
                    string Aname = ANameTb.Value;
                    string gender = Genb.SelectedItem.ToString();
                    string country = CountryCb.SelectedItem.ToString();
               
                    
                    string query = "update AuthorTb set AutName = '{0}' ,AutGender = '{1}' , AutCountry =  '{2}' where Autid = '{3}' " ;
                
                    query = string.Format(query, Aname, gender, country , AuthorsList.SelectedRow.Cells[1].Text);
                    Con.SetData(query);
                    ShowAuthors();
                    ErrMsg.Text = "Author Updated";
                   
                    ANameTb.Value = "";
                    Genb.SelectedIndex = -1;
                    CountryCb.SelectedIndex = -1;
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
                if (ANameTb.Value == "" || Genb.SelectedIndex == -1 || CountryCb.SelectedIndex == -1)
                {
                    ErrMsg.Text = "Select aṇ Author!!!";

                }
                else
                {
                    string Aname = ANameTb.Value;
                    string gender = Genb.SelectedItem.ToString();
                    string country = CountryCb.SelectedItem.ToString();

                    string query = "delete from  AuthorTb where Autid='{0}'";
                    query = string.Format(query, AuthorsList.SelectedRow.Cells[1].Text);
                    Con.SetData(query);
                    ShowAuthors();
                    ErrMsg.Text = "Author Deleted!!!";
                    ANameTb.Value = "";
                    Genb.SelectedIndex = -1;
                    CountryCb.SelectedIndex = -1;
                }

            }
            catch (Exception ex)
            {

                ErrMsg.Text = ex.Message;
            }
        }
    }
}