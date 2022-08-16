using System;

namespace EventsAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CatchFactorOfTen catchFactorOfTen = new CatchFactorOfTen();     //instantiating subscriber class
            catchFactorOfTen.ActOnSeeingFactorOfTen();
        }
    }

    internal class RandomNumberPrinter  //publisher
    {
        public delegate void NotifyHandler();                   //delegate creation
        public event NotifyHandler NotifyOtherClasses;              //event creation

        public void PrintRandomNumber()
        {

            try
            {
                for (int i = 0; i < 100; i++)
                {
                    Random rd = new Random();               //generate random number
                    int rand_num = rd.Next(100, 20000);
                    Console.WriteLine(rand_num);
                    if (rand_num % 10 == 0)             //check if random number is a factor of 10
                    {
                        FactorOfTenDetected();          //raise event when factor of 10 detected
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
        protected virtual void FactorOfTenDetected()
        {
            NotifyOtherClasses?.Invoke();  //raise event
        }

    }

    public class CatchFactorOfTen   //subscriber
    {
        public void ActOnSeeingFactorOfTen()
        {
            var randPrinter = new RandomNumberPrinter();
            randPrinter.NotifyOtherClasses += FactorOfTenAlert;     //setting event equal to a method
            randPrinter.PrintRandomNumber();
        }



        public void FactorOfTenAlert()                          //action to take place upon event being invoked
        {
            Console.WriteLine("this number is a factor of 10 ");
            Console.ReadLine();
        }

    }
}
