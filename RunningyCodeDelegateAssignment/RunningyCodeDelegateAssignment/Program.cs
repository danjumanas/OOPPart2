using System;

namespace RunningyCodeDelegateAssignment
{
    internal class Program
    {

        static void Main(string[] args)
        {
            ProgressCheck.FileUploader(ShowProgress);
        }

        public static void ShowProgress(int howFarIn)           //method to be passed as parameter. it has same signature as delegate HowFar
        {
            Console.WriteLine($"so far {howFarIn} done");
        }
    }
}
