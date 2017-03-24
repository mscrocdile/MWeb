using AdPrj1;
using AdPrj2;
using MWeb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        var a = new First();
        var b = new Second();
        var c = new Main();

        lbl.Text = a.Text + b.Text + c.Text;
    }
}