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
    public partial class ReviewScreen : Form
    {
        List<GroupBox> gboxes = new List<GroupBox>();
        List<List<RadioButton>> buttons = new List<List<RadioButton>>();
        public ReviewScreen()
        {
            InitializeComponent();
            int x = 0;
            readCriteria();

            foreach (string s in Utility.criteria)
            {
                GroupBox gb = new GroupBox();
                RadioButton worst = new RadioButton();
                RadioButton bad = new RadioButton();
                RadioButton good = new RadioButton();
                RadioButton excellent = new RadioButton();
                rbStyle(worst, "Worst");
                rbStyle(bad, "Bad");
                rbStyle(good, "Good");
                rbStyle(excellent, "Excellent");
                List<RadioButton> button = new List<RadioButton>();
                button.Add(worst);
                button.Add(bad);
                button.Add(good);
                button.Add(excellent);
                buttons.Add(button);
                gboxes.Add(gb);
            }

            for (int i = 0; i < Utility.criteria.Count(); i++)
            {
                gboxes[i].SuspendLayout();
                foreach (RadioButton rb in buttons[i])
                {
                    gboxes[i].Controls.Add(rb);
                    radiox = 0;
                }
                gboxes[i].Location = new System.Drawing.Point(x, y);
                gboxes[i].Size = new System.Drawing.Size(400, 54);
                gboxes[i].TabIndex = 45;
                gboxes[i].TabStop = false;
                gboxes[i].Text = Utility.criteria[i];
                pnServiceRatings.Controls.Add(gboxes[i]);
                y = y + 60;
            }

        }
        int radiox = 5;
        int y = 0;

        public void rbStyle(RadioButton rb, string text)
        {
            rb.AutoSize = true;
            rb.Location = new System.Drawing.Point(radiox, y + 15);
            rb.Size = new System.Drawing.Size(70, 21);
            rb.TabIndex = 11;
            rb.TabStop = true;
            rb.Text = text;
            rb.UseVisualStyleBackColor = true;
            radiox = radiox + 80;
            if (radiox > 250)
            {
                radiox = 5;
            }
        }
        public static void readCriteria()
        {
            string[] readCriteria = File.ReadAllLines("criteria.txt");
            for (int i = 0; i < readCriteria.Count(); i++)
            {
                Utility.criteria.Add(readCriteria[i]);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "" || tbPhone.Text == "" || tbPhone.Text == "" || tbEmail.Text == "" || cbAge.Text == "")
            {
                MessageBox.Show("Please fill all the available fields");
            }

            List<string> lst = new List<string>();
            Utility.headers.Clear();
            DateTime now = DateTime.Now;
            Utility.headers.Add("Date time");
            lst.Add(now.ToString("dd.MM.yyyy"));
            Utility.headers.Add("Name");
            lst.Add(tbName.Text);
            Utility.headers.Add("Phone Number");
            lst.Add(tbPhone.Text);
            Utility.headers.Add("Email");
            lst.Add(tbEmail.Text);
            Utility.headers.Add("Age");
            lst.Add(cbAge.Text);
            Utility.headers.Add("Feedback");
            lst.Add(tbFeedback.Text);
            foreach (GroupBox rb in gboxes)
            {
                String s = SelectedRadioButton(rb).Text;
                lst.Add(txtRatingtoNumber(s));
                Utility.headers.Add(rb.Text);
            }
            Utility.SaveArrayAsCSV(lst);
            MessageBox.Show("Your Review has been recorded");
        }

        public static RadioButton SelectedRadioButton(GroupBox g)
        {
            return g.Controls.OfType<RadioButton>().Where(rb => rb.Checked).FirstOrDefault();
        }

        public string txtRatingtoNumber(string z)
        {
            if (z == "Worst")
            {
                return "1";
            }
            else if (z == "Bad")
            {
                return "2";
            }
            else if (z == "Good")
            {
                return "3";
            }
            else
            {
                return "4";
            } 
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ReviewScreen_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbName.Clear();
            tbPhone.Clear();
            tbEmail.Clear();
            cbAge.Text = "";
            tbFeedback.Clear();
            foreach (List<RadioButton> rbs in buttons)
            {
                foreach (RadioButton rb in rbs)
                {
                    rb.Checked = false;
                }
            }
            
        }

        private void btnReviewBack_Click(object sender, EventArgs e)
        {
            MainScreen main = new MainScreen();
            main.Show();
            this.Close();
        }

        private void pnDetails_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
