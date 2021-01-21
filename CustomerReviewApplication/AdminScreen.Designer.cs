
namespace CustomerReviewApplication
{
    partial class AdminScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminScreen));
            this.pnAdminScreen = new System.Windows.Forms.Panel();
            this.btnAdminBack = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnAddCrtiteria = new System.Windows.Forms.Button();
            this.tbCriteria = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSelect = new System.Windows.Forms.Button();
            this.cbSelect = new System.Windows.Forms.ComboBox();
            this.lblSelectColumn = new System.Windows.Forms.Label();
            this.lblAdminPanel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSort = new System.Windows.Forms.Button();
            this.pnAdminScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnAdminScreen
            // 
            this.pnAdminScreen.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnAdminScreen.Controls.Add(this.btnSort);
            this.pnAdminScreen.Controls.Add(this.lblSelectColumn);
            this.pnAdminScreen.Controls.Add(this.cbSelect);
            this.pnAdminScreen.Controls.Add(this.btnSelect);
            this.pnAdminScreen.Controls.Add(this.chart1);
            this.pnAdminScreen.Controls.Add(this.btnAddCrtiteria);
            this.pnAdminScreen.Controls.Add(this.tbCriteria);
            this.pnAdminScreen.Controls.Add(this.dataGridView1);
            this.pnAdminScreen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnAdminScreen.Location = new System.Drawing.Point(6, 93);
            this.pnAdminScreen.Margin = new System.Windows.Forms.Padding(2);
            this.pnAdminScreen.Name = "pnAdminScreen";
            this.pnAdminScreen.Size = new System.Drawing.Size(1031, 482);
            this.pnAdminScreen.TabIndex = 0;
            // 
            // btnAdminBack
            // 
            this.btnAdminBack.BackColor = System.Drawing.Color.DarkRed;
            this.btnAdminBack.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminBack.ForeColor = System.Drawing.Color.White;
            this.btnAdminBack.Location = new System.Drawing.Point(982, 2);
            this.btnAdminBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdminBack.Name = "btnAdminBack";
            this.btnAdminBack.Size = new System.Drawing.Size(47, 37);
            this.btnAdminBack.TabIndex = 9;
            this.btnAdminBack.Text = "X";
            this.btnAdminBack.UseVisualStyleBackColor = false;
            this.btnAdminBack.Click += new System.EventHandler(this.btnAdminBack_Click);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(666, 96);
            this.chart1.Margin = new System.Windows.Forms.Padding(2);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(358, 378);
            this.chart1.TabIndex = 8;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // btnAddCrtiteria
            // 
            this.btnAddCrtiteria.BackColor = System.Drawing.Color.Bisque;
            this.btnAddCrtiteria.Font = new System.Drawing.Font("Calibri", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCrtiteria.Location = new System.Drawing.Point(514, 17);
            this.btnAddCrtiteria.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddCrtiteria.Name = "btnAddCrtiteria";
            this.btnAddCrtiteria.Size = new System.Drawing.Size(140, 37);
            this.btnAddCrtiteria.TabIndex = 7;
            this.btnAddCrtiteria.Text = "Add Criteria";
            this.btnAddCrtiteria.UseVisualStyleBackColor = false;
            this.btnAddCrtiteria.Click += new System.EventHandler(this.btnAddCrtiteria_Click);
            // 
            // tbCriteria
            // 
            this.tbCriteria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCriteria.Location = new System.Drawing.Point(232, 24);
            this.tbCriteria.Margin = new System.Windows.Forms.Padding(2);
            this.tbCriteria.Name = "tbCriteria";
            this.tbCriteria.Size = new System.Drawing.Size(255, 30);
            this.tbCriteria.TabIndex = 6;
            this.tbCriteria.TextChanged += new System.EventHandler(this.tbCriteria_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 2);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(93, 84);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(5, 77);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 102;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(649, 399);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.Bisque;
            this.btnSelect.Font = new System.Drawing.Font("Calibri", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.ForeColor = System.Drawing.Color.Black;
            this.btnSelect.Location = new System.Drawing.Point(916, 36);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(88, 37);
            this.btnSelect.TabIndex = 10;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // cbSelect
            // 
            this.cbSelect.FormattingEnabled = true;
            this.cbSelect.Location = new System.Drawing.Point(724, 49);
            this.cbSelect.Name = "cbSelect";
            this.cbSelect.Size = new System.Drawing.Size(157, 24);
            this.cbSelect.TabIndex = 11;
            this.cbSelect.SelectedIndexChanged += new System.EventHandler(this.cbSelect_SelectedIndexChanged);
            // 
            // lblSelectColumn
            // 
            this.lblSelectColumn.AutoSize = true;
            this.lblSelectColumn.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectColumn.Location = new System.Drawing.Point(720, 17);
            this.lblSelectColumn.Name = "lblSelectColumn";
            this.lblSelectColumn.Size = new System.Drawing.Size(146, 24);
            this.lblSelectColumn.TabIndex = 12;
            this.lblSelectColumn.Text = "Select Column:";
            this.lblSelectColumn.Click += new System.EventHandler(this.lblSelectColumn_Click);
            // 
            // lblAdminPanel
            // 
            this.lblAdminPanel.AutoSize = true;
            this.lblAdminPanel.BackColor = System.Drawing.Color.CadetBlue;
            this.lblAdminPanel.Font = new System.Drawing.Font("Miriam Libre", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminPanel.Location = new System.Drawing.Point(403, 18);
            this.lblAdminPanel.Name = "lblAdminPanel";
            this.lblAdminPanel.Size = new System.Drawing.Size(270, 53);
            this.lblAdminPanel.TabIndex = 13;
            this.lblAdminPanel.Text = "Admin Panel";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.lblAdminPanel);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btnAdminBack);
            this.panel1.Location = new System.Drawing.Point(6, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1031, 89);
            this.panel1.TabIndex = 1;
            // 
            // btnSort
            // 
            this.btnSort.BackColor = System.Drawing.Color.Bisque;
            this.btnSort.Font = new System.Drawing.Font("Calibri", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSort.Location = new System.Drawing.Point(5, 23);
            this.btnSort.Margin = new System.Windows.Forms.Padding(2);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(121, 37);
            this.btnSort.TabIndex = 13;
            this.btnSort.Text = "Sort by Name";
            this.btnSort.UseVisualStyleBackColor = false;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // AdminScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 578);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnAdminScreen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdminScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Panel";
            this.Load += new System.EventHandler(this.AdminScreen_Load);
            this.pnAdminScreen.ResumeLayout(false);
            this.pnAdminScreen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnAdminScreen;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAddCrtiteria;
        private System.Windows.Forms.TextBox tbCriteria;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnAdminBack;
        private System.Windows.Forms.ComboBox cbSelect;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label lblSelectColumn;
        private System.Windows.Forms.Label lblAdminPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSort;
    }
}