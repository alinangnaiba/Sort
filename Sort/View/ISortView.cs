using Sort.Model;
using System.Collections.Generic;

namespace Sort.View
{
    public interface ISortView : IView
    {
        DataList GetDataList();
        void Display(IEnumerable<Data> data);
    }
}
