using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp
{
    internal class IdGenerator
    {
        public static string Create(object obj)
        {
            Guid guid = Guid.NewGuid();
            return guid.ToString();
        }
    }
}
