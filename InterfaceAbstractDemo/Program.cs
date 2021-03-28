using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager baseCustomerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
           //Kimlik bilgilerinizle test ediniz
            baseCustomerManager.Save(new Customer { DateOfBirth = new DateTime(), FirstName = "", LastName = "", NationalyId = "" });
            Console.ReadKey();
        }
    }
}
