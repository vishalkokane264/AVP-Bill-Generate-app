namespace AVP.src
{
    partial class Dashboard
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
            this.viewRecordButton = new System.Windows.Forms.Button();
            this.editSlipButton = new System.Windows.Forms.Button();
            this.printSlipButton = new System.Windows.Forms.Button();
            this.generateSlipButton = new System.Windows.Forms.Button();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.middlePanel = new System.Windows.Forms.Panel();
            this.printSlip1 = new AVP.src.PrintSlip();
            this.viewRecordsUC1 = new AVP.src.ViewRecordsUC();
            this.editSlipUC1 = new AVP.src.EditSlipUC();
            this.createRecordUC1 = new AVP.src.CreateRecordUC();
            this.reloadDatabase = new System.Windows.Forms.Button();
            this.leftPanel.SuspendLayout();
            this.middlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // viewRecordButton
            // 
            this.viewRecordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewRecordButton.Location = new System.Drawing.Point(23, 52);
            this.viewRecordButton.Name = "viewRecordButton";
            this.viewRecordButton.Size = new System.Drawing.Size(153, 42);
            this.viewRecordButton.TabIndex = 0;
            this.viewRecordButton.Text = "View Records";
            this.viewRecordButton.UseVisualStyleBackColor = true;
            this.viewRecordButton.Click += new System.EventHandler(this.ViewRecordButton_Click);
            // 
            // editSlipButton
            // 
            this.editSlipButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editSlipButton.Location = new System.Drawing.Point(23, 172);
            this.editSlipButton.Name = "editSlipButton";
            this.editSlipButton.Size = new System.Drawing.Size(153, 40);
            this.editSlipButton.TabIndex = 2;
            this.editSlipButton.Text = "Edit Slip";
            this.editSlipButton.UseVisualStyleBackColor = true;
            this.editSlipButton.Click += new System.EventHandler(this.EditSlipButton_Click);
            // 
            // printSlipButton
            // 
            this.printSlipButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printSlipButton.Location = new System.Drawing.Point(23, 229);
            this.printSlipButton.Name = "printSlipButton";
            this.printSlipButton.Size = new System.Drawing.Size(153, 40);
            this.printSlipButton.TabIndex = 3;
            this.printSlipButton.Text = "Print Slip";
            this.printSlipButton.UseVisualStyleBackColor = true;
            this.printSlipButton.Click += new System.EventHandler(this.PrintSlipButton_Click);
            // 
            // generateSlipButton
            // 
            this.generateSlipButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateSlipButton.Location = new System.Drawing.Point(23, 111);
            this.generateSlipButton.Name = "generateSlipButton";
            this.generateSlipButton.Size = new System.Drawing.Size(153, 40);
            this.generateSlipButton.TabIndex = 4;
            this.generateSlipButton.Text = "Generate New Slip";
            this.generateSlipButton.UseVisualStyleBackColor = true;
            this.generateSlipButton.Click += new System.EventHandler(this.GenerateSlipButton_Click);
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.reloadDatabase);
            this.leftPanel.Controls.Add(this.viewRecordButton);
            this.leftPanel.Controls.Add(this.generateSlipButton);
            this.leftPanel.Controls.Add(this.editSlipButton);
            this.leftPanel.Controls.Add(this.printSlipButton);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(201, 687);
            this.leftPanel.TabIndex = 6;
            // 
            // middlePanel
            // 
            this.middlePanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.middlePanel.Controls.Add(this.printSlip1);
            this.middlePanel.Controls.Add(this.viewRecordsUC1);
            this.middlePanel.Controls.Add(this.editSlipUC1);
            this.middlePanel.Controls.Add(this.createRecordUC1);
            this.middlePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.middlePanel.Location = new System.Drawing.Point(201, 0);
            this.middlePanel.MaximumSize = new System.Drawing.Size(807, 687);
            this.middlePanel.MinimumSize = new System.Drawing.Size(807, 687);
            this.middlePanel.Name = "middlePanel";
            this.middlePanel.Size = new System.Drawing.Size(807, 687);
            this.middlePanel.TabIndex = 8;
            // 
            // printSlip1
            // 
            this.printSlip1.Location = new System.Drawing.Point(0, 0);
            this.printSlip1.MaximumSize = new System.Drawing.Size(807, 687);
            this.printSlip1.MinimumSize = new System.Drawing.Size(807, 687);
            this.printSlip1.Name = "printSlip1";
            this.printSlip1.Size = new System.Drawing.Size(807, 687);
            this.printSlip1.TabIndex = 3;
            // 
            // viewRecordsUC1
            // 
            this.viewRecordsUC1.Location = new System.Drawing.Point(0, 0);
            this.viewRecordsUC1.MaximumSize = new System.Drawing.Size(807, 687);
            this.viewRecordsUC1.MinimumSize = new System.Drawing.Size(807, 687);
            this.viewRecordsUC1.Name = "viewRecordsUC1";
            this.viewRecordsUC1.Size = new System.Drawing.Size(807, 687);
            this.viewRecordsUC1.TabIndex = 2;
            // 
            // editSlipUC1
            // 
            this.editSlipUC1.Location = new System.Drawing.Point(0, 0);
            this.editSlipUC1.MaximumSize = new System.Drawing.Size(807, 687);
            this.editSlipUC1.MinimumSize = new System.Drawing.Size(807, 687);
            this.editSlipUC1.Name = "editSlipUC1";
            this.editSlipUC1.Size = new System.Drawing.Size(807, 687);
            this.editSlipUC1.TabIndex = 1;
            // 
            // createRecordUC1
            // 
            this.createRecordUC1.Location = new System.Drawing.Point(0, 3);
            this.createRecordUC1.MaximumSize = new System.Drawing.Size(807, 687);
            this.createRecordUC1.MinimumSize = new System.Drawing.Size(807, 687);
            this.createRecordUC1.Name = "createRecordUC1";
            this.createRecordUC1.Size = new System.Drawing.Size(807, 687);
            this.createRecordUC1.TabIndex = 0;
            // 
            // reloadDatabase
            // 
            this.reloadDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reloadDatabase.Location = new System.Drawing.Point(23, 289);
            this.reloadDatabase.Name = "reloadDatabase";
            this.reloadDatabase.Size = new System.Drawing.Size(153, 40);
            this.reloadDatabase.TabIndex = 5;
            this.reloadDatabase.Text = "Reload Database";
            this.reloadDatabase.UseVisualStyleBackColor = true;
            this.reloadDatabase.Click += new System.EventHandler(this.ReloadDatabase_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 687);
            this.Controls.Add(this.middlePanel);
            this.Controls.Add(this.leftPanel);
            this.MaximumSize = new System.Drawing.Size(1024, 768);
            this.MinimumSize = new System.Drawing.Size(1024, 726);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.leftPanel.ResumeLayout(false);
            this.middlePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button viewRecordButton;
        private System.Windows.Forms.Button editSlipButton;
        private System.Windows.Forms.Button printSlipButton;
        private System.Windows.Forms.Button generateSlipButton;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel middlePanel;
        private ViewRecordsUC viewRecordsUC1;
        private EditSlipUC editSlipUC1;
        private CreateRecordUC createRecordUC1;
        private PrintSlip printSlip1;
        private System.Windows.Forms.Button reloadDatabase;
    }
}