using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EC1_LINQ_Demo
{
    public partial class Products : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataClasses1DataContext dataContext = new DataClasses1DataContext();

            GridView1.DataSource = from product in dataContext.Products
                                   select new
                                   {
                                       product.productName,
                                       product.productDescription,
                                       product.unitPrice
                                   };

            GridView1.DataBind();
        }
    }
}