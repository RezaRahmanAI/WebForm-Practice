using System;

namespace Test
{
    public partial class TestForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            showName.Text = "Hello " + txtName.Text + "!";
        }
    }
}