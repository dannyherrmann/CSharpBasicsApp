using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicsConsole
{
    //class = a blueprint to represent something in your application
    //all code in a class will be related
    public class UserInput
    {
        public string Name { get; set; }
        public string Day { get; set; }
        public string Subject { get; set; }

        public override string ToString()
        {
            return @$"
Name: {Name}
Favorite Day of the Week: {Day}
Least Favorite School Subject: {Subject}";
        }
    }
}
