using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Demonstrations
{
    public partial class ServerControls : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submitButton_Click(object sender, EventArgs e)
        {
            displayLabel.Text = demoToolbox.Text;
            //set the text of the label to the text from the text box
            demoToolbox.Text = string.Empty;//empty the text box
        }
    }
}