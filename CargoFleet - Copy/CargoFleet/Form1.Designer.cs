namespace CargoFleet
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
            this.btnOfficeManager = new System.Windows.Forms.Button();
            this.btnTripManager = new System.Windows.Forms.Button();
            this.btnServiceManager = new System.Windows.Forms.Button();
            this.btnTimesheet = new System.Windows.Forms.Button();
            this.btnVehicleInformation = new System.Windows.Forms.Button();
            this.btnDriver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOfficeManager
            // 
            this.btnOfficeManager.Location = new System.Drawing.Point(301, 35);
            this.btnOfficeManager.Name = "btnOfficeManager";
            this.btnOfficeManager.Size = new System.Drawing.Size(162, 62);
            this.btnOfficeManager.TabIndex = 0;
            this.btnOfficeManager.Text = "Office Manager ";
            this.btnOfficeManager.UseVisualStyleBackColor = true;
            this.btnOfficeManager.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTripManager
            // 
            this.btnTripManager.Location = new System.Drawing.Point(301, 204);
            this.btnTripManager.Name = "btnTripManager";
            this.btnTripManager.Size = new System.Drawing.Size(162, 62);
            this.btnTripManager.TabIndex = 1;
            this.btnTripManager.Text = "Trip/Usage Manager";
            this.btnTripManager.UseVisualStyleBackColor = true;
            this.btnTripManager.Click += new System.EventHandler(this.btnTripManager_Click);
            // 
            // btnServiceManager
            // 
            this.btnServiceManager.Location = new System.Drawing.Point(301, 290);
            this.btnServiceManager.Name = "btnServiceManager";
            this.btnServiceManager.Size = new System.Drawing.Size(162, 62);
            this.btnServiceManager.TabIndex = 2;
            this.btnServiceManager.Text = "Service Manager ";
            this.btnServiceManager.UseVisualStyleBackColor = true;
            this.btnServiceManager.Click += new System.EventHandler(this.btnServiceManager_Click);
            // 
            // btnTimesheet
            // 
            this.btnTimesheet.Location = new System.Drawing.Point(301, 379);
            this.btnTimesheet.Name = "btnTimesheet";
            this.btnTimesheet.Size = new System.Drawing.Size(162, 62);
            this.btnTimesheet.TabIndex = 3;
            this.btnTimesheet.Text = "Timesheet Manager";
            this.btnTimesheet.UseVisualStyleBackColor = true;
            this.btnTimesheet.Click += new System.EventHandler(this.btnTimesheet_Click);
            // 
            // btnVehicleInformation
            // 
            this.btnVehicleInformation.Location = new System.Drawing.Point(301, 124);
            this.btnVehicleInformation.Name = "btnVehicleInformation";
            this.btnVehicleInformation.Size = new System.Drawing.Size(162, 62);
            this.btnVehicleInformation.TabIndex = 4;
            this.btnVehicleInformation.Text = "Vehicle Information Administrator ";
            this.btnVehicleInformation.UseVisualStyleBackColor = true;
            this.btnVehicleInformation.Click += new System.EventHandler(this.btnVehicleInformation_Click);
            // 
            // btnDriver
            // 
            this.btnDriver.Location = new System.Drawing.Point(301, 464);
            this.btnDriver.Name = "btnDriver";
            this.btnDriver.Size = new System.Drawing.Size(162, 62);
            this.btnDriver.TabIndex = 5;
            this.btnDriver.Text = "Driver";
            this.btnDriver.UseVisualStyleBackColor = true;
            this.btnDriver.Click += new System.EventHandler(this.btnDriver_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 579);
            this.Controls.Add(this.btnDriver);
            this.Controls.Add(this.btnVehicleInformation);
            this.Controls.Add(this.btnTimesheet);
            this.Controls.Add(this.btnServiceManager);
            this.Controls.Add(this.btnTripManager);
            this.Controls.Add(this.btnOfficeManager);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOfficeManager;
        private System.Windows.Forms.Button btnTripManager;
        private System.Windows.Forms.Button btnServiceManager;
        private System.Windows.Forms.Button btnTimesheet;
        private System.Windows.Forms.Button btnVehicleInformation;
        private System.Windows.Forms.Button btnDriver;
    }
}

