using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS4BoykoSurlev1
{
    public partial class ArchersInfo : System.Web.UI.Page
    {
        localhost2.ArchersService archs = new localhost2.ArchersService();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonInfo_Click(object sender, EventArgs e)
        {
            localhost2.ArchersResponse archr = archs.returnNameAndPrices(TextBoxRealName.Text);
            if (archr.alias != null)
            {
                string alias = archr.alias;
                string price = archr.prices;
                TextBoxResult.Text = TextBoxRealName.Text + "'s alias is : " + alias + ", and his/her price is " + price;
            }
            else
            {
                TextBoxResult.Text = "Error! Please type in a name.";
            }
            TextBoxRealName.Text = "";
        }
    }
}