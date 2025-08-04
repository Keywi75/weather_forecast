namespace API
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
            this.City = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.des = new System.Windows.Forms.TextBox();
            this.temp = new System.Windows.Forms.TextBox();
            this.press = new System.Windows.Forms.TextBox();
            this.hum = new System.Windows.Forms.TextBox();
            this.cloud = new System.Windows.Forms.TextBox();
            this.wind = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // City
            // 
            this.City.FormattingEnabled = true;
            this.City.Location = new System.Drawing.Point(26, 23);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(336, 28);
            this.City.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(392, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // des
            // 
            this.des.Location = new System.Drawing.Point(241, 118);
            this.des.Name = "des";
            this.des.Size = new System.Drawing.Size(144, 26);
            this.des.TabIndex = 2;
            // 
            // temp
            // 
            this.temp.Location = new System.Drawing.Point(241, 162);
            this.temp.Name = "temp";
            this.temp.Size = new System.Drawing.Size(144, 26);
            this.temp.TabIndex = 3;
            // 
            // press
            // 
            this.press.Location = new System.Drawing.Point(241, 207);
            this.press.Name = "press";
            this.press.Size = new System.Drawing.Size(144, 26);
            this.press.TabIndex = 4;
            // 
            // hum
            // 
            this.hum.Location = new System.Drawing.Point(241, 250);
            this.hum.Name = "hum";
            this.hum.Size = new System.Drawing.Size(144, 26);
            this.hum.TabIndex = 5;
            // 
            // cloud
            // 
            this.cloud.Location = new System.Drawing.Point(241, 296);
            this.cloud.Name = "cloud";
            this.cloud.Size = new System.Drawing.Size(144, 26);
            this.cloud.TabIndex = 6;
            // 
            // wind
            // 
            this.wind.Location = new System.Drawing.Point(241, 342);
            this.wind.Name = "wind";
            this.wind.Size = new System.Drawing.Size(144, 26);
            this.wind.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "Current Weather";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Temperature";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(121, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Pressure";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(121, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Humidity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(121, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Clouds";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(121, 348);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Wind speed";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(641, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 29);
            this.label8.TabIndex = 15;
            this.label8.Text = "Cloud";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(44, 388);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(837, 284);
            this.dataGridView1.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.pictureBox1.Location = new System.Drawing.Point(572, 124);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 185);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 738);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wind);
            this.Controls.Add(this.cloud);
            this.Controls.Add(this.hum);
            this.Controls.Add(this.press);
            this.Controls.Add(this.temp);
            this.Controls.Add(this.des);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.City);
            this.Name = "Form1";
            this.Text = "Assignment 5";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox City;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox des;
        private System.Windows.Forms.TextBox temp;
        private System.Windows.Forms.TextBox press;
        private System.Windows.Forms.TextBox hum;
        private System.Windows.Forms.TextBox cloud;
        private System.Windows.Forms.TextBox wind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

