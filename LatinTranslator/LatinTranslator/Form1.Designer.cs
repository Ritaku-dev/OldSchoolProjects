namespace LatinTranslator
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.DirectionsL = new System.Windows.Forms.Label();
            this.AnswerL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(288, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 61);
            this.button1.TabIndex = 0;
            this.button1.Text = "Sinister";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(518, 218);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 61);
            this.button2.TabIndex = 1;
            this.button2.Text = "Dexter";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(718, 218);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 61);
            this.button3.TabIndex = 2;
            this.button3.Text = "Medium";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // DirectionsL
            // 
            this.DirectionsL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DirectionsL.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DirectionsL.Location = new System.Drawing.Point(482, 113);
            this.DirectionsL.Name = "DirectionsL";
            this.DirectionsL.Size = new System.Drawing.Size(209, 60);
            this.DirectionsL.TabIndex = 3;
            this.DirectionsL.Text = "Latin to English Translation.\r\n\r\nClick Latin word to see English translation";
            this.DirectionsL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AnswerL
            // 
            this.AnswerL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AnswerL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerL.Location = new System.Drawing.Point(518, 338);
            this.AnswerL.Name = "AnswerL";
            this.AnswerL.Size = new System.Drawing.Size(134, 39);
            this.AnswerL.TabIndex = 4;
            this.AnswerL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 643);
            this.Controls.Add(this.AnswerL);
            this.Controls.Add(this.DirectionsL);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label DirectionsL;
        private System.Windows.Forms.Label AnswerL;
    }
}

