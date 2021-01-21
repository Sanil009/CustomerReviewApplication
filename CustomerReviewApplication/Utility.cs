using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerReviewApplication
{
    class Utility
    {
        public static List<string> criteria = new List<string>();
        public static List<string> headers = new List<string>();
        public static string[] getCriteria()
        {
            string[] lines = File.ReadLines("criteria.txt").ToArray();
            return lines;
        }

        public static void SaveArrayAsCSV(List<string> criteria)
        {
            using (StreamWriter file = new StreamWriter("reviews.txt", true))
            {
                file.WriteLine(string.Join(",", criteria));
            }
            var lines = System.IO.File.ReadAllLines("reviews.txt");
            lines[0] = string.Join(",", headers);
            System.IO.File.WriteAllLines("reviews.txt", lines);
        }

        public static DataTable readCSVFile()
        {
            var lines = System.IO.File.ReadAllLines("reviews.txt");
            DataTable table = new DataTable();
            string[] headings = lines[0].Split(',').ToArray();
            foreach (string heading in headings)
            {
                table.Columns.Add(heading);
            }
            for (int i = 1; i < lines.Count(); i++)
            {
                DataRow row = table.NewRow();
                string[] values = lines[i].Split(',').ToArray();
                int a = 0;
                foreach (string value in values)
                {
                    row[headings[a]] = value;
                    a++;
                }

                table.Rows.Add(row);
            }
            return table;
        }

        public static DataTable forChart(String heading)
        {
            var lines = System.IO.File.ReadAllLines("reviews.txt");
            DataTable table = new DataTable();
            string[] headings = lines[0].Split(',').ToArray();
            List<string> ab = new List<string>();
            foreach (string h in headings)
            {
                ab.Add(h);
            }
            int index = ab.IndexOf(heading);
            List<int> reviewValue = new List<int>();
            for (int i = 1; i < lines.Count(); i++)
            {
                string[] values = lines[i].Split(',').ToArray();
                reviewValue.Add(Int32.Parse(values[index]));
            }
            var counts = reviewValue.GroupBy(a => a).Select(x => new { key = x.Key, val = x.Count() });
            DataTable dt = new DataTable();
            dt.Columns.Add("rating");
            dt.Columns.Add("count");
            foreach (var item in counts)
            {
                DataRow row = dt.NewRow();
                row[0] = item.key;
                row[1] = item.val;
                dt.Rows.Add(row);
            }
            return dt;
        }
    }
}
