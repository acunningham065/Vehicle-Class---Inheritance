using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle___Inheritance_Explanation
{

    //Base Class
    class BankAccount
    {
        //Using public so that no properties needed
        public int AccountNo;
        public int AccountBalance;
        public DateTime DateAccountOpened;

    }


    //Derived Class
    class OrdinaryBankAccount : BankAccount
    {
        
    }


    //Derived Class
    class InterestBearingAccount:BankAccount
    {
        //Using public so that no properties needed
        public decimal interestRate = 3.0m;
        public decimal monthlyCharge = 5.00m; 
    }


    //Base Class - Parent Class
    class Vehicle
    {
        //Using public so that no properties needed
        public string Make;
        public string Model;
        public int Mileage;
    }


    //Derived class - Child Class
    class Car : Vehicle
    {
        //Using public so that no properties needed
        public int NoDoors;
        public string Colour;

    }


    class Program
    {
        static void Main(string[] args)
        {
            Vehicle newVehicle = new Vehicle(); //Create an instance of parent class

            newVehicle.Make = "Audi";
            newVehicle.Model = "TT";
            newVehicle.Mileage = 10000;

            Car newCar = new Car(); //Create an instance of child class

            //Using Parent class fields
            newCar.Make = "Audi";
            newCar.Model = "TT";
            newCar.Mileage = 10000;

            //Using Child class fields
            newCar.NoDoors = 2;
            newCar.Colour = "Midnight Blue";

            BankAccount newAccount = new BankAccount();

            newAccount.AccountNo = 12345678;
            newAccount.AccountBalance = 0;
            newAccount.DateAccountOpened = DateTime.Today;

            OrdinaryBankAccount newAccount2 = new OrdinaryBankAccount();

            newAccount2.AccountNo = 12345678;
            newAccount2.AccountBalance = 0;
            newAccount2.DateAccountOpened = DateTime.Today;

            InterestBearingAccount newAccount3 = new InterestBearingAccount();

            newAccount3.AccountNo = 12345678;
            newAccount3.AccountBalance = 0;
            newAccount3.DateAccountOpened = DateTime.Today;

            newAccount3.interestRate = 3m;
            newAccount3.monthlyCharge = 5.0m;


        }
    }
}
