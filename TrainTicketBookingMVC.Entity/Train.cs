
using System.ComponentModel.DataAnnotations;


namespace TrainTicketBookingMVC.Entity
{
    public class Train
    {
        public int TrainNo { get; set; }
        [Required]
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
