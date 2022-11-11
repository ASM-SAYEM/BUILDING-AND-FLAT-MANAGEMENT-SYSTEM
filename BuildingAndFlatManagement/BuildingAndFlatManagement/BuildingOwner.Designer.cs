namespace BuildingAndFlatManagement
{
    partial class FormBuildingOwner
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
            this.lblOName = new System.Windows.Forms.Label();
            this.lblOPhone = new System.Windows.Forms.Label();
            this.lblOEmail = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.ShowOwnerDetails = new System.Windows.Forms.DataGridView();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.lblSN = new System.Windows.Forms.Label();
            this.txtSN = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ShowOwnerDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOName
            // 
            this.lblOName.AutoSize = true;
            this.lblOName.Location = new System.Drawing.Point(73, 97);
            this.lblOName.Name = "lblOName";
            this.lblOName.Size = new System.Drawing.Size(46, 16);
            this.lblOName.TabIndex = 0;
            this.lblOName.Text = "NAME";
            // 
            // lblOPhone
            // 
            this.lblOPhone.AutoSize = true;
            this.lblOPhone.Location = new System.Drawing.Point(64, 147);
            this.lblOPhone.Name = "lblOPhone";
            this.lblOPhone.Size = new System.Drawing.Size(55, 16);
            this.lblOPhone.TabIndex = 1;
            this.lblOPhone.Text = "PHONE";
            // 
            // lblOEmail
            // 
            this.lblOEmail.AutoSize = true;
            this.lblOEmail.Location = new System.Drawing.Point(73, 185);
            this.lblOEmail.Name = "lblOEmail";
            this.lblOEmail.Size = new System.Drawing.Size(46, 16);
            this.lblOEmail.TabIndex = 2;
            this.lblOEmail.Text = "EMAIL";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(46, 232);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(73, 16);
            this.lblAddress.TabIndex = 3;
            this.lblAddress.Text = "ADDRESS";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(137, 97);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 4;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(137, 147);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 22);
            this.txtPhone.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(137, 185);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 22);
            this.txtEmail.TabIndex = 6;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(137, 232);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 22);
            this.txtAddress.TabIndex = 7;
            // 
            // ShowOwnerDetails
            // 
            this.ShowOwnerDetails.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.ShowOwnerDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShowOwnerDetails.Location = new System.Drawing.Point(319, 54);
            this.ShowOwnerDetails.Name = "ShowOwnerDetails";
            this.ShowOwnerDetails.RowHeadersWidth = 51;
            this.ShowOwnerDetails.RowTemplate.Height = 24;
            this.ShowOwnerDetails.Size = new System.Drawing.Size(447, 457);
            this.ShowOwnerDetails.TabIndex = 8;
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(57, 331);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(89, 51);
            this.btnInsert.TabIndex = 9;
            this.btnInsert.Text = "INSERT";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(185, 331);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(89, 51);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(57, 393);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(89, 54);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(185, 393);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(89, 54);
            this.btnShow.TabIndex = 12;
            this.btnShow.Text = "SHOW";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(185, 453);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(89, 53);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(57, 453);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(89, 58);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(54, 281);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(65, 16);
            this.lblGender.TabIndex = 15;
            this.lblGender.Text = "GENDER";
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(137, 275);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(100, 22);
            this.txtGender.TabIndex = 16;
            // 
            // lblSN
            // 
            this.lblSN.AutoSize = true;
            this.lblSN.Location = new System.Drawing.Point(54, 60);
            this.lblSN.Name = "lblSN";
            this.lblSN.Size = new System.Drawing.Size(77, 16);
            this.lblSN.TabIndex = 17;
            this.lblSN.Text = "SERIAL NO";
            // 
            // txtSN
            // 
            this.txtSN.Location = new System.Drawing.Point(137, 54);
            this.txtSN.Name = "txtSN";
            this.txtSN.Size = new System.Drawing.Size(100, 22);
            this.txtSN.TabIndex = 18;
            // 
            // FormBuildingOwner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::BuildingAndFlatManagement.Properties.Resources.own;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(853, 523);
            this.Controls.Add(this.txtSN);
            this.Controls.Add(this.lblSN);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.ShowOwnerDetails);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblOEmail);
            this.Controls.Add(this.lblOPhone);
            this.Controls.Add(this.lblOName);
            this.Name = "FormBuildingOwner";
            this.Text = "BuildingOwner";
            ((System.ComponentModel.ISupportInitialize)(this.ShowOwnerDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOName;
        private System.Windows.Forms.Label lblOPhone;
        private System.Windows.Forms.Label lblOEmail;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.DataGridView ShowOwnerDetails;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.Label lblSN;
        private System.Windows.Forms.TextBox txtSN;
    }
}