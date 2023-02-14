using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    /// <summary>
    /// Summary description for Webhook
    /// </summary>
    public class Webhook : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.Write("Hello World new fourth time");
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