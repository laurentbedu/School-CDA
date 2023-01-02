using SchoolApp.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.Models
{
    internal abstract class Model
    {
        public Model()
        {
            Id = Tools.IdGenerator.Create(this);
        }
        public string Id { get; private set; }

        public override string ToString()
        {
            string desc = GetType() + " {\r\n";
            GetType().GetProperties()
                .Where(p => !Attribute.IsDefined(p, typeof(IsNotInToStringAttribute)))
                .ToList()
                .ForEach(p => desc += p.Name + ":" + GetType().GetProperty(p.Name)?.GetValue(this) + "\r\n");
            return desc + "}";
        }

        public string ToString(bool withRelations)
        {
            string desc = GetType() + " {\r\n";
            GetType().GetProperties()
                .ToList()
                .ForEach(p => desc += p.Name + ":" + GetType().GetProperty(p.Name)?.GetValue(this) + "\r\n");
            return desc + "}";
        }
    }
}