using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class CollectionNonGeneric : System.Web.UI.Page
    {
        ArrayList ar;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
          ar = new ArrayList();
            Label1.Text="capacity "+ar.Capacity.ToString()+" count ="+ar.Count;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            ar.Add(1);
            ar.Add("pravin");
            ar.Add(3.14);
        }
    }
}