using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schumacher
{
    internal class Sumi
    {
        DateTime date;
        string grandprix;
        int position;
        int laps;
        int points;
        string team;
        string status;

        public DateTime Date { 
            get => date;
            set => date = value; }
        public string Grandprix { get => grandprix; set => grandprix = value; }
        public int Position { get => position; set => position = value; }
        public int Laps { get => laps; set => laps = value; }
        public int Points { get => points; set => points = value; }
        public string Team { get => team; set => team = value; }
        public string Status { get => status; set => status = value; }

        public Sumi(DateTime date, string grandprix, int position, int laps, int points, string team, string status)
        {
            Date = date;
            Grandprix = grandprix;
            Position = position;
            Laps = laps;
            Points = points;
            Team = team;
            Status = status;
        }

        public Sumi(string beolvasottsor)
        {
            string[] strings = beolvasottsor.Split(';');
            Date = DateTime.Parse(strings[0]);
            Grandprix = strings[1];
            Position = int.Parse(strings[2]);
            Laps = int.Parse(strings[3]);
            Points = int.Parse(strings[4]);
            Team = strings[5];
            Status = strings[6];
        }
    }
}
