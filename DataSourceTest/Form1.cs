using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataSetSample.DataTableSample.AddDataTableSampleRow("あいう", 123, DateTime.Now);
            dataSetSample.DataTableSample.AddDataTableSampleRow("ABC", 456, DateTime.Now);
            dataSetSample.DataTableSample.AddDataTableSampleRow("えお", 0, DateTime.Now);
            dataSetSample.DataTableSample.AddDataTableSampleRow("DEF", -5, DateTime.Now);
            dataSetSample.DataTableSample.AddDataTableSampleRow("かきく", 99, DateTime.Now);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataSetSample.DataTableSample.AddDataTableSampleRow("くけこ", 987, DateTime.Now);
        }

    }
}
