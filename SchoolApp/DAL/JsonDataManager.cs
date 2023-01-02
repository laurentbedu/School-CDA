using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SchoolApp.DAL
{
    internal class JsonDataManager<Niveau> where Niveau : Models.Model
    {


        public List<Niveau> dataList

        {
            get
            {
                if (dataList == null)
                {
                    dataList = LoadJsonData();

                }
                return dataList;
            }
            set
            { }
        }

        private List<Niveau> LoadJsonData()
        {
            String jsonString = File.ReadAllText("C:\\Users\\xseb\\source\\repos\\School - CDA\\SchoolApp\\MOCK_DATA.json");

            dataList = JsonSerializer.Deserialize<List<Niveau>>(jsonString);

            return new List<Niveau>();
        }
    }
}
