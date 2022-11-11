namespace BuildingAndFlatManagement
{
    partial class FormDASHBOARD
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
            this.btnBOwner = new System.Windows.Forms.Button();
            this.btnTenant = new System.Windows.Forms.Button();
            this.btnFSold = new System.Windows.Forms.Button();
            this.btnBDetails = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBOwner
            // 
            this.btnBOwner.BackColor = System.Drawing.SystemColors.Info;
            this.btnBOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBOwner.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBOwner.Location = new System.Drawing.Point(199, 22);
            this.btnBOwner.Name = "btnBOwner";
            this.btnBOwner.Size = new System.Drawing.Size(265, 58);
            this.btnBOwner.TabIndex = 0;
            this.btnBOwner.Text = "BUILDING\r\n OWNER";
            this.btnBOwner.UseVisualStyleBackColor = false;
            this.btnBOwner.Click += new System.EventHandler(this.btnBOwner_Click);
            // 
            // btnTenant
            // 
            this.btnTenant.BackColor = System.Drawing.SystemColors.Info;
            this.btnTenant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTenant.Location = new System.Drawing.Point(199, 127);
            this.btnTenant.Name = "btnTenant";
            this.btnTenant.Size = new System.Drawing.Size(265, 66);
            this.btnTenant.TabIndex = 1;
            this.btnTenant.Text = "TENANT";
            this.btnTenant.UseVisualStyleBackColor = false;
            this.btnTenant.Click += new System.EventHandler(this.btnTenant_Click);
            // 
            // btnFSold
            // 
            this.btnFSold.BackColor = System.Drawing.SystemColors.Info;
            this.btnFSold.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFSold.Location = new System.Drawing.Point(199, 239);
            this.btnFSold.Name = "btnFSold";
            this.btnFSold.Size = new System.Drawing.Size(265, 70);
            this.btnFSold.TabIndex = 2;
            this.btnFSold.Text = "FLAT SOLD";
            this.btnFSold.UseVisualStyleBackColor = false;
            this.btnFSold.Click += new System.EventHandler(this.btnFSold_Click);
            // 
            // btnBDetails
            // 
            this.btnBDetails.BackColor = System.Drawing.SystemColors.Info;
            this.btnBDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBDetails.Location = new System.Drawing.Point(199, 361);
            this.btnBDetails.Name = "btnBDetails";
            this.btnBDetails.Size = new System.Drawing.Size(265, 64);
            this.btnBDetails.TabIndex = 3;
            this.btnBDetails.Text = "BUILDING\r\n DETAILS";
            this.btnBDetails.UseVisualStyleBackColor = false;
            this.btnBDetails.Click += new System.EventHandler(this.btnFDetails_Click);
            // 
            // FormDASHBOARD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BuildingAndFlatManagement.Properties.Resources.focused_welcome_text_animation_02;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(780, 450);
            this.Controls.Add(this.btnBDetails);
            this.Controls.Add(this.btnFSold);
            this.Controls.Add(this.btnTenant);
            this.Controls.Add(this.btnBOwner);
            this.Name = "FormDASHBOARD";
            this.Text = "DASHBOARD";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBOwner;
        private System.Windows.Forms.Button btnTenant;
        private System.Windows.Forms.Button btnFSold;
        private System.Windows.Forms.Button btnBDetails;
    }
}