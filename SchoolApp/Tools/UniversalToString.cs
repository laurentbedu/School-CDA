using SchoolApp.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.Tools
{
    internal class UniversalToString
    {
        public static string ToStringer(object pourAffichage)
        {
            string desc = "";
            pourAffichage.GetType().GetProperties()
                .Where(p => !Attribute.IsDefined(p, typeof(NePasIntegrerDansToStringAttribute)))
                .ToList()
                .ForEach(p => desc += p.Name + ":" + pourAffichage.GetType().GetProperty(p.Name)?.GetValue(pourAffichage) + "\r\n");
            return desc;
        }
    }
}
