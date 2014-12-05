using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SinlgetonLibrary
{
    public class Library
    {

        private Library()
        {
            // private constructor
        }
        
        private static readonly Library instance = new Library();

        public static Library Instance
        {
            get { return instance; }
        }





        
    }
}