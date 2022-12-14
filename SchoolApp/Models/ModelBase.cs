using SchoolApp.Attributes;
using SchoolApp.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.Models
{
    internal class ModelBase
    {
        public ModelBase()
        {
            Id = IdGenerator.Create(this);
        }

        public string Id { get; set; }


        public override string ToString()
        {
            string desc = "";
            GetType().GetProperties()
                .Where(p => !Attribute.IsDefined(p, typeof(IsNotInToStringAttribute)))
                .ToList()
                .ForEach(p => desc += p.Name + ":" + GetType().GetProperty(p.Name)?.GetValue(this) + "\r\n");

            return desc;
        }
    }
}
