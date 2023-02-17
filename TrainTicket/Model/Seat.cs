using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainTicket.Model
{
    public class Seat
    {
        public string name;
        public string status;

        public Seat(string name, string status)
        {
            this.name = name;
            this.status = status;
        }

        public void changeStatus(string newStatus)
        {
            if(newStatus != this.status)
            {
                this.status = newStatus;
            }
            else
            {
                throw new Exception($"Can not change status to {newStatus}");
            }
        }
    }
}
