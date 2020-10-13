using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ScotYard
{
    public class Detective
    {
        public int position { get; set; }
        public Button btnTaxi { get; set; }
        public Button btnBus { get; set; }
        public Button btnMetro { get; set; }
        public int TicketBus { get; set; }
        public int TicketMetro { get; set; }
        public int TicketTaxi { get; set; }
        public Panel pnlDetective { get; set; }
        public bool bloque { get; set; }

        public Detective(Button btnTaxi, Button btnBus, Button btnMetro, int TicketTaxi, int TicketBus, int TicketMetro, Panel pnlDetective)
        {
            this.position = position;
            this.btnTaxi = btnTaxi;
            this.btnBus = btnBus;
            this.btnMetro = btnMetro;
            this.TicketTaxi = TicketTaxi;
            this.TicketBus = TicketBus;
            this.TicketMetro = TicketMetro;
            this.pnlDetective = pnlDetective;
        }
    }


}
