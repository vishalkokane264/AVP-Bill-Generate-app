namespace AVP.src
{
    partial class FormSubmission
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.appNoLbl = new System.Windows.Forms.Label();
            this.printNowButton = new System.Windows.Forms.Button();
            this.printLaterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(31, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your Application Submitted Successfully";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(28, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Application Number:";
            // 
            // appNoLbl
            // 
            this.appNoLbl.AutoSize = true;
            this.appNoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appNoLbl.Location = new System.Drawing.Point(215, 82);
            this.appNoLbl.Name = "appNoLbl";
            this.appNoLbl.Size = new System.Drawing.Size(0, 22);
            this.appNoLbl.TabIndex = 2;
            // 
            // printNowButton
            // 
            this.printNowButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printNowButton.Location = new System.Drawing.Point(103, 121);
            this.printNowButton.Name = "printNowButton";
            this.printNowButton.Size = new System.Drawing.Size(104, 30);
            this.printNowButton.TabIndex = 3;
            this.printNowButton.Text = "Print Now";
            this.printNowButton.UseVisualStyleBackColor = true;
            this.printNowButton.Click += new System.EventHandler(this.PrintNowButton_Click);
            // 
            // printLaterButton
            // 
            this.printLaterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printLaterButton.Location = new System.Drawing.Point(215, 121);
            this.printLaterButton.Name = "printLaterButton";
            this.printLaterButton.Size = new System.Drawing.Size(104, 30);
            this.printLaterButton.TabIndex = 4;
            this.printLaterButton.Text = "Print Later";
            this.printLaterButton.UseVisualStyleBackColor = true;
            this.printLaterButton.Click += new System.EventHandler(this.PrintLaterButton_Click);
            // 
            // FormSubmission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 187);
            this.Controls.Add(this.printLaterButton);
            this.Controls.Add(this.printNowButton);
            this.Controls.Add(this.appNoLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(443, 226);
            this.MinimumSize = new System.Drawing.Size(443, 226);
            this.Name = "FormSubmission";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSubmission";
            this.Load += new System.EventHandler(this.FormSubmission_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label appNoLbl;
        private System.Windows.Forms.Button printNowButton;
        private System.Windows.Forms.Button printLaterButton;
    }
}