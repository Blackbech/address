namespace telefonbuch
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.suchtextTB = new System.Windows.Forms.TextBox();
            this.serviceBtn = new System.Windows.Forms.Button();
            this.alleBtn = new System.Windows.Forms.Button();
            this.privatBtn = new System.Windows.Forms.Button();
            this.neuBtn = new System.Windows.Forms.Button();
            this.suchenBtn = new System.Windows.Forms.Button();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.telnrTB = new System.Windows.Forms.TextBox();
            this.loeschenBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 117);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(474, 371);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 250;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nummer";
            this.columnHeader2.Width = 250;
            // 
            // suchtextTB
            // 
            this.suchtextTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suchtextTB.Location = new System.Drawing.Point(12, 73);
            this.suchtextTB.Name = "suchtextTB";
            this.suchtextTB.Size = new System.Drawing.Size(474, 38);
            this.suchtextTB.TabIndex = 3;
            this.suchtextTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // serviceBtn
            // 
            this.serviceBtn.BackColor = System.Drawing.Color.White;
            this.serviceBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("serviceBtn.BackgroundImage")));
            this.serviceBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.serviceBtn.FlatAppearance.BorderSize = 0;
            this.serviceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.serviceBtn.Location = new System.Drawing.Point(12, 12);
            this.serviceBtn.Name = "serviceBtn";
            this.serviceBtn.Size = new System.Drawing.Size(55, 55);
            this.serviceBtn.TabIndex = 4;
            this.serviceBtn.UseVisualStyleBackColor = false;
            this.serviceBtn.Click += new System.EventHandler(this.serviceBtn_Click);
            // 
            // alleBtn
            // 
            this.alleBtn.BackColor = System.Drawing.Color.White;
            this.alleBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("alleBtn.BackgroundImage")));
            this.alleBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.alleBtn.FlatAppearance.BorderSize = 0;
            this.alleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.alleBtn.Location = new System.Drawing.Point(73, 12);
            this.alleBtn.Name = "alleBtn";
            this.alleBtn.Size = new System.Drawing.Size(55, 55);
            this.alleBtn.TabIndex = 5;
            this.alleBtn.UseVisualStyleBackColor = false;
            this.alleBtn.Click += new System.EventHandler(this.alleBtn_Click);
            // 
            // privatBtn
            // 
            this.privatBtn.BackColor = System.Drawing.Color.White;
            this.privatBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("privatBtn.BackgroundImage")));
            this.privatBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.privatBtn.FlatAppearance.BorderSize = 0;
            this.privatBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.privatBtn.Location = new System.Drawing.Point(134, 12);
            this.privatBtn.Name = "privatBtn";
            this.privatBtn.Size = new System.Drawing.Size(55, 55);
            this.privatBtn.TabIndex = 6;
            this.privatBtn.UseVisualStyleBackColor = false;
            this.privatBtn.Click += new System.EventHandler(this.privatBtn_Click);
            // 
            // neuBtn
            // 
            this.neuBtn.BackColor = System.Drawing.Color.White;
            this.neuBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("neuBtn.BackgroundImage")));
            this.neuBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.neuBtn.FlatAppearance.BorderSize = 0;
            this.neuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.neuBtn.Location = new System.Drawing.Point(195, 12);
            this.neuBtn.Name = "neuBtn";
            this.neuBtn.Size = new System.Drawing.Size(55, 55);
            this.neuBtn.TabIndex = 7;
            this.neuBtn.UseVisualStyleBackColor = false;
            this.neuBtn.Click += new System.EventHandler(this.neuBtn_Click);
            // 
            // suchenBtn
            // 
            this.suchenBtn.BackColor = System.Drawing.Color.White;
            this.suchenBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("suchenBtn.BackgroundImage")));
            this.suchenBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.suchenBtn.FlatAppearance.BorderSize = 0;
            this.suchenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.suchenBtn.Location = new System.Drawing.Point(317, 12);
            this.suchenBtn.Name = "suchenBtn";
            this.suchenBtn.Size = new System.Drawing.Size(55, 55);
            this.suchenBtn.TabIndex = 8;
            this.suchenBtn.UseVisualStyleBackColor = false;
            this.suchenBtn.Click += new System.EventHandler(this.suchenBtn_Click);
            // 
            // nameTB
            // 
            this.nameTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameTB.Location = new System.Drawing.Point(378, 12);
            this.nameTB.Multiline = true;
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(107, 25);
            this.nameTB.TabIndex = 9;
            // 
            // telnrTB
            // 
            this.telnrTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.telnrTB.Location = new System.Drawing.Point(378, 43);
            this.telnrTB.Multiline = true;
            this.telnrTB.Name = "telnrTB";
            this.telnrTB.Size = new System.Drawing.Size(107, 24);
            this.telnrTB.TabIndex = 10;
            // 
            // loeschenBtn
            // 
            this.loeschenBtn.BackColor = System.Drawing.Color.White;
            this.loeschenBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loeschenBtn.BackgroundImage")));
            this.loeschenBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.loeschenBtn.FlatAppearance.BorderSize = 0;
            this.loeschenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loeschenBtn.Location = new System.Drawing.Point(256, 12);
            this.loeschenBtn.Name = "loeschenBtn";
            this.loeschenBtn.Size = new System.Drawing.Size(55, 55);
            this.loeschenBtn.TabIndex = 11;
            this.loeschenBtn.UseVisualStyleBackColor = false;
            this.loeschenBtn.Click += new System.EventHandler(this.loeschenBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.Controls.Add(this.loeschenBtn);
            this.Controls.Add(this.telnrTB);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.suchenBtn);
            this.Controls.Add(this.neuBtn);
            this.Controls.Add(this.privatBtn);
            this.Controls.Add(this.alleBtn);
            this.Controls.Add(this.serviceBtn);
            this.Controls.Add(this.suchtextTB);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Telefonbuch - Suche";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox suchtextTB;
        private System.Windows.Forms.Button serviceBtn;
        private System.Windows.Forms.Button alleBtn;
        private System.Windows.Forms.Button privatBtn;
        private System.Windows.Forms.Button neuBtn;
        private System.Windows.Forms.Button suchenBtn;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.TextBox telnrTB;
        private System.Windows.Forms.Button loeschenBtn;
    }
}

