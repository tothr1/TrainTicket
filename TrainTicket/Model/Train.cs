using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainTicket.Model
{
    public class Train
    {
        private int id;
        private string trainType;
        private List<Seat> seats;
        private LinkedList<string> stations;

        public Train(int id, string type)
        {
            this.id = id;
            trainType = type;
            //seats = Connection.GetSeats(id);
            //stations = Connection.GetStations(id);
        }
       
    }

}
