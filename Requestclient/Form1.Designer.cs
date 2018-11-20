namespace Requestclient
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
            this.lblCurrentTurn = new System.Windows.Forms.Label();
            this.lblNextTurn = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCurrentTurn
            // 
            this.lblCurrentTurn.AutoSize = true;
            this.lblCurrentTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentTurn.Location = new System.Drawing.Point(37, 29);
            this.lblCurrentTurn.Name = "lblCurrentTurn";
            this.lblCurrentTurn.Size = new System.Drawing.Size(70, 26);
            this.lblCurrentTurn.TabIndex = 0;
            this.lblCurrentTurn.Text = "label1";
            // 
            // lblNextTurn
            // 
            this.lblNextTurn.AutoSize = true;
            this.lblNextTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNextTurn.Location = new System.Drawing.Point(37, 83);
            this.lblNextTurn.Name = "lblNextTurn";
            this.lblNextTurn.Size = new System.Drawing.Size(70, 26);
            this.lblNextTurn.TabIndex = 1;
            this.lblNextTurn.Text = "label2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(274, 77);
            this.button1.TabIndex = 2;
            this.button1.Text = "Llamar Turno";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 258);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblNextTurn);
            this.Controls.Add(this.lblCurrentTurn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCurrentTurn;
        private System.Windows.Forms.Label lblNextTurn;
        private System.Windows.Forms.Button button1;
    }
}

