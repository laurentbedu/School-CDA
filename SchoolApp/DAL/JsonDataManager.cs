using SchoolApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SchoolApp.DAL
{
    internal class JsonDataManager<T> where T : Models.Model
    {
        private List<T> dataList = new List<T>();

        public List<T> DataList
        {
            get
            {
                if (dataList == null)
                {
                    dataList = LoadJsonData();

                }
                return dataList;
            }
        }

        private List<T> LoadJsonData()
        {
            string fileName = "C:\\Users\\Nicolas\\source\\repos\\laurentbedu\\School-CDA\\SchoolApp\\Json\\niveau.json";
            string jsonString = File.ReadAllText(fileName);
            Niveau niveaux = JsonSerializer.Deserialize<Niveau>(jsonString)!;

            MessageBox.Show($"id: {niveaux.id}");
            MessageBox.Show($"nom: {niveaux.label}");

            return new List<T>();
        }
    }
}
