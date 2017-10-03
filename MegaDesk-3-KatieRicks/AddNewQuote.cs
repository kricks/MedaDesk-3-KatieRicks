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
    public partial class AddNewQuote : Form
    {
        public AddNewQuote()
        {
            InitializeComponent();
        }

        private void AddNewQuote_Load(object sender, EventArgs e)
        {
            Desk desk = new Desk();
            
            switch (material.Text)
            {
                case "Oak":
                    desk.material = Desk.deskMaterial.Oak
                    break;
                case "Laminate":
                desk.material = Desk.deskMaterial.Laminate
                    break;
                case "Pine":
                desk.material = Desk.deskMaterial.Pine
                    break;
                case "Rosewood":
                desk.material = Desk.deskMaterial.Rosewood
                    break;
                case "Veneer":
                    desk.material = Desk.deskMaterial.Veneer
                    break;
            }

            DeskQuote quote = new DeskQuote();

            quote.customerName = customerNameForm.Text;
                quote.desk = desk;

            switch (orderSpeed.Text)
            {
                case "Three Days":
                    quote.DeliveryType= DeskQuote.Delivery.Rush3Days
                    break;
                case "Five Days":
                    quote.DeliveryType = DeskQuote.Delivery.Rush5Days
                    break;
                case "Seven Days":
                    quote.DeliveryType = DeskQuote.Delivery.Rush7Days
                    break;
                case "Normal - Fourteen Days":
                    quote.DeliveryType = DeskQuote.Delivery.Normal14Days
                    break;
            }
        }

        //create method in desk qupte to get price quote. 
        //create method and call it to calculate price
        // store result in desk quote
        //display
        //search --- use combo box

        private void button1_Click_1(object sender, EventArgs e)
        {
            DisplayQuotes addDisplayQuotes = new DisplayQuotes();
            addDisplayQuotes.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MegaDesk addMegaDesk = new MegaDesk();
            addMegaDesk.Show();
            this.Hide();
        }

    }
}

