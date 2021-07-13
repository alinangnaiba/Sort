using Sort.Model;
using System.Collections.Generic;

namespace Sort.View
{
    public interface ISortView : IView
    {
        public DataList GetDataList();
        public void Display(IEnumerable<Data> data);
    }
}
