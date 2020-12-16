using AutoTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Context
{
    class Build
    {
        public static void buildAutoTest(string path)
        {
            var states = path.Split(' ').ToList();
            foreach (var step in states)
            {
                switch (step)
                {
                    case "1":
                        Test.Test_2();
                        break;
                    case "2":
                        Test.Test_3();
                        break;
                    case "3":
                        Test.Test_4();
                        break;
                    case "4":
                        Test.Test_5();
                        break;
                }
            }
        }
    }
}

