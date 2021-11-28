
namespace BusTest
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.StartNumeric = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EndNumeric = new System.Windows.Forms.NumericUpDown();
            this.TimeTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.FastestTB = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CheapestTB = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StartNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Загрузить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StartNumeric
            // 
            this.StartNumeric.Location = new System.Drawing.Point(12, 57);
            this.StartNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.StartNumeric.Name = "StartNumeric";
            this.StartNumeric.Size = new System.Drawing.Size(101, 23);
            this.StartNumeric.TabIndex = 1;
            this.StartNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Начальная точка";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Конечная точка";
            // 
            // EndNumeric
            // 
            this.EndNumeric.Location = new System.Drawing.Point(119, 57);
            this.EndNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.EndNumeric.Name = "EndNumeric";
            this.EndNumeric.Size = new System.Drawing.Size(94, 23);
            this.EndNumeric.TabIndex = 3;
            this.EndNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // TimeTB
            // 
            this.TimeTB.Location = new System.Drawing.Point(219, 57);
            this.TimeTB.Name = "TimeTB";
            this.TimeTB.Size = new System.Drawing.Size(81, 23);
            this.TimeTB.TabIndex = 6;
            this.TimeTB.Text = "00:00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(219, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Время";
            // 
            // FastestTB
            // 
            this.FastestTB.Location = new System.Drawing.Point(12, 101);
            this.FastestTB.Name = "FastestTB";
            this.FastestTB.Size = new System.Drawing.Size(288, 96);
            this.FastestTB.TabIndex = 8;
            this.FastestTB.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Самый быстрый маршрут";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Самый дешевый маршрут";
            // 
            // CheapestTB
            // 
            this.CheapestTB.Location = new System.Drawing.Point(12, 221);
            this.CheapestTB.Name = "CheapestTB";
            this.CheapestTB.Size = new System.Drawing.Size(288, 96);
            this.CheapestTB.TabIndex = 10;
            this.CheapestTB.Text = "";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(225, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Расчитать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 319);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CheapestTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.FastestTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TimeTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EndNumeric);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StartNumeric);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.StartNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown StartNumeric;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown EndNumeric;
        private System.Windows.Forms.TextBox TimeTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox FastestTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox CheapestTB;
        private System.Windows.Forms.Button button2;
    }
}

