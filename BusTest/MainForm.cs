using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace BusTest
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        List<Bus> Buses = new();
        Graph Graph = new Graph();
        void Parse(string[] s)
        {
            int count = int.Parse(s[0]);
            if (count == 0) throw new Exception("Количество автобусов должно быть натуральным числом");
            Buses = new(count);
            int num = int.Parse(s[1]);
            StartNumeric.Maximum = num;
            EndNumeric.Maximum = num;
            string[] times = s[2].Split(' ');
            var prices = s[3].Split(' ').Select(i => int.Parse(i)).ToList();
            var stops = s.Skip(4).ToList();
            for (int i = 0; i < count; i++)
            {
                DateTime date = DateTime.ParseExact(times[i], "HH:mm", null);
                var tmp = stops[i].Split(' ');
                var b = new Bus()
                {
                    StartTime = date.Hour * 60 + date.Minute, Price = prices[i],
                    Stops = tmp.Skip(1).Take(int.Parse(tmp[0])).Select(x => int.Parse(x)).ToArray(),
                    Times = tmp.Skip(1 + int.Parse(tmp[0])).Select(x => int.Parse(x)).ToArray()
                };
                Buses.Add(b);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                try
                {
                    Parse(File.ReadAllLines(openFileDialog.FileName));
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Ошибка при парсинге данных\n", ex.Message);
                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Buses.Count == 0) return;
            Graph = new();
            DateTime tmp = DateTime.ParseExact(TimeTB.Text, "HH:mm", null);
            int StartTime = tmp.Hour * 60 + tmp.Minute;
            int StartStop = (int)StartNumeric.Value, FinalStop = (int)EndNumeric.Value;

            for (int i = 1; i < EndNumeric.Maximum + 1; i++)
                Graph.AddVertex(i);
            AddTimeEdge(StartStop, StartTime);

            var dijkstra = new Dijkstra(Graph).FindShortestPath(StartStop, FinalStop);
            if (dijkstra == "")
                FastestTB.Text = "Пути не существует";
            else
                FastestTB.Text = dijkstra.Replace("=", "\nВремя в пути: ");

            Graph = new();
            for (int i = 1; i < EndNumeric.Maximum + 1; i++)
                Graph.AddVertex(i);
            AddMoneyEdge(StartStop, StartTime);

            dijkstra = new Dijkstra(Graph).FindShortestPath(StartStop, FinalStop);
            if (dijkstra == "")
                CheapestTB.Text = "Пути не существует";
            else
                CheapestTB.Text = dijkstra.Replace("=", "\nСтоимость: ");
        }

        void AddTimeEdge(int stop, int time)
        {
            var list = Buses.Where(x => x.Stops.Contains(stop)).ToList();
            foreach (var x in list)
            {
                int nextstop = x.GetNextStop(stop);
                var tmp = Graph.Vertices.FirstOrDefault(y => y.Name == stop);

                int nexttime = x.GetTime(time, stop, nextstop);
                if (nexttime == -1) continue;
                if (tmp is not null 
                 && tmp.Edges.Any(y => (y.ConnectedVertex.Name == nextstop) && (y.EdgeWeight <= nexttime)))
                    return;
                Graph.AddEdge(stop, nextstop, nexttime);
                AddTimeEdge(nextstop, time + nexttime);
            }
        }
        void AddMoneyEdge(int stop, int time)
        {
            var list = Buses.Where(x => x.Stops.Contains(stop)).ToList();
            foreach (var x in list)
            {
                var tmp = Graph.Vertices.FirstOrDefault(y => y.Name == stop);
                List<int> temptime = new();
                foreach (var s in x.Stops)
                {
                    int tm = x.GetTime(time, stop, s);
                    if (tmp is not null && tmp.Edges.Any(y => y.ConnectedVertex.Name == s))
                        tm = -1;
                    temptime.Add(tm);
                    if (s != stop && tm != -1)
                        Graph.AddEdge(stop, s, x.Price);
                }
                for (int i = 0; i < x.Stops.Length; i++)
                {
                    if (x.Stops[i] != stop && temptime[i] != -1)
                        AddMoneyEdge(x.Stops[i], time + temptime[i]);
                }
            }
        }
    }
}
