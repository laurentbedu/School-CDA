using System.Text.Json;


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
        public void SaveJSonData()
        {
            string nomClasseT = typeof(T).Name;
            string cheminRoot = Directory.GetCurrentDirectory();
            cheminRoot = cheminRoot.Remove(cheminRoot.Length - 25) + "\\JSON\\";
            string cheminFichierExporter = cheminRoot + nomClasseT + ".json";
            string jsonString = JsonSerializer.Serialize(dataList)!;
            //MessageBox.Show(jsonString);            
            File.WriteAllText(cheminFichierExporter, jsonString);
        }

        public List<T> GetWhere(Predicate<T>? filter = null)
        {
            return filter != null ? DataList.FindAll(filter) : DataList;
        }

        public T? GetById(string? id)
        {
            List<T> list = GetWhere(item => item.Id == id);
            return id != null && list.Count == 1 ? GetWhere(item => item.Id == id).First() : null;
        }
    }
}