using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using System.Diagnostics;

namespace Homework_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Random r = new Random(1);

            List<int> collisions = BirthdayParadox(r, 1, 4000);
            Console.WriteLine("Part 1A:\t" + collisions.First());

            Stopwatch s = new Stopwatch();
            s.Start();
            List<int> collisions2 = BirthdayParadox(r, 300, 4000);
            s.Stop();
            long time = s.ElapsedMilliseconds;
            s.Reset();

            Console.WriteLine("Part 1C:\t" + collisions2.Average());
            Console.WriteLine("Part 1D (how long it took for 300 trials):\t" + time + " Milliseconds");

            s.Start();
            List<int> collisions3 = BirthdayParadox(r, 1000, 50000);
            s.Stop();
            time = s.ElapsedMilliseconds;
            Console.WriteLine((Convert.ToDouble(time) / 1000) + " Seconds");
            s.Reset();


            s.Start();
            List<int> collisions4 = BirthdayParadox(r, 10000, 1000000);
            s.Stop();
            time = s.ElapsedMilliseconds;
            Console.WriteLine((Convert.ToDouble(time) / 1000) + " Seconds");
            s.Reset();




            #region Chart
            Chart chart = new Chart();
            chart.Series.Clear();
            chart.Size = new System.Drawing.Size(960, 480);
            chart.ChartAreas.Add("ChartedAreas");
            chart.ChartAreas["ChartedAreas"].AxisX.Minimum = 6;
            chart.ChartAreas["ChartedAreas"].AxisX.Maximum = 252;
            chart.ChartAreas["ChartedAreas"].AxisY.Minimum = 0;
            chart.ChartAreas["ChartedAreas"].AxisY.Maximum = 1;
            chart.ChartAreas["ChartedAreas"].AxisX.Interval = 10;
            chart.ChartAreas["ChartedAreas"].AxisY.Interval = 0.25;
            chart.Legends.Add("Legend1");
            chart = GenerateChart(chart, collisions2, "Part 1");
            chart.SaveImage("Chart.png", ChartImageFormat.Png);
            #endregion

            Console.ReadKey(false);
        }



        public static List<int> BirthdayParadox(Random r, int m, int n)
        {
            List<int> collisions = new List<int>();

            for (int i = 0; i < m; i++)
            {
                bool collision = false;
                List<int> values = new List<int>();
                while (!collision)
                {
                    int temp = r.Next(0, n);
                    if (values.Contains(temp))
                    {
                        collision = true;
                    }
                    values.Add(temp);
                } 
                collisions.Add(values.Count);
            }
            return collisions;

        }


        static Chart GenerateChart(Chart chart, List<int> part1, string seriesName)
        {
            List<int> ordered_part1 = part1.OrderBy(x => x).ToList();
            chart.Series.Add(seriesName);
            chart.Series[seriesName].ChartType = SeriesChartType.Spline;

            chart.Series[seriesName].XValueType = ChartValueType.Int32; //the epoch ID
            chart.Series[seriesName].YValueType = ChartValueType.Double; //Development set Acuracy
            foreach (var item in ordered_part1)
            {
                chart.Series[seriesName].Points.AddXY(item, Distribution(ordered_part1, item));
            }
            chart.Series[seriesName].BorderWidth = 2;
            return chart;
        }

        public static double Distribution(List<int> ordered_part1, int item)
        {
            int i = 1;
            foreach (var list_item in ordered_part1)
            {
                if(item > list_item)
                {
                    i++;
                }
                else
                {
                    break;
                }
            }
            return (i / Convert.ToDouble(ordered_part1.Count));
        }
    }
}
