using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1DelsAndCallbacks
{
    internal class DelegateCreation
    {
        public delegate bool deleg(XClass x);           //delegate deleg is created and takes a class type as parameter and returns bool
        public void Call()
        {
            TClass tClass = new TClass();                   //instantiating tclass so that we can assign values to properties
            tClass.FirstName = "Nasiru";
            tClass.LastName = "Danjuma";
            var likelyUsername = tClass.FirstName + "." + tClass.LastName;      //string concatenation

            deleg delegg = x => x.UserName == likelyUsername;       //using callbacks to create anonymous methods 
        }
    }

    public class XClass                         //xclass creation
    {
        public string UserName { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
    }

    public class TClass                         //tclass creation
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
    }
}
