using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompileError.Model.Model;
using CompileError.Manager.Manager;

namespace CompileError.Console
{
    class Program
    {
       // private static readonly ProductManager _productManager = new ProductManager();
        static void Main(string[] args)
        {

            
            /* ProductModel productModel = new ProductModel
             {
                 Category = "Mobile",
                 Code = "m-1000",
                 Name = "Samsung Galaxy Y",
                 ReorderLevel = 100,
                 Description = "First Generation Galaxy Phone"
             };*/

            //  _productManager.Add(productModel);

            CustomerManager _customerManager = new CustomerManager();
              Customer customer = new Customer()
              {
                  Code = "c002",
                  Name="nandita",
                  Address="airport",
                  Email="nandita@gmail.com",
                  Contact="01700000000",
                  LoyalityPoint=20


              };
            
         /*     if(_customerManager.Add(customer))
              {
                  System.Console.WriteLine("Added");
              }
              else
              {
                  System.Console.WriteLine("can not added");
              }*/

         /*   if (_customerManager.Delete(2))
            {
                System.Console.WriteLine("deleted");
            }
            else
            {
                System.Console.WriteLine("can not delete");
            }
            */
            customer.Id = 1;
            customer.Code = "111";
            customer.Name = "Nandita Mandal";
            customer.Email = "nandita@gmail.com";
            customer.Contact = "0190000";
            customer.LoyalityPoint = 20;

        //    if (_customerManager.Update(customer))
          //  {
            //    System.Console.WriteLine("updated..");
            //}
            //else
            //{
              //  System.Console.WriteLine("can not updated...");
            ///}
            var Customers = _customerManager.GetAll();
            foreach(var cus in Customers)
            {
                System.Console.WriteLine("code: " + cus.Code+" "+
                    "name: " + cus.Name+" "+"Address "+ cus.Address+" "+"Contact "
                    +cus.Contact+" "+"Loyality Point "+cus.LoyalityPoint
                    );
            }

            var acustomers = _customerManager.Search(1);
           
            System.Console.WriteLine("Code: "+acustomers.Code+"\n"
                +"Name "+acustomers.Name+"\n "+"Address "+acustomers.Address+"\n "
                +"Contact "+acustomers.Contact+ "\n "+"Loyality point "+acustomers.LoyalityPoint
                );


            System.Console.ReadKey();


            


        }
    }
}
