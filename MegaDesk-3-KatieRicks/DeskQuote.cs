using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_3_KatieRicks
{
    class DeskQuote
    {
        //constants
        const decimal = ;
        const decimal = ;
        const decimal = ;
        const decimal = ;
        const decimal = ;
        const decimal = ;
        const decimal = ;

        //enums
        public enum Delivery
        {
            Rush3Days,
            Rush5Days,
            Rush7Days,
            Normal14Days
        }

        //properties
        public Desk desk { get; set; }
        public string customerName { get; set; }
        public DateTime QuoteDate { get; set; }
        public Delivery DeliveryType { get; set; }
        public decimal QuoteAmount { get; set; }

        // methods
        public void priceQuote ()
        {

        }
    }
}
