namespace BuildingAndFlatManagement
{
    partial class FormTenant
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
            this.txtGender = new System.Windows.Forms.TextBox();
            this.lblTGender = new System.Windows.Forms.Label();
            this.btnTBack = new System.Windows.Forms.Button();
            this.btnTExit = new System.Windows.Forms.Button();
            this.btnTShow = new System.Windows.Forms.Button();
            this.btnTDelete = new System.Windows.Forms.Button();
            this.btnTUpdate = new System.Windows.Forms.Button();
            this.btnTInsert = new System.Windows.Forms.Button();
            this.ShowOwnerDetails = new System.Windows.Forms.DataGridView();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblTAddress = new System.Windows.Forms.Label();
            this.lblTEmail = new System.Windows.Forms.Label();
            this.lblTName = new System.Windows.Forms.Label();
            this.lblTPhone = new System.Windows.Forms.Label();
            this.lblRent = new System.Windows.Forms.Label();
            this.lblBlock = new System.Windows.Forms.Label();
            this.txtRent = new System.Windows.Forms.TextBox();
            this.txtBlock = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ShowOwnerDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(211, 215);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(100, 22);
            this.txtGender.TabIndex = 32;
            // 
            // lblTGender
            // 
            this.lblTGender.AutoSize = true;
            this.lblTGender.Location = new System.Drawing.Point(125, 215);
            this.lblTGender.Name = "lblTGender";
            this.lblTGender.Size = new System.Drawing.Size(65, 16);
            this.lblTGender.TabIndex = 31;
            this.lblTGender.Text = "GENDER";
            // 
            // btnTBack
            // 
            this.btnTBack.Location = new System.Drawing.Point(131, 511);
            this.btnTBack.Name = "btnTBack";
            this.btnTBack.Size = new System.Drawing.Size(75, 23);
            this.btnTBack.TabIndex = 30;
            this.btnTBack.Text = "BACK";
            this.btnTBack.UseVisualStyleBackColor = true;
            this.btnTBack.Click += new System.EventHandler(this.btnTBack_Click);
            // 
            // btnTExit
            // 
            this.btnTExit.Location = new System.Drawing.Point(259, 511);
            this.btnTExit.Name = "btnTExit";
            this.btnTExit.Size = new System.Drawing.Size(75, 23);
            this.btnTExit.TabIndex = 29;
            this.btnTExit.Text = "EXIT";
            this.btnTExit.UseVisualStyleBackColor = true;
            this.btnTExit.Click += new System.EventHandler(this.btnTExit_Click);
            // 
            // btnTShow
            // 
            this.btnTShow.Location = new System.Drawing.Point(259, 473);
            this.btnTShow.Name = "btnTShow";
            this.btnTShow.Size = new System.Drawing.Size(75, 23);
            this.btnTShow.TabIndex = 28;
            this.btnTShow.Text = "SHOW";
            this.btnTShow.UseVisualStyleBackColor = true;
            this.btnTShow.Click += new System.EventHandler(this.btnTShow_Click);
            // 
            // btnTDelete
            // 
            this.btnTDelete.Location = new System.Drawing.Point(131, 473);
            this.btnTDelete.Name = "btnTDelete";
            this.btnTDelete.Size = new System.Drawing.Size(75, 23);
            this.btnTDelete.TabIndex = 27;
            this.btnTDelete.Text = "DELETE";
            this.btnTDelete.UseVisualStyleBackColor = true;
            this.btnTDelete.Click += new System.EventHandler(this.btnTDelete_Click);
            // 
            // btnTUpdate
            // 
            this.btnTUpdate.Location = new System.Drawing.Point(259, 435);
            this.btnTUpdate.Name = "btnTUpdate";
            this.btnTUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnTUpdate.TabIndex = 26;
            this.btnTUpdate.Text = "UPDATE";
            this.btnTUpdate.UseVisualStyleBackColor = true;
            this.btnTUpdate.Click += new System.EventHandler(this.btnTUpdate_Click);
            // 
            // btnTInsert
            // 
            this.btnTInsert.Location = new System.Drawing.Point(128, 435);
            this.btnTInsert.Name = "btnTInsert";
            this.btnTInsert.Size = new System.Drawing.Size(75, 23);
            this.btnTInsert.TabIndex = 25;
            this.btnTInsert.Text = "INSERT";
            this.btnTInsert.UseVisualStyleBackColor = true;
            this.btnTInsert.Click += new System.EventHandler(this.btnTInsert_Click);
            // 
            // ShowOwnerDetails
            // 
            this.ShowOwnerDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShowOwnerDetails.Location = new System.Drawing.Point(409, 39);
            this.ShowOwnerDetails.Name = "ShowOwnerDetails";
            this.ShowOwnerDetails.RowHeadersWidth = 51;
            this.ShowOwnerDetails.RowTemplate.Height = 24;
            this.ShowOwnerDetails.Size = new System.Drawing.Size(637, 495);
            this.ShowOwnerDetails.TabIndex = 24;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(211, 167);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 22);
            this.txtAddress.TabIndex = 23;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(211, 123);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 22);
            this.txtEmail.TabIndex = 22;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(211, 86);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 22);
            this.txtPhone.TabIndex = 21;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(211, 53);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 20;
            // 
            // lblTAddress
            // 
            this.lblTAddress.AutoSize = true;
            this.lblTAddress.Location = new System.Drawing.Point(125, 167);
            this.lblTAddress.Name = "lblTAddress";
            this.lblTAddress.Size = new System.Drawing.Size(73, 16);
            this.lblTAddress.TabIndex = 19;
            this.lblTAddress.Text = "ADDRESS";
            // 
            // lblTEmail
            // 
            this.lblTEmail.AutoSize = true;
            this.lblTEmail.Location = new System.Drawing.Point(128, 123);
            this.lblTEmail.Name = "lblTEmail";
            this.lblTEmail.Size = new System.Drawing.Size(46, 16);
            this.lblTEmail.TabIndex = 18;
            this.lblTEmail.Text = "EMAIL";
            // 
            // lblTName
            // 
            this.lblTName.AutoSize = true;
            this.lblTName.Location = new System.Drawing.Point(128, 56);
            this.lblTName.Name = "lblTName";
            this.lblTName.Size = new System.Drawing.Size(46, 16);
            this.lblTName.TabIndex = 17;
            this.lblTName.Text = "NAME";
            // 
            // lblTPhone
            // 
            this.lblTPhone.AutoSize = true;
            this.lblTPhone.Location = new System.Drawing.Point(128, 92);
            this.lblTPhone.Name = "lblTPhone";
            this.lblTPhone.Size = new System.Drawing.Size(55, 16);
            this.lblTPhone.TabIndex = 33;
            this.lblTPhone.Text = "PHONE";
            // 
            // lblRent
            // 
            this.lblRent.AutoSize = true;
            this.lblRent.Location = new System.Drawing.Point(140, 253);
            this.lblRent.Name = "lblRent";
            this.lblRent.Size = new System.Drawing.Size(45, 16);
            this.lblRent.TabIndex = 34;
            this.lblRent.Text = "RENT";
            // 
            // lblBlock
            // 
            this.lblBlock.AutoSize = true;
            this.lblBlock.Location = new System.Drawing.Point(140, 295);
            this.lblBlock.Name = "lblBlock";
            this.lblBlock.Size = new System.Drawing.Size(50, 16);
            this.lblBlock.TabIndex = 35;
            this.lblBlock.Text = "BLOCK";
            this.lblBlock.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtRent
            // 
            this.txtRent.Location = new System.Drawing.Point(211, 250);
            this.txtRent.Name = "txtRent";
            this.txtRent.Size = new System.Drawing.Size(100, 22);
            this.txtRent.TabIndex = 37;
            // 
            // txtBlock
            // 
            this.txtBlock.Location = new System.Drawing.Point(211, 292);
            this.txtBlock.Name = "txtBlock";
            this.txtBlock.Size = new System.Drawing.Size(100, 22);
            this.txtBlock.TabIndex = 38;
            // 
            // FormTenant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 555);
            this.Controls.Add(this.txtBlock);
            this.Controls.Add(this.txtRent);
            this.Controls.Add(this.lblBlock);
            this.Controls.Add(this.lblRent);
            this.Controls.Add(this.lblTPhone);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.lblTGender);
            this.Controls.Add(this.btnTBack);
            this.Controls.Add(this.btnTExit);
            this.Controls.Add(this.btnTShow);
            this.Controls.Add(this.btnTDelete);
            this.Controls.Add(this.btnTUpdate);
            this.Controls.Add(this.btnTInsert);
            this.Controls.Add(this.ShowOwnerDetails);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblTAddress);
            this.Controls.Add(this.lblTEmail);
            this.Controls.Add(this.lblTName);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FormTenant";
            this.Text = "TENANT";
            ((System.ComponentModel.ISupportInitialize)(this.ShowOwnerDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.Label lblTGender;
        private System.Windows.Forms.Button btnTBack;
        private System.Windows.Forms.Button btnTExit;
        private System.Windows.Forms.Button btnTShow;
        private System.Windows.Forms.Button btnTDelete;
        private System.Windows.Forms.Button btnTUpdate;
        private System.Windows.Forms.Button btnTInsert;
        private System.Windows.Forms.DataGridView ShowOwnerDetails;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblTAddress;
        private System.Windows.Forms.Label lblTEmail;
        private System.Windows.Forms.Label lblTName;
        private System.Windows.Forms.Label lblTPhone;
        private System.Windows.Forms.Label lblRent;
        private System.Windows.Forms.Label lblBlock;
        private System.Windows.Forms.TextBox txtRent;
        private System.Windows.Forms.TextBox txtBlock;
    }
}