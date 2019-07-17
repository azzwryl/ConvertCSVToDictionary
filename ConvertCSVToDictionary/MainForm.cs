using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertCSVToHashTable
{
    public partial class ConvertCSVToDictionary : Form
    {
        public ConvertCSVToDictionary()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PreviewButton_Click(object sender, EventArgs e)
        {
            CarListView.Items.Clear();

            using (TextFieldParser parser = new TextFieldParser(@FilePathTextBox.Text))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");

                string[] headerLine = parser.ReadFields();

                while (!parser.EndOfData)
                {
                    string[] row = parser.ReadFields();

                    ListViewItem item = new ListViewItem(row[0].ToString());
                        item.SubItems.Add(row[1].ToString());
                        item.SubItems.Add(row[2].ToString());

                    CarListView.Items.Add(item);
                }
            }
           
        }

        private void ImportButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                RestoreDirectory = true,
                Filter = "CSV files (*.csv) | *.csv"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FilePathTextBox.Text = ofd.FileName;
            }
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            CreateDictionary(FilePathTextBox.Text.ToString());
        }

        private void CreateDictionary(string filePath)
        {
            var carMakeDictionary = new Dictionary<int, string>();
            var carModelDictionary = new Dictionary<string, string>();
            var carYearDictionary = new Dictionary<string, string>();

            using (StreamReader reader = new StreamReader(filePath))
            {
                string headerLine = reader.ReadLine();

                string line;
                int carMakeIndex = 0;

                while ((line = reader.ReadLine()) != null )
                {
                    string[] row = line.Split(',');
                    if (!carMakeDictionary.ContainsValue(row[0]))
                    {
                        carMakeDictionary.Add(carMakeIndex, row[0]);
                        carMakeIndex++;
                    }

                    if (!carModelDictionary.ContainsKey(row[1]))
                    {
                        carModelDictionary.Add(row[1], row[0]);
                    }
                }
            }


            var make = carMakeDictionary.Select(kvp => kvp.Key + " : " + kvp.Value.ToString());
            MakeDictionaryTextBox.Text = string.Join(Environment.NewLine, make);

            var model = carModelDictionary.Select(kvp => kvp.Key + " : " + kvp.Value.ToString());
            ModelDictionaryTextBox.Text = string.Join(Environment.NewLine, model);

            return;
        }
    }
}
