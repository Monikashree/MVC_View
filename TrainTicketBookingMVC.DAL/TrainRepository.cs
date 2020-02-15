using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
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
        public IEnumerable<Train> GetTrainDetails()
        {
            return trainlist;
        }
        public void AddDetails(Train train)
        {
            trainlist.Add(train);
        }
        public Train GetDetailsById(int trainId)
        {
            return trainlist.Find(id => id.TrainNo == trainId);
        }
        public void DeleteDetails(int trainId)
        {
            Train train = GetDetailsById(trainId);
            if (train != null)
                trainlist.Remove(train);
        }
        public void UpdateDetails(Train train)
        {
            //Train trains = train.Find(id => id.TrainNo == train.TrainNo);
            Train trains = GetDetailsById(train.TrainNo);
            trains.TrainName = train.TrainName;           
        }

        
    }
}
