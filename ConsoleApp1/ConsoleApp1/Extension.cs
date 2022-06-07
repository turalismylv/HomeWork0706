using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    static class Extension
    {
        
       
        
            public static int[] Add(this int[] arr, int num)
            {
                Array.Resize(ref arr, arr.Length + 1);
                arr[arr.Length - 1] = num;
                return arr;
            }


        }

    }


