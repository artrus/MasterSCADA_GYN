using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoskosmosHelper
{
    public partial class Gyn : Form
    {
        ILogger logger = null;
        public Gyn()
        {
            InitializeComponent();
        }

        private void Button_Open_Click(object sender, EventArgs e)
        {
            var path = OpenInputFile("Excel");
            TextBox_InputFile.Text = path;
            var reader = new ReadExcelInputFile("Output", new int[] { 1, 3, 4, 7 });
            reader.AddLogger(logger);
            var objects = reader.OpenFile(path);
        }

        private static string OpenInputFile(string typeFile)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    FileName = typeFile + ".xls",
                    Filter = "Excel files|*.xls;*.xlsx;*.xlsm",
                    FilterIndex = 0,
                    RestoreDirectory = true
                };
                DialogResult dialogResult = openFileDialog.ShowDialog();
                if (dialogResult == DialogResult.OK)
                    return openFileDialog.FileName;
                else
                    return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка открытия фаила " + typeFile, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void Gyn_Load(object sender, EventArgs e)
        {
            logger = new LoggerToRichBox(RichTextBox_Log);
        }
    }
}
