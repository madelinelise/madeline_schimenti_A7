namespace madeline_schimenti_A7
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
            this.buttonRoll = new System.Windows.Forms.Button();
            this.buttonNewPlayer = new System.Windows.Forms.Button();
            this.labelDie0 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonRoll
            // 
            this.buttonRoll.Location = new System.Drawing.Point(115, 42);
            this.buttonRoll.Name = "buttonRoll";
            this.buttonRoll.Size = new System.Drawing.Size(75, 23);
            this.buttonRoll.TabIndex = 0;
            this.buttonRoll.Text = "Roll";
            this.buttonRoll.UseVisualStyleBackColor = true;
            this.buttonRoll.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonNewPlayer
            // 
            this.buttonNewPlayer.Location = new System.Drawing.Point(231, 42);
            this.buttonNewPlayer.Name = "buttonNewPlayer";
            this.buttonNewPlayer.Size = new System.Drawing.Size(75, 23);
            this.buttonNewPlayer.TabIndex = 1;
            this.buttonNewPlayer.Text = "New Player";
            this.buttonNewPlayer.UseVisualStyleBackColor = true;
            // 
            // labelDie0
            // 
            this.labelDie0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDie0.Location = new System.Drawing.Point(69, 121);
            this.labelDie0.Name = "labelDie0";
            this.labelDie0.Size = new System.Drawing.Size(20, 20);
            this.labelDie0.TabIndex = 5;
            this.labelDie0.Text = " x ";
            this.labelDie0.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 232);
            this.Controls.Add(this.labelDie0);
            this.Controls.Add(this.buttonNewPlayer);
            this.Controls.Add(this.buttonRoll);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRoll;
        private System.Windows.Forms.Button buttonNewPlayer;
        private System.Windows.Forms.Label labelDie0;
    }
}

