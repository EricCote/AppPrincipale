using AppPrincipale.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace AppPrincipale
{
    /// <summary>
    /// Summary description for Picture
    /// </summary>
    public class Picture : IHttpHandler
    {
        public RequestContext RequestContext { get; set; }

        public void ProcessRequest(HttpContext context)
        {
            int productID = 0;
            int.TryParse(context.Request.QueryString["id"], out productID);

            if (productID != 0)
            {
                using (AwContext db = new AwContext())
                {
                    Product prod = db.Products.Find(productID);
                    if (prod != null)
                    {
                        context.Response.ContentType = "image/gif";
                        context.Response.BinaryWrite(prod.ThumbNailPhoto);
                        //context.Response.End();
                    }
                }
            }
            else
            {
                context.Response.Write("Pas de produit!!!!");
            }

        }

       
        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}