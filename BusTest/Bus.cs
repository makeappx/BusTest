using System.Linq;

namespace BusTest
{
    struct Bus
    {
        public int Price { get; set; }
        public int StartTime { get; set; }
        public int[] Stops { get; set; }
        public int[] Times { get; set; }
        public int GetTime(int currenttime, int start, int destination)
        {
            if (!Stops.Contains(destination) || !Stops.Contains(start)) return -1;
            int time = StartTime;
            int idx = Stops.ToList().IndexOf(destination);
            int count = Stops.Length;
            bool visited = false;
            for (int i = 0; time < 1440 && (!visited || i % count != idx || currenttime > time); i++)
            {
                if (Stops[i % count] == start && time >= currenttime)
                    visited = true;
                time += Times[i % count];
            }
            if (time >= 1440) return -1;
            return time - currenttime;
        }
        public int GetNextStop(int current) => Stops[(Stops.ToList().IndexOf(current) + 1) % Stops.Length];
    }   
}