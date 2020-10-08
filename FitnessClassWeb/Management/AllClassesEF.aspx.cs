using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FitnessClassWeb.Models;

namespace FitnessClassWeb.Management
{
    public partial class EFAllClasses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (var db = new FitnessClassDBEntities())
            {
                // LINQ
                var fClass = (from fc in db.FitnessClasses
                              orderby fc.classID
                              ascending
                              select fc)
                              .ToList();

                // assign the data to the repeater
                RAllClassesEF.DataSource = fClass;
                //trigger the repeater to incorporate and display the data 
                RAllClassesEF.DataBind();

            }
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
