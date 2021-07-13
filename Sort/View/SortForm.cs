using Sort.Controller;
using Sort.Model;
using Sort.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sort
{
    public partial class SortForm : Form, ISortView
    {
        private DataList _dataList;
        private SortController _sortController;

        public SortForm()
        {
            InitializeComponent();
            _sortController = new SortController(this);
        }

        public DataList GetDataList()
        {
            return _dataList;
        }

        public void Display(IEnumerable<Data> dataList)
        {
            output.TextAlign = HorizontalAlignment.Left;
            var text = "============ Sort Ascending Result============\r\n";
            var ctr = 1;
            foreach(var data in dataList)
            {
                text += $"{ctr}.\t{data.Value}\r\n";
                ctr++;
            }
            text += "=======================================";
            output.Text = text;
        }

        public void Display()
        {
            output.TextAlign = HorizontalAlignment.Center;
            output.Text = "No input value";
        }

        public void DisplayError(string message)
        {
            output.TextAlign = HorizontalAlignment.Left;
            output.Text = message;
        }

        private void SetDataList()
        {
            _dataList = new DataList();
            _dataList.Add(new Data(input1.Text));
            _dataList.Add(new Data(input2.Text));
            _dataList.Add(new Data(input3.Text));
            _dataList.Add(new Data(input4.Text));
            _dataList.Add(new Data(input5.Text));
        }

        private void sort_Click(object sender, EventArgs e)
        {
            SetDataList();
            _sortController.Sort();
        }
    }
}
