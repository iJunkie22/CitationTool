using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Manager
    {
        private int citationStyle, mediumReference;

        public void storeFirst(int x, int y){
            citationStyle = x;
            mediumReference = y;
        }
    }
}
