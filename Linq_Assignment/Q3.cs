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

        public static void M()
        {
            List<User> listOfUsers = new List<User>()
        {
        new User() {Ordar_id =11,item_Name = "Pizza",Ordar_date =("2022/09/03") , Quantity = 96 },
        new User() {Ordar_id =12,item_Name = "Burger",Ordar_date =("2022/08/15"), Quantity = 18 },
        new User() {Ordar_id =13,item_Name = "Chicken Lollipop",Ordar_date =("2022/08/03") , Quantity = 145 },
        new User() {Ordar_id =14,item_Name = "Chowmin",Ordar_date =("2022/08/16") , Quantity = 67 },

        };

            List<User> sortedUsers = listOfUsers.OrderBy(user => user.Ordar_date).ThenBy(user => user.Quantity).ToList();
            foreach (User user in sortedUsers)


                Console.WriteLine(user.Ordar_date + ": " + user.Quantity + " calories");




            List<User> sortedUsers1 = listOfUsers.OrderBy(user => user.Quantity).ThenBy(user => user.Ordar_date).ToList();
            foreach (User user in sortedUsers1)



                Console.WriteLine(user.Quantity + "calories"+":" + user.Ordar_date +  "  ");

        }

        class User
        {
            public int Ordar_id { get; set; }

            public string item_Name { get; set; }

            public  string Ordar_date { get; set; }
            public int Quantity { get; set; }
        }
    }
}
