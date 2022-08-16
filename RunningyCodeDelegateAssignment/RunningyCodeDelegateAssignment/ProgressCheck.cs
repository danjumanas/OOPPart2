using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunningyCodeDelegateAssignment
{
    internal class ProgressCheck
    {
        public delegate void HowFar(int percentDone);
        public static void FileUploader(HowFar howFarIn)
        {
            try
            {
                for (int i = 0; i < 100; i++)
                {
                    var markedUpload = i.ToString();
                    if (i % 10 == 0)                        //check if number is a factor of 10
                    {
                        howFarIn(i);
                    }

                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
