namespace MessageSpammer
{
    partial class spammer
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
            this.message = new System.Windows.Forms.TextBox();
            this.start = new System.Windows.Forms.Button();
            this.delay = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.spamtimes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // message
            // 
            this.message.Location = new System.Drawing.Point(12, 7);
            this.message.MinimumSize = new System.Drawing.Size(200, 200);
            this.message.Multiline = true;
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(200, 200);
            this.message.TabIndex = 0;
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(251, 21);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(201, 38);
            this.start.TabIndex = 1;
            this.start.Text = "Start (With Delay)";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // delay
            // 
            this.delay.Location = new System.Drawing.Point(317, 133);
            this.delay.MaxLength = 3;
            this.delay.Name = "delay";
            this.delay.Size = new System.Drawing.Size(26, 20);
            this.delay.TabIndex = 2;
            this.delay.Text = "60";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(345, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "s";
            // 
            // spamtimes
            // 
            this.spamtimes.Location = new System.Drawing.Point(251, 81);
            this.spamtimes.Name = "spamtimes";
            this.spamtimes.Size = new System.Drawing.Size(67, 20);
            this.spamtimes.TabIndex = 4;
            this.spamtimes.Text = "1000";
            this.spamtimes.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "times";
            // 
            // spammer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 219);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.spamtimes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.delay);
            this.Controls.Add(this.start);
            this.Controls.Add(this.message);
            this.Name = "spammer";
            this.ShowIcon = false;
            this.Text = "Message Spammer";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox message;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.TextBox delay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox spamtimes;
        private System.Windows.Forms.Label label2;
    }
}

