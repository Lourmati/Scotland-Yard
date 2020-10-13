using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScotYard
{
    public class Voleur
    {
        public int position { get; set; }
        public int TicketBus { get; set; }
        public int TicketMetro { get; set; }
        public int TicketTaxi { get; set; }
        public int TicketBlack { get; set; }

        public Voleur(int TicketTaxi, int TicketBus, int TicketMetro, int TicketBlack)
        {      
            this.TicketTaxi = TicketTaxi;
            this.TicketBus = TicketBus;
            this.TicketMetro = TicketMetro;
            this.TicketBlack = TicketBlack;
        }
    }
}
