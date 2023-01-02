using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolApp.DAL
{
    internal class JsonDataManager<T> where T : Models.Model
    {

        private List<T>? dataList;
        public List<T> DataList 
        {
            get
            {
                if (dataList==null)
                {
                    dataList = LoadJSonData();
                }
            return dataList;
            }
        }
        private List<T> LoadJSonData()
        {
            string nomClasseT = typeof(T).Name;
            string cheminRoot = Directory.GetCurrentDirectory();
            cheminRoot = cheminRoot.Remove(cheminRoot.Length - 25) + "\\JSON\\";
            string cheminFichierImporter = cheminRoot + nomClasseT + ".json";
            //string cheminFichierImporter = Path.Combine(Directory.GetCurrentDirectory(), "\\JSON\\" + nomClasseT + ".json");
            string jsonString = File.ReadAllText(cheminFichierImporter);
            List<T> data = JsonSerializer.Deserialize<List<T>>(jsonString)!;
            return data;
        }
        public void SaveJSonData(List<T> dataListSave)
        {
            string nomClasseT = typeof(T).Name;
            string cheminRoot = Directory.GetCurrentDirectory();
            cheminRoot = cheminRoot.Remove(cheminRoot.Length - 25) + "\\JSON\\";
            string cheminFichierExporter = cheminRoot + nomClasseT + ".json";
            string jsonString = JsonSerializer.Serialize(dataListSave)!;

            //MessageBox.Show(jsonString);            
            File.WriteAllText(cheminFichierExporter, jsonString);
        }
    }
}