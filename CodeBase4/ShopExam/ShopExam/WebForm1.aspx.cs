using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShopExam
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string[] str = new string[] { "Select", "Apple", "SonyHeadphone", "Innova", "Vivo", "Ertiga" };
                for (int i = 0; i < str.Length; i++)
                {
                    DropDownList1.Items.Add(str[i]);
                }
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = DropDownList1.Text;
            Image1.ImageUrl = "~/images/" + str + ".jpg";
        }
        protected void TextBox1_TextChanged1(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            TextBox1.Text = DropDownList1.SelectedIndex.ToString();
            if (DropDownList1.Text == "Apple")
            {
                TextBox1.Text = "Rs. 45000";
            }
            else if (DropDownList1.Text == "SonyHeaphone")
            {
                TextBox1.Text = "Rs. 5000";
            }
            else if (DropDownList1.Text == "Innova")
            {
                TextBox1.Text = "Rs.2500000";
            }
            else if (DropDownList1.Text == "Vivo")
            {
                TextBox1.Text = "Rs.15000";
            }
            else
            {
                TextBox1.Text = "Rs.502000";
            }
        }
    }
}