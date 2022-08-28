using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Assignment
{
    internal class Q5
    {
        // int total_price = price * Quantity;
       // public DateTime Orderdate { get; private set; }
        public string item_Name { get; set; }
        public int price { get; set; }
        public int total_price { get; set; }
        public int Quantity { get; set; }
        public DateTime Ordardate { get; private set; }

        //total_price = price * Quantity;
        public static void M()
        {

            List<Q5> listOfUsers = new List<Q5>()
            {

        new Q5() {item_Name = "Pizza",Ordardate=new DateTime(2016,6,25)  , Quantity = 96,price=150,total_price = 14400},
        new Q5() { item_Name = "Burger", Ordardate = DateTime.Now.AddDays(5), Quantity = 18,price=100,total_price=1800 },
        new Q5() { item_Name = "Chicken Lollipop", Ordardate = new DateTime(2011, 3, 3), Quantity = 145,price=200, total_price =29000 },
        new Q5() { item_Name = "Chowmin", Ordardate = DateTime.Now, Quantity = 67,price=150, total_price =10050 },};

            var ud = listOfUsers.Select(d => new
            {
                d.item_Name,
                FormattedName = d.item_Name.ToString(),
                d.Ordardate.Year,
                d.Ordardate.Month,
                d.Ordardate.Date,
                FormattedOrderdate = d.Ordardate.ToString("yyyy-MMM-dd"),
                d.total_price,
                Formattedprice = d.total_price.ToString()







            })
     .Distinct()

     .OrderByDescending(d => d.Year)
     .ThenByDescending(d => d.Month)
     .ThenByDescending(d => d.Date)
    .ThenByDescending(d => d.FormattedName)
    .ThenByDescending(d => d.Formattedprice);
    //.Select(d => d.FormattedOrderdate);
    //.Select(d => d.Formattedprice);

    
     //.Select(d => d.FormattedName);
           

            Console.WriteLine("After distinct");

            foreach (var r in ud)
            {
                Console.WriteLine(r);
            }
        }
    }
}