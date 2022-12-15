using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyvanAddin1
{

    public unsafe partial class Settings : Form
    {
        public ExportSetting exportSetting = new ExportSetting();
        FolderBrowserDialog fbd;
        public Settings()
        {
            InitializeComponent();

            ColumnsContainer.SelectedIndex = 0;
            ColumnsSeparator.SelectedIndex = 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                CurrentFileDirectory.Text = fbd.SelectedPath;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.exportSetting = new ExportSetting()
            {
                FileDirectory = fbd.SelectedPath,
                FileName = FileName.Text,
                StartText = StartText.Text,
                EndText = EndText.Text,
                ColumnsContainer = ColumnsContainer.SelectedItem.ToString(),
                ColumnsSeparator = ColumnsSeparator.SelectedItem.ToString()
            };

            this.Close();
        }
    }
}
