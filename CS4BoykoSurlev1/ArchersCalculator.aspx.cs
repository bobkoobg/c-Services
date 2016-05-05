using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS4BoykoSurlev1
{
    public partial class ArchersCalculator : System.Web.UI.Page
    {
        localhost.CalculatorService archerservice = new localhost.CalculatorService();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonTotal_Click(object sender, EventArgs e)
        {
            ListBoxResult.Items.Clear();
            localhost.CalculatorResponse cr = archerservice.returnTotalPoints(TextBoxName.Text);
            if (cr.alias != null)
            {
                ListBoxResult.Items.Clear();
                string alias = cr.alias;
                string pts = cr.sequenceOfNumbers;
                int overall = cr.result;
                
                ListBoxResult.Items.Add("Alias : " + alias);
                ListBoxResult.Items.Add("Scores : " + pts);
                ListBoxResult.Items.Add("Overall : " + overall);
               
            }
            else
            {
                ListBoxResult.Items.Clear();
                ListBoxResult.Items.Add("Error! Please type in a name.");
            }
            TextBoxName.Text = "";
        }

        protected void ButtonAverage_Click(object sender, EventArgs e)
        {
            ListBoxResult.Items.Clear();
            localhost.CalculatorResponse cr = archerservice.returnAveragePoints(TextBoxName.Text);
            if (cr.alias != null)
            {
                ListBoxResult.Items.Clear();
                string alias = cr.alias;
                string pts = cr.sequenceOfNumbers;
                int average = cr.result;

                ListBoxResult.Items.Add("Alias : " + alias);
                ListBoxResult.Items.Add("Scores : " + pts);
                ListBoxResult.Items.Add("Average : " + average);

            }
            else
            {
                ListBoxResult.Items.Clear();
                ListBoxResult.Items.Add("Error! Please type in a name.");
            }
            TextBoxName.Text = "";
        }

        protected void ButtonSortedNumbers_Click(object sender, EventArgs e)
        {
            ListBoxResult.Items.Clear();
            localhost.CalculatorResponse cr = archerservice.getAllNumberSorted(TextBoxName.Text);
            if (cr.alias != null)
            {
                ListBoxResult.Items.Clear();
                string alias = cr.alias;
                int[] sortedNumbers = cr.points;
                ListBoxResult.Items.Add("Alias : " + alias);
                ListBoxResult.Items.Add("Sorted Results:");
                for (int i = 0; i < sortedNumbers.Length; i++)
                {
                    ListBoxResult.Items.Add("#: " + i + ", value: "  + sortedNumbers[i]);
                }
            }
            else
            {
                ListBoxResult.Items.Clear();
                ListBoxResult.Items.Add("Error! Please type in a name.");
            }
            TextBoxName.Text = "";
        }
    }
}