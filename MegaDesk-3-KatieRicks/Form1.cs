using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_3_KatieRicks
{
    public partial class MegaDesk : Form
    {
        public MegaDesk()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddNewQuote addNewQuoteForm = new AddNewQuote();
            addNewQuoteForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DisplayQuotes addDisplayQuotes = new DisplayQuotes();
            addDisplayQuotes.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ViewAllQuotes addViewAllQuotes = new ViewAllQuotes();
            addViewAllQuotes.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SearchQuotes addSearchQuotes = new SearchQuotes();
            addSearchQuotes.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
