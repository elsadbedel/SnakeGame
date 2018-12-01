namespace Snake
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonSNake = new RoundButtonDemo.CircularButton();
            this.Uzunluq = new System.Windows.Forms.Label();
            this.En = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // ButtonSNake
            // 
            this.ButtonSNake.AllowDrop = true;
            this.ButtonSNake.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonSNake.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonSNake.BackgroundImage")));
            this.ButtonSNake.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonSNake.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSNake.Location = new System.Drawing.Point(398, 189);
            this.ButtonSNake.Name = "ButtonSNake";
            this.ButtonSNake.Size = new System.Drawing.Size(20, 20);
            this.ButtonSNake.TabIndex = 1;
            this.ButtonSNake.UseVisualStyleBackColor = false;
            this.ButtonSNake.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ButtonSNake_KeyDown_1);
            // 
            // Uzunluq
            // 
            this.Uzunluq.AutoSize = true;
            this.Uzunluq.Location = new System.Drawing.Point(710, 83);
            this.Uzunluq.Name = "Uzunluq";
            this.Uzunluq.Size = new System.Drawing.Size(38, 13);
            this.Uzunluq.TabIndex = 3;
            this.Uzunluq.Text = "Height";
            // 
            // En
            // 
            this.En.AutoSize = true;
            this.En.Location = new System.Drawing.Point(710, 35);
            this.En.Name = "En";
            this.En.Size = new System.Drawing.Size(35, 13);
            this.En.TabIndex = 4;
            this.En.Text = "Width";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.En);
            this.Controls.Add(this.Uzunluq);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonSNake);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private RoundButtonDemo.CircularButton ButtonSNake;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Uzunluq;
        private System.Windows.Forms.Label En;
    }
}

