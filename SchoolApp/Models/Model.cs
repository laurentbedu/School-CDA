using SchoolApp.Attributes;
using System.Runtime.Serialization;

namespace SchoolApp.Models
{
    [DataContract]
    internal abstract class Model
    {
        public Model()
        {
            Id = Tools.IdGenerator.Create(this);
        }

        [DataMember(Name = "id")]
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
