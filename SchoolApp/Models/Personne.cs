using System.Runtime.Serialization;

namespace SchoolApp.Models
{
    [DataContract]
    internal abstract class Personne : Model
    {
        [DataMember(Name = "nom")]
        public string? Nom { get; set; }

        [DataMember(Name = "prenom")]
        public string? Prenom { get; set; }

    }

}
