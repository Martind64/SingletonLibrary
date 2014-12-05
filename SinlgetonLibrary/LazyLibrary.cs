using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinlgetonLibrary
{
    public class LazyLibrary
    {

        private LazyLibrary()
        {
            // Private contructor
        }


        private static LazyLibrary _instance = new LazyLibrary();
 
        public static LazyLibrary Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new LazyLibrary();
                }
                return _instance;

            }
        }



    }
}
