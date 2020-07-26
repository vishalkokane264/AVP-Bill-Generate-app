namespace AVP.src
{
    partial class ViewRecordsUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.searchByName = new System.Windows.Forms.RadioButton();
            this.searchById = new System.Windows.Forms.RadioButton();
            this.firstName = new System.Windows.Forms.TextBox();
            this.applicationId = new System.Windows.Forms.TextBox();
            this.last25RecRadio = new System.Windows.Forms.RadioButton();
            this.last10RecRadio = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.searchByName);
            this.groupBox1.Controls.Add(this.searchById);
            this.groupBox1.Controls.Add(this.firstName);
            this.groupBox1.Controls.Add(this.applicationId);
            this.groupBox1.Controls.Add(this.last25RecRadio);
            this.groupBox1.Controls.Add(this.last10RecRadio);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(21, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(763, 203);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(21, 247);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(767, 415);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(749, 344);
            this.dataGridView1.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(595, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 125);
            this.button1.TabIndex = 30;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // searchByName
            // 
            this.searchByName.AutoSize = true;
            this.searchByName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchByName.Location = new System.Drawing.Point(255, 140);
            this.searchByName.Name = "searchByName";
            this.searchByName.Size = new System.Drawing.Size(161, 24);
            this.searchByName.TabIndex = 29;
            this.searchByName.TabStop = true;
            this.searchByName.Text = "Find By First Name";
            this.searchByName.UseVisualStyleBackColor = true;
            this.searchByName.CheckedChanged += new System.EventHandler(this.SearchByName_CheckedChanged_1);
            // 
            // searchById
            // 
            this.searchById.AutoSize = true;
            this.searchById.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchById.Location = new System.Drawing.Point(255, 106);
            this.searchById.Name = "searchById";
            this.searchById.Size = new System.Drawing.Size(183, 24);
            this.searchById.TabIndex = 28;
            this.searchById.TabStop = true;
            this.searchById.Text = "View By Application Id";
            this.searchById.UseVisualStyleBackColor = true;
            this.searchById.CheckedChanged += new System.EventHandler(this.SearchById_CheckedChanged_1);
            // 
            // firstName
            // 
            this.firstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstName.Location = new System.Drawing.Point(445, 139);
            this.firstName.MaxLength = 100;
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(128, 26);
            this.firstName.TabIndex = 27;
            // 
            // applicationId
            // 
            this.applicationId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applicationId.Location = new System.Drawing.Point(444, 104);
            this.applicationId.MaxLength = 100;
            this.applicationId.Name = "applicationId";
            this.applicationId.Size = new System.Drawing.Size(128, 26);
            this.applicationId.TabIndex = 26;
            // 
            // last25RecRadio
            // 
            this.last25RecRadio.AutoSize = true;
            this.last25RecRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.last25RecRadio.Location = new System.Drawing.Point(255, 73);
            this.last25RecRadio.Name = "last25RecRadio";
            this.last25RecRadio.Size = new System.Drawing.Size(144, 24);
            this.last25RecRadio.TabIndex = 25;
            this.last25RecRadio.TabStop = true;
            this.last25RecRadio.Text = "Last 25 Records";
            this.last25RecRadio.UseVisualStyleBackColor = true;
            this.last25RecRadio.CheckedChanged += new System.EventHandler(this.Last25RecRadio_CheckedChanged_1);
            // 
            // last10RecRadio
            // 
            this.last10RecRadio.AutoSize = true;
            this.last10RecRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.last10RecRadio.Location = new System.Drawing.Point(255, 40);
            this.last10RecRadio.Name = "last10RecRadio";
            this.last10RecRadio.Size = new System.Drawing.Size(137, 24);
            this.last10RecRadio.TabIndex = 24;
            this.last10RecRadio.TabStop = true;
            this.last10RecRadio.Text = "Last 10 records";
            this.last10RecRadio.UseVisualStyleBackColor = true;
            this.last10RecRadio.CheckedChanged += new System.EventHandler(this.Last10RecRadio_CheckedChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = " View Records By";
            // 
            // ViewRecordsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(807, 687);
            this.MinimumSize = new System.Drawing.Size(807, 687);
            this.Name = "ViewRecordsUC";
            this.Size = new System.Drawing.Size(807, 687);
            this.Load += new System.EventHandler(this.ViewRecordsUC_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton searchByName;
        private System.Windows.Forms.RadioButton searchById;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.TextBox applicationId;
        private System.Windows.Forms.RadioButton last25RecRadio;
        private System.Windows.Forms.RadioButton last10RecRadio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
