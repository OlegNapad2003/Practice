using System;

namespace Practice
{
    public class Program
    {
        public static void Main()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var clients = db.Client.ToArray();
                Console.WriteLine("Список объектов");
                foreach (Client u in clients)
                {
                    Console.WriteLine(u.Id + " - " + u.FIO + " - " + u.Stage + " - " + u.Auto_Passport_index);
                }

            }
            using (ApplicationContext db = new ApplicationContext())
            {
                Client test = new Client { Id = 3, FIO = "Сидоров", Stage = 17, Auto_Passport_index = 12356789 };
                db.Client.Add(test);
                db.SaveChanges();
                var clients = db.Client.ToArray();
                Console.WriteLine("Список объектов");
                foreach (Client u in clients)
                {
                    Console.WriteLine(u.Id + " - " + u.FIO + " - " + u.Stage + " - " + u.Auto_Passport_index);
                }

            }

            using (ApplicationContext db = new ApplicationContext())
            {
                Client? updClient = (from Client in db.Client where Client.Id == 2 select Client).First();
                if (updClient != null)
                {
                    updClient.Stage = updClient.Stage * 2;
                    db.SaveChanges();
                }
                var Clients = db.Client.ToArray();
                Console.WriteLine("Список объектов");
                foreach (Client u in Clients)
                {
                    Console.WriteLine(u.Id + " - " + u.FIO + " - " + u.Stage + " - " + u.Auto_Passport_index);
                }

            }

            using (ApplicationContext db = new ApplicationContext())
            {
                Client? delClient = (from Client in db.Client where Client.Id == 3 select Client).First();
                if (delClient != null)
                {
                    db.Client.Remove(delClient);
                    db.SaveChanges();
                }
                var Clients = db.Client.ToArray();
                Console.WriteLine("Список объектов");
                foreach (Client u in Clients)
                {
                    Console.WriteLine(u.Id + " - " + u.FIO + " - " + u.Stage + " - " + u.Auto_Passport_index);
                }

                using (ApplicationContext db = new ApplicationContext())
                {
                    var orders = db.Order.ToArray();
                    Console.WriteLine("Список объектов");
                    foreach (Order u in orders)
                    {
                        Console.WriteLine(u.Id + " - " + u.Type + " - " + u.Restrictions + " - " + u.ClientID + "-" + u.PriceOrder + "-" + u.CompanyID);
                    }

                }

            }
            using (ApplicationContext db = new ApplicationContext())
            {
                var orders = db.Order.ToArray();
                var client = db.Client.Where(c => c.Id == 17).FirstOrDefault();
                Order order = new Order { Id = 20, Type = "Moto", Restrictions = "No" , ClientID = 33, PriceOrder = 4300, CompanyID = 7, Client=client };


                db.Order.Add(order);

                db.SaveChanges();
            }
            using (ApplicationContext db = new ApplicationContext())
            {
                Order upduser = (from order in db.Order where order.Id == 17 select order).First();
                if (upduser != null)
                {
                    upduser.Restrictions = "Yes";
                    db.SaveChanges();
                }
                var orders = db.Order.ToArray();
                Console.WriteLine("Список объектов");
                foreach (Order u in orders)
                {
                    Console.WriteLine(u.Id + " - " + u.Type + " - " + u.Restrictions + " - " + u.ClientID + "-" + u.PriceOrder + "-" + u.CompanyID);
                }

            }
            using (ApplicationContext db = new ApplicationContext())
            {
                Order deluser = (from order in db.Order where order.Id == 17 select order).First();
                if (deluser != null)
                {
                    db.Order.Remove(deluser);
                    db.SaveChanges();
                }
                var orders = db.Order.ToArray();
                Console.WriteLine("Список объектов");
                foreach (Order u in orders)
                {
                    Console.WriteLine(u.Id + " - " + u.Type + " - " + u.Restrictions + " - " + u.ClientID + "-" + u.PriceOrder + "-" + u.CompanyID);
                }

            }



        }
    }
}
