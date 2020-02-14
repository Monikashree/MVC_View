using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainTicketBookingMVC.Entity;

namespace TrainTicketBookingMVC.DAL
{
    public class TrainRepository
    {
        public static List<Train> trainlist = new List<Train>();
        static TrainRepository()
        {
            trainlist.Add(new Train { TrainNo = 12345, TrainName = "Chennai Express" });
        }
        public static IEnumerable<Train> GetTrainDetails()
        {
            return trainlist;
        }
    }
}
