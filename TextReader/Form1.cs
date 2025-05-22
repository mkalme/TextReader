using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Xml;

namespace TextReader
{
    public partial class Form1 : Form
    {
        private static string BasePath = "";
        private static string FilePath = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] args = Environment.GetCommandLineArgs();

            if (args.Length > 1) {
                BasePath = args[1].Split('\n')[0];
                FilePath = args[1].Split('\n')[1];

                read();
            }
        }

        private void read() {
            XmlDocument document = new XmlDocument();
            document.Load(BasePath);

            richTextBox1.Text = document.SelectSingleNode(FilePath + "/text").InnerText;
        }
    }
}
