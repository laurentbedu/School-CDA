using SchoolApp.Attributes;
using System.Runtime.Serialization;

namespace SchoolApp.Models
{
    [DataContract]
    internal class Niveau : Model
    {

        [DataMember(Name = "label")]
        public string Label { get; set; }

        [IsNotInToString]
        public List<Matiere> MatiereList { get; private set; } = new List<Matiere>();

        public void AddMatieres(params Matiere[] matieres)
        {
            MatiereList.AddRange(matieres);
            foreach (Matiere matiere in matieres)
            {
                if (!matiere.NiveauList.Contains(this))
                {
                    matiere.AddNiveaux(this);
                }
            }
        }

        public void RemoveMatieres(params Matiere[] matieres)
        {
            MatiereList.RemoveAll(e => matieres.Contains(e));
            foreach (Matiere matiere in matieres)
            {
                if (matiere.NiveauList.Contains(this))
                {
                    matiere.RemoveNiveaux(this);
                }
            }
        }

        public override string ToString()
        {
            return Label;
        }
    }
}
