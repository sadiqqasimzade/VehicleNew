using System;
using System.Collections.Generic;
using System.Text;

namespace Tasdk.Models
{
    static class Extentions
    {
        public static void ShowInfo(this Object obj)
        {
            foreach (var prop in obj.GetType().GetProperties())
                Console.WriteLine(prop.Name + ":" + prop.GetValue(obj));
            
        }
    }
}
