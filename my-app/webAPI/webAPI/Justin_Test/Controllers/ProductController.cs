using Justin_Test.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;


namespace Justin_Test.Controllers
{
    public class ProductController : ApiController
    {
        //Get function
        public HttpResponseMessage Get()
        {
            //creating list using ListElements to create multidimensional list
            List<ListElement> Product = new List<ListElement>();

            //storing PhotoFilePath
            string PhotoUrl = "http://localhost:54771/Photos/";


            //Adding Products
            //Images are being sent as string, using <img> to display them.
            Product.Add(new ListElement { ProductId = 1, Name = "Shoes", Price = 230, Stock = 23,Image= (PhotoUrl + "shoe.png") });
            Product.Add(new ListElement { ProductId = 2, Name = "Socks", Price = 23, Stock = 30, Image = (PhotoUrl + "socks.png") });
            Product.Add(new ListElement { ProductId = 3, Name = "Boots", Price = 190, Stock = 8, Image = (PhotoUrl + "boots.png") });

            return Request.CreateResponse(HttpStatusCode.OK, Product);
        }

    }
}