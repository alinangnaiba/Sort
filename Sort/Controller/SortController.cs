using Sort.Enum;
using Sort.Model;
using Sort.View;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sort.Controller
{
    public class SortController
    {
        private readonly ISortView _form;
        public SortController(ISortView form)
        {
            _form = form;
        }

        public void Sort()
        {
            try
            {
                var numericData = _form.GetDataList().Data
                .Where(x => !string.IsNullOrEmpty(x.Value) && x.DataType == DataType.Numeric)
                .OrderBy(x => double.Parse(x.Value));
                var stringData = _form.GetDataList().Data
                    .Where(x => !string.IsNullOrEmpty(x.Value) && x.DataType == DataType.String)
                    .OrderBy(x => x.Value);
                var dataList = new List<Data>();
                if (numericData.Any())
                {
                    dataList.AddRange(numericData);
                }
                if (stringData.Any())
                {
                    dataList.AddRange(stringData);
                }
                
                if (!dataList.Any())
                {
                    _form.Display();
                    return;
                }

                _form.Display(dataList);
            }
            catch (Exception e)
            {
                _form.DisplayError(e.Message);
            }
        }
    }
}
