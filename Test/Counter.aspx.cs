using System;

namespace Test
{
    public partial class Counter : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var x = 100;

            if (!IsPostBack)
            {
                ViewState["count"] = Convert.ToString(x); //100
                ViewState["SecondCount"] = Convert.ToString(x); //100
                Label1.Text = Convert.ToString(x);
                Label2.Text = Convert.ToString(x);
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var count = Convert.ToInt32(ViewState["count"]);
            count++;

            var seconCount = Convert.ToInt32(ViewState["SecondCount"]);
            seconCount--;
            ViewState["count"] = count;
            ViewState["SecondCount"] = seconCount;
            Label1.Text = Convert.ToString(count);
            Label2.Text = Convert.ToString(seconCount);
        }
    }
}