using Sort.Enum;
using System.Collections.Generic;

namespace Sort.Model
{
    public class DataList
    {
        public DataList()
        {
            Data = new();
        }
        public List<Data> Data { get; set; }

        public void Add(Data data)
        {
            if (string.IsNullOrEmpty(data?.Value))
            {
                return;
            }
            Data.Add(data);
        }
    }

    public class Data
    {
        public Data(string val)
        {
            DataType = DetermineDataType(val);
            Value = val;
        }

        public DataType DataType { get; }
        public string Value { get; }

        private static DataType DetermineDataType(string val)
        {
            if (double.TryParse(val, out var _))
            {
                return DataType.Numeric;
            }
            return DataType.String;
        }
    }
}
