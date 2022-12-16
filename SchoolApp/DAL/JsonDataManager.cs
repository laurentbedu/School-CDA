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

            return new List<T>();
        }
    }
}
