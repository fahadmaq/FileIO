using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileIO_Student
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btWrite_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\DP4\Student.dat";
                FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.Write);
                BinaryWriter binaryWriter = new BinaryWriter(fileStream);
                binaryWriter.Write(Convert.ToInt32(txRollNo.Text));
                binaryWriter.Write(txName.Text);
                binaryWriter.Write(Convert.ToDouble(txPercentage.Text));
                binaryWriter.Close();
                fileStream.Close();
                MessageBox.Show("Student added sucessfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btRead_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\DP4\Student.dat";
                FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
                BinaryReader binaryReader = new BinaryReader(fileStream);
                txRollNo.Text = binaryReader.ReadInt32().ToString();
                txName.Text = binaryReader.ReadString();
                txPercentage.Text = binaryReader.ReadDouble().ToString();
                binaryReader.Close();
                fileStream.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
