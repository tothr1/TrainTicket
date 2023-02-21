using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data.Entity;
using System.Diagnostics;

namespace TrainTicket.Model
{
    public class Connection
    {
        private SQLiteConnection conn;

        public Connection()
        {
            conn = new SQLiteConnection("\r\nData Source=D:\\PE\\22_23_2\\csharp\\TrainTicket\\TrainTicket\\data\\database.db;Version=3;\r\n");
            
        }

        public List<Train> GetTrains()
        {
            List<Train> tempTrains = new List<Train>();
            conn.Open();
            SQLiteCommand cmd = new SQLiteCommand(conn);
            cmd.CommandText = "SELECT * FROM train";
            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                tempTrains.Add(new Train(
                    reader.GetInt32(0),
                    reader.GetString(1)
                    )
                );
            }
            return tempTrains;
        }

        public void GetStations(int train)
        {
            conn.Open();
            SQLiteCommand cmd = new SQLiteCommand(conn);
            cmd.CommandText = "SELECT * FROM station";
            SQLiteDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Debug.WriteLine(rdr.GetString(1));
            }
            //return new LinkedList<string>();
        }

        public static List<Seat> GetSeats(int train)
        {
            return new List<Seat>();
        }
    }
}
