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

            //#region Part 1
            //List<int> collisions = BirthdayParadox(r, 1, 4000);
            //Console.WriteLine("Part 1A:\t" + collisions.First());

            //Stopwatch s = new Stopwatch();
            //s.Start();
            //List<int> collisions2 = BirthdayParadox(r, 300, 4000);
            //s.Stop();
            //long time = s.ElapsedMilliseconds;
            //s.Reset();

            //Console.WriteLine("Part 1C:\t" + collisions2.Average());
            //Console.WriteLine("Part 1D (how long it took for 300 trials):\t" + time + " Milliseconds");

            //#region Chart 1B
            //Chart chart = new Chart();
            //chart.Series.Clear();
            //chart.Size = new System.Drawing.Size(680, 350);
            //chart.ChartAreas.Add("ChartedAreas");
            //chart.ChartAreas["ChartedAreas"].AxisX.Minimum = 6;
            //chart.ChartAreas["ChartedAreas"].AxisX.Maximum = 252;
            //chart.ChartAreas["ChartedAreas"].AxisY.Minimum = 0;
            //chart.ChartAreas["ChartedAreas"].AxisY.Maximum = 1;
            //chart.ChartAreas["ChartedAreas"].AxisX.Interval = 10;
            //chart.ChartAreas["ChartedAreas"].AxisY.Interval = 0.25;
            //chart.ChartAreas["ChartedAreas"].AxisX.Title = "k (number of trial required)";
            //chart.ChartAreas["ChartedAreas"].AxisY.Title = "Fraction of experiments that succeeded after k trials";
            //chart.Legends.Add("Legend1");
            //chart = GenerateChart(chart, collisions2, "Part 1B");
            //chart.SaveImage("Part_1B.png", ChartImageFormat.Png);
            //#endregion

            //List<int> collisions3;
            //List<TimeNM> time_helper = new List<TimeNM>();

            //for (int m = 2500; m < 10001; m = m + 2500)
            //{
            //    for (int n = 50000; n < 1000001; n = n + 50000)
            //    {
            //        s.Start();
            //        collisions3 = BirthdayParadox(r, m, n);
            //        s.Stop();
            //        time = s.ElapsedMilliseconds;
            //        time_helper.Add(new TimeNM(n, m, Convert.ToDouble(time) / 1000));
            //        Console.WriteLine("M = " + m + "\tN = " + n + "\tTime = " + time);
            //        s.Reset();
            //    }
            //}
            //#region Chart 1D
            //chart = new Chart();
            //chart.Series.Clear();
            //chart.Size = new System.Drawing.Size(680, 350);
            //chart.ChartAreas.Add("ChartedAreas");
            //chart.ChartAreas["ChartedAreas"].AxisX.Minimum = 5000;
            //chart.ChartAreas["ChartedAreas"].AxisX.Maximum = 1002501;
            //chart.ChartAreas["ChartedAreas"].AxisY.Minimum = 0;
            //chart.ChartAreas["ChartedAreas"].AxisY.Maximum = 1.2;
            //chart.ChartAreas["ChartedAreas"].AxisX.Interval = 100000;
            //chart.ChartAreas["ChartedAreas"].AxisY.Interval = 0.1;
            //chart.ChartAreas["ChartedAreas"].AxisX.Title = "N (Domain of Random Variable)";
            //chart.ChartAreas["ChartedAreas"].AxisY.Title = "Seconds";
            //chart.Legends.Add("Legend1");
            //chart = GenerateChart2(chart, time_helper.Where(x => x.M == 10000).ToList(), "M = 10000");
            //chart = GenerateChart2(chart, time_helper.Where(x => x.M == 7500).ToList(), "M = 7500");
            //chart = GenerateChart2(chart, time_helper.Where(x => x.M == 5000).ToList(), "M = 5000");
            //chart = GenerateChart2(chart, time_helper.Where(x => x.M == 2500).ToList(), "M = 2500");
            //chart.SaveImage("Part_1D.png", ChartImageFormat.Png);
            //#endregion
            //#endregion

            //#region Part 2
            //r = new Random(1);
            //List<int> couponcollectors = CouponCollectors(r, 1, 250);
            //Console.WriteLine("Part 2A:\t" + couponcollectors.First());

            //s = new Stopwatch();
            //s.Start();
            //List<int> couponcollectors2 = CouponCollectors(r, 300, 250);
            //s.Stop();
            //time = s.ElapsedMilliseconds;
            //s.Reset();

            //Console.WriteLine("Part 2C:\t" + couponcollectors2.Average());
            //Console.WriteLine("Part 2D (how long it took for 300 trials):\t" + time + " Milliseconds");

            //Console.WriteLine(couponcollectors2.Max());
            //Console.WriteLine(couponcollectors2.Min());

            //#region Chart 2B
            //chart = new Chart();
            //chart.Series.Clear();
            //chart.Size = new System.Drawing.Size(680, 350);
            //chart.ChartAreas.Add("ChartedAreas");
            //chart.ChartAreas["ChartedAreas"].AxisX.Minimum = 900;
            //chart.ChartAreas["ChartedAreas"].AxisX.Maximum = 2700;
            //chart.ChartAreas["ChartedAreas"].AxisY.Minimum = 0;
            //chart.ChartAreas["ChartedAreas"].AxisY.Maximum = 1;
            //chart.ChartAreas["ChartedAreas"].AxisX.Interval = 150;
            //chart.ChartAreas["ChartedAreas"].AxisY.Interval = 0.25;
            //chart.ChartAreas["ChartedAreas"].AxisX.Title = "k (number of trial required)";
            //chart.ChartAreas["ChartedAreas"].AxisY.Title = "Fraction of experiments that succeeded after k trials";
            //chart.Legends.Add("Legend1");
            //chart = GenerateChart(chart, couponcollectors2, "Part 2B");
            //chart.SaveImage("Part_2B.png", ChartImageFormat.Png);
            //#endregion


            //List<int> couponcollectors3;
            //time_helper = new List<TimeNM>();

            //for (int m = 1000; m < 5001; m = m + 1000)
            //{
            //    for (int n = 1000; n < 20001; n = n + 1000)
            //    {
            //        s.Start();
            //        couponcollectors3 = CouponCollectors(r, m, n);
            //        s.Stop();
            //        time = s.ElapsedMilliseconds;
            //        time_helper.Add(new TimeNM(n, m, Convert.ToDouble(time) / 1000));
            //        Console.WriteLine("M = " + m + "\tN = " + n + "\tTime = " + time);
            //        s.Reset();
            //    }
            //}
            //#region Chart 1D
            //chart = new Chart();
            //chart.Series.Clear();
            //chart.Size = new System.Drawing.Size(680, 350);
            //chart.ChartAreas.Add("ChartedAreas");
            //chart.ChartAreas["ChartedAreas"].AxisX.Minimum = 500;
            //chart.ChartAreas["ChartedAreas"].AxisX.Maximum = 20500;
            //chart.ChartAreas["ChartedAreas"].AxisY.Minimum = 0;
            //chart.ChartAreas["ChartedAreas"].AxisY.Maximum = 70;
            //chart.ChartAreas["ChartedAreas"].AxisX.Interval = 1000;
            //chart.ChartAreas["ChartedAreas"].AxisY.Interval = 5;
            //chart.ChartAreas["ChartedAreas"].AxisX.Title = "N (Domain of Random Variable)";
            //chart.ChartAreas["ChartedAreas"].AxisY.Title = "Seconds";
            //chart.Legends.Add("Legend1");
            //chart = GenerateChart2(chart, time_helper.Where(x => x.M == 5000).ToList(), "M = 5000");
            //chart = GenerateChart2(chart, time_helper.Where(x => x.M == 4000).ToList(), "M = 4000");
            //chart = GenerateChart2(chart, time_helper.Where(x => x.M == 3000).ToList(), "M = 3000");
            //chart = GenerateChart2(chart, time_helper.Where(x => x.M == 2000).ToList(), "M = 2000");
            //chart = GenerateChart2(chart, time_helper.Where(x => x.M == 1000).ToList(), "M = 1000");
            //chart.SaveImage("Part_2D.png", ChartImageFormat.Png);
            //#endregion

            //#endregion

            CalculateProbability();

            Console.ReadKey(false);
        }

        private static void CalculateProbability()
        {
            while (true)
            {
                //Console.WriteLine("Give me an n:\t");
                double n = 4000; // Console.Read();
                Console.WriteLine("Give me a k:\t");
                double k = Convert.ToDouble(Console.ReadLine());

                double probability = 1;
                for (int i = 1; i < k; i++)
                {
                    probability = probability * ((n - i) / n);
                }
                probability = 1 - probability;

                Console.WriteLine(probability);
            }
        }

        private static List<int> CouponCollectors(Random r, int m, int n)
        {
            List<int> equally_divided = new List<int>();
            
            for (int i = 0; i < m; i++)
            {
                bool all = false;
                HashSet<int> values = new HashSet<int>();
                int j = 0;
                while (!all)
                {
                    int temp = r.Next(1, n+1);
                    values.Add(temp);
                    if (values.Count >= n)
                    {
                        all = true;
                    }
                    j++;
                }
                equally_divided.Add(j);
            }
            return equally_divided;

        }

        private static bool Contains(int n, HashSet<int> values)
        {
            for (int i = 1; i < n+1; i++)
            {
                if(values.Contains(i))
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        public static List<int> BirthdayParadox(Random r, int m, int n)
        {
            List<int> collisions = new List<int>();

            for (int i = 0; i < m; i++)
            {
                bool collision = false;
                HashSet<int> values = new HashSet<int>();
                int j = 0;
                while (!collision)
                {
                    int temp = r.Next(0, n);
                    if (values.Contains(temp))
                    {
                        collision = true;
                    }
                    values.Add(temp);
                    j++;
                } 
                collisions.Add(j);
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
        static Chart GenerateChart2(Chart chart, List<TimeNM> part1, string seriesName)
        {
            chart.Series.Add(seriesName);
            chart.Series[seriesName].ChartType = SeriesChartType.Spline;

            chart.Series[seriesName].XValueType = ChartValueType.Int32; //the epoch ID
            chart.Series[seriesName].YValueType = ChartValueType.Double; //Development set Acuracy
            foreach (var item in part1)
            {
                chart.Series[seriesName].Points.AddXY(item.N, item.Time);
            }
            chart.Series[seriesName].BorderWidth = 2;
            return chart;
        }
    }
}
