using SchoolApp.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SchoolApp.Models
{
    internal class Model
    {
        // Propriétés :
        [JsonPropertyName("id")] public string Id { get; set; }

        // Constructeurs :
        public Model()
        {
            Id = Tools.IdGenerator.generateId(this);
        }
        
        // Override ToString :
        public override string ToString()
        {
            string desc = GetType() + " {\r\n";
            GetType().GetProperties()
                .Where(p => !Attribute.IsDefined(p, typeof(NePasIntegrerDansToStringAttribute)))
                .ToList()
                .ForEach(p => desc += p.Name + ":" + GetType().GetProperty(p.Name)?.GetValue(this) + "\r\n");
            return desc + "}";
        }
        // Methodes :
        public string ToString(bool withRelations)
        {
            string desc = GetType() + " {\r\n";
            GetType().GetProperties()
                .ToList()
                .ForEach(p => desc += p.Name + ":" + GetType().GetProperty(p.Name)?.GetValue(this) + "\r\n");
            return desc + "}";
        }   // Version ToString qui affiche la totalité même les taggé NePasIntégrer
    }
}
