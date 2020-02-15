using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainTicketBookingMVC.Entity
{
    public class Train
    {
        public int TrainNo { get; set; }
        public string TrainName { get; set; }
        public Train(int TrainNo, string TrainName)
        {
            TrainNo = this.TrainNo;
            TrainName = this.TrainName;
        }
        public Train()
        {

        }
    }
    
}
