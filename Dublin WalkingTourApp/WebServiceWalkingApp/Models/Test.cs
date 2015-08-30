using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServiceWalkingApp.Models
{
    public class Test
    {
        static void Main()
        {
            MobileServiceContext db = new MobileServiceContext();
            Walk w = new Walk();
            Console.WriteLine("Got to here");
        }
    }
}