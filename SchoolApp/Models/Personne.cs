using SchoolApp.Attributes;

namespace SchoolApp.Models
{
    internal class Personne
    {
        public Personne()
        {
            Id = Tools.IdGenerator.Create(this);
        }
        public string Id { get; private set; }
        public string? Nom { get; set; }
        public string? Prenom { get; set; }

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
