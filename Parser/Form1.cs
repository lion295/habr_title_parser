
//using Parser.Core.Freelansim;
using Parser.Core;
using Parser.Core.Habr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Parser
{
    public partial class ParserForm : System.Windows.Forms.Form
    {
        ParserWorker<string[]> parser_habr;


        public ParserForm()
        {
            InitializeComponent();
            parser_habr = new ParserWorker<string[]>(new HabrParser());
            parser_habr.OnComplited += Parser_OnComplited;
            parser_habr.OnNewData += Parser_OnNewData;

        }

        public void Parser_OnComplited(object o)
            {
            MessageBox.Show("Работа завершена");
            }
        public void Parser_OnNewData(object o, string[] str) { ListTitles.Items.AddRange(str); }



        private void ParserForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonHabr_Click(object sender, EventArgs e)
        {
            parser_habr.Settings = new HabrSettings((int)numericUpDownStart.Value, (int)numericUpDownEnd.Value);
            parser_habr.Start();


        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ListTitles.Items.Clear();

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            parser_habr.Stop();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
