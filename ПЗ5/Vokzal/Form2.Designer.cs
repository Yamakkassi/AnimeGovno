
namespace Vokzal
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
            this.ЗдесьРасписание = new System.Windows.Forms.ListBox();
            this.Свободныеместа = new System.Windows.Forms.ListBox();
            this.Оформить_билет = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // ЗдесьРасписание
            // 
            this.ЗдесьРасписание.FormattingEnabled = true;
            this.ЗдесьРасписание.ItemHeight = 15;
            this.ЗдесьРасписание.Location = new System.Drawing.Point(12, 61);
            this.ЗдесьРасписание.Name = "ЗдесьРасписание";
            this.ЗдесьРасписание.Size = new System.Drawing.Size(257, 439);
            this.ЗдесьРасписание.TabIndex = 0;
            this.ЗдесьРасписание.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Свободныеместа
            // 
            this.Свободныеместа.FormattingEnabled = true;
            this.Свободныеместа.ItemHeight = 15;
            this.Свободныеместа.Location = new System.Drawing.Point(578, 61);
            this.Свободныеместа.Name = "Свободныеместа";
            this.Свободныеместа.Size = new System.Drawing.Size(298, 439);
            this.Свободныеместа.TabIndex = 1;
            this.Свободныеместа.SelectedIndexChanged += new System.EventHandler(this.Свободныеместа_SelectedIndexChanged);
            // 
            // Оформить_билет
            // 
            this.Оформить_билет.Location = new System.Drawing.Point(349, 259);
            this.Оформить_билет.Name = "Оформить_билет";
            this.Оформить_билет.Size = new System.Drawing.Size(122, 23);
            this.Оформить_билет.TabIndex = 2;
            this.Оформить_билет.Text = "Оформить билет";
            this.Оформить_билет.UseVisualStyleBackColor = true;
            this.Оформить_билет.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(754, 671);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(122, 23);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vokzal.Properties.Resources._1618637738_7_phonoteka_org_p_fon_serpantin_101;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(888, 706);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Оформить_билет);
            this.Controls.Add(this.Свободныеместа);
            this.Controls.Add(this.ЗдесьРасписание);
            this.DoubleBuffered = true;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ЗдесьРасписание;
        private System.Windows.Forms.ListBox Свободныеместа;
        private System.Windows.Forms.Button Оформить_билет;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}