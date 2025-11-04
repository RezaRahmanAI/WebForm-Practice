using System;

namespace Test
{
    public partial class Counter : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //ViewState["count"] = 0;
                CounterOp.Text = "0";
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var count = Convert.ToInt32(CounterOp.Text);
            count++;
            CounterOp.Text = Convert.ToString(count);
        }
    }
}