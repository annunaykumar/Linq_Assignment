using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Linq_Assignment
{
    internal class Q3
    {
        
        
            public int Ordar_id { get; set; }

            public string item_Name { get; set; }

           
            public int Quantity { get; set; }
          
            public DateTime Ordar_date { get; private set; }

        public static void M()
        {
            List<Q3> listOfUsers = new List<Q3>()
        {
        new Q3() {Ordar_id =11,item_Name = "Pizza",Ordar_date =new DateTime(2022,9,3) , Quantity = 96 },
        new Q3() {Ordar_id =12,item_Name = "Burger",Ordar_date =new DateTime(2022,8,15), Quantity = 18 },
        new Q3() {Ordar_id =13,item_Name = "Chicken Lollipop",Ordar_date =new DateTime(2022,8,3) , Quantity = 145 },
        new Q3() {Ordar_id =14,item_Name = "Chowmin",Ordar_date =new DateTime(2022,8,16) , Quantity = 67 },

        };

            List<Q3> sortedUsers = listOfUsers.OrderBy(user => user.Ordar_date).ThenBy(user => user.Quantity).ToList();
            foreach (Q3 user in sortedUsers)


                Console.WriteLine(user.Ordar_date + ": " + user.Quantity + " calories");




            List<Q3> sortedUsers1 = listOfUsers.OrderBy(user => user.Quantity).ThenBy(user => user.Ordar_date).ToList();
            foreach (Q3 user in sortedUsers1)



                Console.WriteLine(user.Quantity + "calories"+":" + user.Ordar_date +  "  ");

        }

        //class User
      //  {
           // public int Ordar_id { get; set; }

          //  public string item_Name { get; set; }

            //public  string Ordar_date { get; set; }
           // public DateTime Order_date { get; private set; }
          //  public int Quantity { get; set; }
        }
    }
