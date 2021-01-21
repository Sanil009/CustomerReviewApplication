using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerReviewApplication
{
    public partial class AdminScreen : Form
    {
        public AdminScreen()
        {
            InitializeComponent();
            dataGridView1.DataSource = Utility.readCSVFile();
            Utility.getCriteria();
            cbSelect.DataSource = Utility.getCriteria();
            bindChart(Utility.getCriteria()[0]);

        }
        private void bindChart(String key)
        {
            chart1.DataSource = Utility.forChart(key);
            chart1.Series["Series1"].XValueMember = "rating";
            chart1.Series["Series1"].YValueMembers = "count";
            chart1.DataBind();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AdminScreen_Load(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdminBack_Click(object sender, EventArgs e)
        {
            MainScreen main = new MainScreen();
            main.Show();
            this.Close();
        }

        StringBuilder output = new StringBuilder();

        private void btnAddCrtiteria_Click(object sender, EventArgs e)
        {
            output.AppendLine(string.Join(",", tbCriteria.Text));
            File.AppendAllText("criteria.txt", output.ToString());
            cbSelect.DataSource = Utility.getCriteria();
            MessageBox.Show("Criteria Added");
            tbCriteria.Clear();
 
        }

        private void tbCriteria_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            var lines = System.IO.File.ReadAllLines("reviews.txt");
            List<string> headers = lines[0].Split(',').ToList();
            if (headers.Contains(cbSelect.SelectedValue.ToString()))
            {
                bindChart(cbSelect.SelectedValue.ToString());
            }
            else
            {
                MessageBox.Show("");
            }
        }

        private void cbSelect_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            var lines = System.IO.File.ReadAllLines("reviews.txt");
            DataTable tblSort = new DataTable();
            List<List<string>> reviews = new List<List<string>>();
            for (int i = 1; i < lines.Count(); i++)
            {
                List<string> review = lines[i].Split(',').ToArray().OfType<string>().ToList();
                reviews.Add(review);
            }
            int sizeOfArray = reviews.Count();
            int minimum;
            for (int i = 0; i < sizeOfArray - 1; i++)
            {
                minimum = i;
                for (int j = i + 1; j < sizeOfArray; j++)
                {
                    if ((string.Compare(reviews[j][1], reviews[minimum][1]) < 0))
                    {
                        minimum = j;
                    }
                }
                List<string> temp = reviews[minimum];
                reviews[minimum] = reviews[i];
                reviews[i] = temp;
            }
            string[] headings = lines[0].Split(',').ToArray();
            foreach (string heading in headings)
            {
                tblSort.Columns.Add(heading);
            }
            for (int i = 0; i < reviews.Count(); i++)
            {
                DataRow row = tblSort.NewRow();
                int a = 0;
                foreach (string value in reviews[i])
                {
                    row[headings[a]] = value;
                    a++;
                }
                tblSort.Rows.Add(row);
            }
            dataGridView1.DataSource = tblSort;
        }

        private void lblSelectColumn_Click(object sender, EventArgs e)
        {

        }
    }
}
