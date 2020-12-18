
namespace horoscopelab
{
    partial class Form2
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
            this.menu = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.results = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.aries = new System.Windows.Forms.Button();
            this.rd_yesterday = new System.Windows.Forms.RadioButton();
            this.rd_today = new System.Windows.Forms.RadioButton();
            this.rd_tomorrow = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.Transparent;
            this.menu.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu.Font = new System.Drawing.Font("Segoe Script", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu.ForeColor = System.Drawing.Color.White;
            this.menu.Location = new System.Drawing.Point(643, 12);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(145, 51);
            this.menu.TabIndex = 31;
            this.menu.Text = "Menu";
            this.menu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menu.UseVisualStyleBackColor = false;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Segoe Script", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(186, 8);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(445, 80);
            this.title.TabIndex = 16;
            this.title.Text = "Daily Horoscope";
            // 
            // results
            // 
            this.results.Location = new System.Drawing.Point(85, 170);
            this.results.Name = "results";
            this.results.Size = new System.Drawing.Size(628, 251);
            this.results.TabIndex = 32;
            this.results.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(186, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 37);
            this.label3.TabIndex = 33;
            this.label3.Text = "Date";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(78, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 37);
            this.label2.TabIndex = 34;
            this.label2.Text = "Company";
            // 
            // aries
            // 
            this.aries.BackColor = System.Drawing.Color.Transparent;
            this.aries.BackgroundImage = global::horoscopelab.Properties.Resources.aries;
            this.aries.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.aries.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aries.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.aries.FlatAppearance.BorderSize = 3;
            this.aries.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aries.ForeColor = System.Drawing.Color.Black;
            this.aries.Location = new System.Drawing.Point(83, 8);
            this.aries.Name = "aries";
            this.aries.Size = new System.Drawing.Size(97, 99);
            this.aries.TabIndex = 35;
            this.aries.UseVisualStyleBackColor = false;
            // 
            // rd_yesterday
            // 
            this.rd_yesterday.AutoSize = true;
            this.rd_yesterday.BackColor = System.Drawing.Color.Transparent;
            this.rd_yesterday.Font = new System.Drawing.Font("Segoe Script", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_yesterday.ForeColor = System.Drawing.Color.White;
            this.rd_yesterday.Location = new System.Drawing.Point(451, 75);
            this.rd_yesterday.Name = "rd_yesterday";
            this.rd_yesterday.Size = new System.Drawing.Size(115, 32);
            this.rd_yesterday.TabIndex = 36;
            this.rd_yesterday.TabStop = true;
            this.rd_yesterday.Text = "Yesterday";
            this.rd_yesterday.UseVisualStyleBackColor = false;
            this.rd_yesterday.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            this.rd_yesterday.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // rd_today
            // 
            this.rd_today.AutoSize = true;
            this.rd_today.BackColor = System.Drawing.Color.Transparent;
            this.rd_today.Font = new System.Drawing.Font("Segoe Script", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_today.ForeColor = System.Drawing.Color.White;
            this.rd_today.Location = new System.Drawing.Point(572, 75);
            this.rd_today.Name = "rd_today";
            this.rd_today.Size = new System.Drawing.Size(87, 32);
            this.rd_today.TabIndex = 37;
            this.rd_today.TabStop = true;
            this.rd_today.Text = "Today";
            this.rd_today.UseVisualStyleBackColor = false;
            // 
            // rd_tomorrow
            // 
            this.rd_tomorrow.AutoSize = true;
            this.rd_tomorrow.BackColor = System.Drawing.Color.Transparent;
            this.rd_tomorrow.Font = new System.Drawing.Font("Segoe Script", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_tomorrow.ForeColor = System.Drawing.Color.White;
            this.rd_tomorrow.Location = new System.Drawing.Point(665, 75);
            this.rd_tomorrow.Name = "rd_tomorrow";
            this.rd_tomorrow.Size = new System.Drawing.Size(124, 32);
            this.rd_tomorrow.TabIndex = 38;
            this.rd_tomorrow.TabStop = true;
            this.rd_tomorrow.Text = "Tomorrow";
            this.rd_tomorrow.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::horoscopelab.Properties.Resources.back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rd_tomorrow);
            this.Controls.Add(this.rd_today);
            this.Controls.Add(this.rd_yesterday);
            this.Controls.Add(this.aries);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.results);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.title);
            this.Name = "Form2";
            this.Text = "Daily Horoscope";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button menu;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.RichTextBox results;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button aries;
        private System.Windows.Forms.RadioButton rd_yesterday;
        private System.Windows.Forms.RadioButton rd_today;
        private System.Windows.Forms.RadioButton rd_tomorrow;
    }
}