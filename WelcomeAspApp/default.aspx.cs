using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WelcomeAspApp
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void idButtonSend_Click(object sender, EventArgs e)
        {
            idFirstStatment.Text = "Witaj " + idName.Text + " " + idSurrname.Text;

            var age = Convert.ToInt32(idAge.Text);
            if (age < 67)
            {
                idSecondStatment.Text = $"You will become pensioner in  {67 - age} !";
            }
            else
                idSecondStatment.Text = "You are pensioner already !";
        }
    }
}