using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------Dont Repeat Yourself---------");

            Customer customer1 = new Customer();
            customer1.Name = "Zeynal";
            customer1.Surname = "Esedov";
            customer1.Id = 9271485;
            customer1.Password = 70789700;

            Customer customer2 = new Customer();
            customer2.Name = "Eli";
            customer2.Surname = "Huseynov";
            customer2.Id = 9194458;
            customer2.Password = 302585;

            Customer customer3 = new Customer();
            customer3.Name = "MirYasin";
            customer3.Surname = "Seyidov";
            customer3.Id = 2898508;
            customer3.Password = 1358;

            Customer customer4 = new Customer();
            customer4.Name = "Yaşar";
            customer4.Surname = "Novruzov";
            customer4.Id = 6980288;
            customer4.Password = 20459;

            Customer[] customers = new Customer[] { customer1, customer2, customer3, customer4 };

            CustomerManager customerManager = new CustomerManager();
            //Adding - Ekleme
            customerManager.Add(customer4);
            //Deletion - Silme
            customerManager.Delete(customer2);
            //Listing - Listeleme
            customerManager.List(customers);
        }
    }
}
