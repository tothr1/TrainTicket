using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainTicket.Model;

namespace TrainTicket.Controller
{
    internal static class TrainController
    {
        public static List<Train> trains;

        static TrainController()
        {
            Connection dbConn = new Connection();
            trains = dbConn.GetTrains();
        }
    }
}
