using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FitnessClassWeb
{
    public partial class AllClasses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected string shortText(object expression)
        {
            var description = Convert.ToString(expression);

            if (!string.IsNullOrEmpty(description))
            {
                if (description.Length > 110)
                {
                    description = description.Substring(0, 110) + "...";
                }
                else { /*description = description;*/ }
            }
            return description;
        }

    }
}