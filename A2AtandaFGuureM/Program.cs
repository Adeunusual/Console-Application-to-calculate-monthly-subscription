/*
 * Program.cs
 * 
 * A Program to Calculate online registration for a monthly subscription company
 * 
 * Revison History:
 * Faruq A. Atanda and Guure Mohamud, 2024.02.02: Created
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2AtandaFGuureM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaring Variables
            int age;
            double ageFee = 0, ageFee1 = 10.00, ageFee2 = 25.50, ageFee3 = 50.50, ageFee4 = 0, clientReferralDiscount, subTotal;
            double startMonthFee = 0, startMonthFee1 = -10.00, startMonthFee2 = 20.00, startMonthFee3 = 0;
            double total, HST, cityServiceTax;
            string startMonth, referredByAClient;

            //bool  = true; 

            //Collect applicant age
            Console.Write("please enter you age: ");
            age = Convert.ToInt32(Console.ReadLine());

            //Collect applicant start month
            Console.Write("\nEnter month you wish to start your subscription: ");
            startMonth = Console.ReadLine();

            //Logic to determine age fee
            if (age < 19)
            {
                ageFee = ageFee1;
            }
            else if (age >= 20 && age <= 29)
            {
                ageFee = ageFee2;
            }
            else if (age >= 30 && age <= 59)
            {
                ageFee = ageFee3;
            }
            else if (age >= 60)
            {
                ageFee = ageFee4;
            }


            //Logic to determine discount based on start month
            switch (startMonth)
            {
                case "January":
                case "February":
                    startMonthFee = startMonthFee1;
                    break;
                case "March":
                case "April":
                    startMonthFee = age * .1;
                    break;
                case "May":
                    startMonthFee = startMonthFee2;
                    break;
                case "June":
                case "July":
                case "Agust":
                case "September":
                case "October":
                case "November":
                case "Decmber":
                    startMonthFee = startMonthFee3;
                    break;
                default:
                    Console.WriteLine("invalid Month value!");
                    break;
            }

            //Logic to determine client referral discount
            Console.Write("Where you referred by an existing client? Yes/No: ");
            referredByAClient = Console.ReadLine();

            if (referredByAClient == "Yes")
            {
                clientReferralDiscount = 10.50;
            }
            else
            {
                clientReferralDiscount = 0;
            }

            //Logic to determine Sub total
            subTotal = ((+ageFee) + (+startMonthFee)) - (+clientReferralDiscount);
           
            if (subTotal < 0)
            {
                subTotal = 0;
            }

            //Logic to determine Taxes on sub total
            HST = subTotal * .13;
            cityServiceTax = subTotal * .08;

            //Logic to determine Total amount to be paid
            total = (subTotal + HST + cityServiceTax);

            //Output Result
            Console.Clear();
            Console.WriteLine($"Your age: {age}\n");
            Console.WriteLine($"Your registration month: {startMonth}\n\n\n");
            Console.WriteLine($"Monthly subscription based on age: {ageFee.ToString("C")}");
            Console.WriteLine($"Start month adjustment:            {startMonthFee.ToString("C")}");
            Console.WriteLine($"Client referral adjustment:        {clientReferralDiscount.ToString("-$.00")}");
            Console.WriteLine($"subtotal:                          {subTotal.ToString("C")}\n\n");
            Console.WriteLine($"HST                                {HST.ToString("C")} ");
            Console.WriteLine($"City Services Tax                  {cityServiceTax.ToString("C")}\n\n");
            Console.WriteLine($"Final Monthly Subscription Total:  {total}");


            //Ask system to await KeyPress
            Console.ReadKey();

        }
    }
}
