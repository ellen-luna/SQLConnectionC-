namespace ConnectingToMySQL
{
    partial class FrmConnectionMonitor
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblIP = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.dtGridDevice = new System.Windows.Forms.DataGridView();
            this.lblDeviceStatus = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button4 = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.Button();
            this.bntExportToExcel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridDevice)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(338, 413);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "Test SQL Connection";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblIP);
            this.groupBox1.Controls.Add(this.txtIP);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(16, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(513, 362);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New IP";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(197, 253);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(203, 67);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(394, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 40);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIP.Location = new System.Drawing.Point(50, 107);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(37, 32);
            this.lblIP.TabIndex = 4;
            this.lblIP.Text = "IP";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(197, 102);
            this.txtIP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(185, 39);
            this.txtIP.TabIndex = 1;
            // 
            // dtGridDevice
            // 
            this.dtGridDevice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridDevice.Location = new System.Drawing.Point(17, 546);
            this.dtGridDevice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtGridDevice.Name = "dtGridDevice";
            this.dtGridDevice.RowHeadersWidth = 62;
            this.dtGridDevice.RowTemplate.Height = 41;
            this.dtGridDevice.Size = new System.Drawing.Size(511, 676);
            this.dtGridDevice.TabIndex = 2;
            // 
            // lblDeviceStatus
            // 
            this.lblDeviceStatus.AutoSize = true;
            this.lblDeviceStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDeviceStatus.Location = new System.Drawing.Point(21, 509);
            this.lblDeviceStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeviceStatus.Name = "lblDeviceStatus";
            this.lblDeviceStatus.Size = new System.Drawing.Size(166, 32);
            this.lblDeviceStatus.TabIndex = 3;
            this.lblDeviceStatus.Text = "Device Status";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button3.Location = new System.Drawing.Point(410, 477);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 52);
            this.button3.TabIndex = 4;
            this.button3.Text = "Refresh";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(243, 486);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(155, 34);
            this.button4.TabIndex = 5;
            this.button4.Text = "Slq Connect 2";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(32, 429);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(159, 42);
            this.txtEmail.TabIndex = 6;
            this.txtEmail.Text = "Email";
            this.txtEmail.UseVisualStyleBackColor = true;
            this.txtEmail.Click += new System.EventHandler(this.txtEmail_Click);
            // 
            // bntExportToExcel
            // 
            this.bntExportToExcel.Location = new System.Drawing.Point(32, 471);
            this.bntExportToExcel.Name = "bntExportToExcel";
            this.bntExportToExcel.Size = new System.Drawing.Size(159, 39);
            this.bntExportToExcel.TabIndex = 7;
            this.bntExportToExcel.Text = "Export To Excel";
            this.bntExportToExcel.UseVisualStyleBackColor = true;
            this.bntExportToExcel.Click += new System.EventHandler(this.bntExportToExcel_Click);
            // 
            // FrmConnectionMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 1050);
            this.Controls.Add(this.bntExportToExcel);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lblDeviceStatus);
            this.Controls.Add(this.dtGridDevice);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmConnectionMonitor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monitor Server Connection";
            this.Load += new System.EventHandler(this.FrmConnectionMonitor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridDevice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private GroupBox groupBox1;
        private Button txtEmail;
        private Button btnSave;
        private Label lblIP;
        private TextBox txtIP;
        private DataGridView dtGridDevice;
        private Label lblDeviceStatus;
        private Button button3;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private Button button4;
        private Button bntExportToExcel;
    }
}