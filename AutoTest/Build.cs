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
                        Test.Case_1();
                        break;
                    case "2":
                        Test.Case_2();
                        break;
                    case "3":
                        Test.Case_3();
                        break;
                    case "4":
                        Test.Case_4();
                        break;
                    case "5":
                        Test.Case_5();
                        break;
                    case "6":
                        Test.Case_6();
                        break;
                    case "7":
                        Test.Case_7();
                        break;
                    case "8":
                        Test.Case_8();
                        break;
                }
            }
        }
    }
}

