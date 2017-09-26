using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListHandlerLib
{
    public class ListHandler
    {
        public List<string> List = new List<string>();

        public void AddFiveStrings()
        {
            List.Add("Hej");
            List.Add("Hej");
            List.Add("Hej");
            List.Add("Hej");
            List.Add("Hej");
        }

        public void RemoveThirdString()
        {
            List.RemoveAt(2);
        }

        public void Sort()
        {
            List.Sort();
        }
    }
}