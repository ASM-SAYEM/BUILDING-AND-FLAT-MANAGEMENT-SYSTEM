namespace BuildingAndFlatManagement
{
    partial class FormBuildingDetails
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
            this.txtBuildingName = new System.Windows.Forms.TextBox();
            this.lblBuildingName = new System.Windows.Forms.Label();
            this.lblPlace = new System.Windows.Forms.Label();
            this.lblTotalFloor = new System.Windows.Forms.Label();
            this.lblTotalArea = new System.Windows.Forms.Label();
            this.lblBAO = new System.Windows.Forms.Label();
            this.txtPlace = new System.Windows.Forms.TextBox();
            this.txtTotalFloor = new System.Windows.Forms.TextBox();
            this.txtTotalArea = new System.Windows.Forms.TextBox();
            this.txtBAO = new System.Windows.Forms.TextBox();
            this.DataGridViewBuildingDetails = new System.Windows.Forms.DataGridView();
            this.btnTBack = new System.Windows.Forms.Button();
            this.btnTExit = new System.Windows.Forms.Button();
            this.btnTShow = new System.Windows.Forms.Button();
            this.btnTDelete = new System.Windows.Forms.Button();
            this.btnTUpdate = new System.Windows.Forms.Button();
            this.btnTInsert = new System.Windows.Forms.Button();
            this.lblBuildingNumber = new System.Windows.Forms.Label();
            this.txtBuildingNumber = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewBuildingDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuildingName
            // 
            this.txtBuildingName.Location = new System.Drawing.Point(238, 42);
            this.txtBuildingName.Name = "txtBuildingName";
            this.txtBuildingName.Size = new System.Drawing.Size(100, 22);
            this.txtBuildingName.TabIndex = 0;
            // 
            // lblBuildingName
            // 
            this.lblBuildingName.AutoSize = true;
            this.lblBuildingName.Location = new System.Drawing.Point(65, 48);
            this.lblBuildingName.Name = "lblBuildingName";
            this.lblBuildingName.Size = new System.Drawing.Size(111, 16);
            this.lblBuildingName.TabIndex = 1;
            this.lblBuildingName.Text = "BUILDING NAME";
            // 
            // lblPlace
            // 
            this.lblPlace.AutoSize = true;
            this.lblPlace.Location = new System.Drawing.Point(68, 87);
            this.lblPlace.Name = "lblPlace";
            this.lblPlace.Size = new System.Drawing.Size(50, 16);
            this.lblPlace.TabIndex = 2;
            this.lblPlace.Text = "PLACE";
            // 
            // lblTotalFloor
            // 
            this.lblTotalFloor.AutoSize = true;
            this.lblTotalFloor.Location = new System.Drawing.Point(68, 128);
            this.lblTotalFloor.Name = "lblTotalFloor";
            this.lblTotalFloor.Size = new System.Drawing.Size(99, 16);
            this.lblTotalFloor.TabIndex = 3;
            this.lblTotalFloor.Text = "TOTAL FLOOR";
            // 
            // lblTotalArea
            // 
            this.lblTotalArea.AutoSize = true;
            this.lblTotalArea.Location = new System.Drawing.Point(71, 164);
            this.lblTotalArea.Name = "lblTotalArea";
            this.lblTotalArea.Size = new System.Drawing.Size(94, 16);
            this.lblTotalArea.TabIndex = 4;
            this.lblTotalArea.Text = "TOTAL AREA ";
            // 
            // lblBAO
            // 
            this.lblBAO.AutoSize = true;
            this.lblBAO.Location = new System.Drawing.Point(71, 201);
            this.lblBAO.Name = "lblBAO";
            this.lblBAO.Size = new System.Drawing.Size(132, 32);
            this.lblBAO.TabIndex = 5;
            this.lblBAO.Text = "BUILDING AZIMUTH\r\nORIENTATION";
            // 
            // txtPlace
            // 
            this.txtPlace.Location = new System.Drawing.Point(238, 80);
            this.txtPlace.Name = "txtPlace";
            this.txtPlace.Size = new System.Drawing.Size(100, 22);
            this.txtPlace.TabIndex = 6;
            // 
            // txtTotalFloor
            // 
            this.txtTotalFloor.Location = new System.Drawing.Point(238, 121);
            this.txtTotalFloor.Name = "txtTotalFloor";
            this.txtTotalFloor.Size = new System.Drawing.Size(100, 22);
            this.txtTotalFloor.TabIndex = 7;
            // 
            // txtTotalArea
            // 
            this.txtTotalArea.Location = new System.Drawing.Point(238, 164);
            this.txtTotalArea.Name = "txtTotalArea";
            this.txtTotalArea.Size = new System.Drawing.Size(100, 22);
            this.txtTotalArea.TabIndex = 8;
            // 
            // txtBAO
            // 
            this.txtBAO.Location = new System.Drawing.Point(238, 210);
            this.txtBAO.Name = "txtBAO";
            this.txtBAO.Size = new System.Drawing.Size(100, 22);
            this.txtBAO.TabIndex = 9;
            // 
            // DataGridViewBuildingDetails
            // 
            this.DataGridViewBuildingDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewBuildingDetails.Location = new System.Drawing.Point(379, 3);
            this.DataGridViewBuildingDetails.Name = "DataGridViewBuildingDetails";
            this.DataGridViewBuildingDetails.RowHeadersWidth = 51;
            this.DataGridViewBuildingDetails.RowTemplate.Height = 24;
            this.DataGridViewBuildingDetails.Size = new System.Drawing.Size(420, 448);
            this.DataGridViewBuildingDetails.TabIndex = 10;
            // 
            // btnTBack
            // 
            this.btnTBack.BackColor = System.Drawing.Color.White;
            this.btnTBack.Location = new System.Drawing.Point(68, 405);
            this.btnTBack.Name = "btnTBack";
            this.btnTBack.Size = new System.Drawing.Size(78, 33);
            this.btnTBack.TabIndex = 36;
            this.btnTBack.Text = "BACK";
            this.btnTBack.UseVisualStyleBackColor = false;
            this.btnTBack.Click += new System.EventHandler(this.btnTBack_Click);
            // 
            // btnTExit
            // 
            this.btnTExit.BackColor = System.Drawing.Color.White;
            this.btnTExit.Location = new System.Drawing.Point(223, 405);
            this.btnTExit.Name = "btnTExit";
            this.btnTExit.Size = new System.Drawing.Size(86, 33);
            this.btnTExit.TabIndex = 35;
            this.btnTExit.Text = "EXIT";
            this.btnTExit.UseVisualStyleBackColor = false;
            this.btnTExit.Click += new System.EventHandler(this.btnTExit_Click);
            // 
            // btnTShow
            // 
            this.btnTShow.BackColor = System.Drawing.Color.White;
            this.btnTShow.Location = new System.Drawing.Point(223, 356);
            this.btnTShow.Name = "btnTShow";
            this.btnTShow.Size = new System.Drawing.Size(86, 34);
            this.btnTShow.TabIndex = 34;
            this.btnTShow.Text = "SHOW";
            this.btnTShow.UseVisualStyleBackColor = false;
            this.btnTShow.Click += new System.EventHandler(this.btnTShow_Click);
            // 
            // btnTDelete
            // 
            this.btnTDelete.BackColor = System.Drawing.Color.White;
            this.btnTDelete.Location = new System.Drawing.Point(223, 300);
            this.btnTDelete.Name = "btnTDelete";
            this.btnTDelete.Size = new System.Drawing.Size(86, 39);
            this.btnTDelete.TabIndex = 33;
            this.btnTDelete.Text = "DELETE ";
            this.btnTDelete.UseVisualStyleBackColor = false;
            this.btnTDelete.Click += new System.EventHandler(this.btnTDelete_Click);
            // 
            // btnTUpdate
            // 
            this.btnTUpdate.BackColor = System.Drawing.Color.White;
            this.btnTUpdate.Location = new System.Drawing.Point(68, 356);
            this.btnTUpdate.Name = "btnTUpdate";
            this.btnTUpdate.Size = new System.Drawing.Size(78, 34);
            this.btnTUpdate.TabIndex = 32;
            this.btnTUpdate.Text = "UPDATE ";
            this.btnTUpdate.UseVisualStyleBackColor = false;
            this.btnTUpdate.Click += new System.EventHandler(this.btnTUpdate_Click);
            // 
            // btnTInsert
            // 
            this.btnTInsert.BackColor = System.Drawing.Color.White;
            this.btnTInsert.Location = new System.Drawing.Point(71, 300);
            this.btnTInsert.Name = "btnTInsert";
            this.btnTInsert.Size = new System.Drawing.Size(75, 39);
            this.btnTInsert.TabIndex = 31;
            this.btnTInsert.Text = "INSERT";
            this.btnTInsert.UseVisualStyleBackColor = false;
            this.btnTInsert.Click += new System.EventHandler(this.btnTInsert_Click);
            // 
            // lblBuildingNumber
            // 
            this.lblBuildingNumber.AutoSize = true;
            this.lblBuildingNumber.Location = new System.Drawing.Point(65, 245);
            this.lblBuildingNumber.Name = "lblBuildingNumber";
            this.lblBuildingNumber.Size = new System.Drawing.Size(131, 16);
            this.lblBuildingNumber.TabIndex = 37;
            this.lblBuildingNumber.Text = "BUILDING NUMBER";
            // 
            // txtBuildingNumber
            // 
            this.txtBuildingNumber.Location = new System.Drawing.Point(238, 245);
            this.txtBuildingNumber.Name = "txtBuildingNumber";
            this.txtBuildingNumber.Size = new System.Drawing.Size(100, 22);
            this.txtBuildingNumber.TabIndex = 38;
            // 
            // FormBuildingDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = global::BuildingAndFlatManagement.Properties.Resources._800px_COLOURBOX31577821;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBuildingNumber);
            this.Controls.Add(this.lblBuildingNumber);
            this.Controls.Add(this.btnTBack);
            this.Controls.Add(this.btnTExit);
            this.Controls.Add(this.btnTShow);
            this.Controls.Add(this.btnTDelete);
            this.Controls.Add(this.btnTUpdate);
            this.Controls.Add(this.btnTInsert);
            this.Controls.Add(this.DataGridViewBuildingDetails);
            this.Controls.Add(this.txtBAO);
            this.Controls.Add(this.txtTotalArea);
            this.Controls.Add(this.txtTotalFloor);
            this.Controls.Add(this.txtPlace);
            this.Controls.Add(this.lblBAO);
            this.Controls.Add(this.lblTotalArea);
            this.Controls.Add(this.lblTotalFloor);
            this.Controls.Add(this.lblPlace);
            this.Controls.Add(this.lblBuildingName);
            this.Controls.Add(this.txtBuildingName);
            this.DoubleBuffered = true;
            this.Name = "FormBuildingDetails";
            this.Text = "BuildingDetails";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewBuildingDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuildingName;
        private System.Windows.Forms.Label lblBuildingName;
        private System.Windows.Forms.Label lblPlace;
        private System.Windows.Forms.Label lblTotalFloor;
        private System.Windows.Forms.Label lblTotalArea;
        private System.Windows.Forms.Label lblBAO;
        private System.Windows.Forms.TextBox txtPlace;
        private System.Windows.Forms.TextBox txtTotalFloor;
        private System.Windows.Forms.TextBox txtTotalArea;
        private System.Windows.Forms.TextBox txtBAO;
        private System.Windows.Forms.DataGridView DataGridViewBuildingDetails;
        private System.Windows.Forms.Button btnTBack;
        private System.Windows.Forms.Button btnTExit;
        private System.Windows.Forms.Button btnTShow;
        private System.Windows.Forms.Button btnTDelete;
        private System.Windows.Forms.Button btnTUpdate;
        private System.Windows.Forms.Button btnTInsert;
        private System.Windows.Forms.Label lblBuildingNumber;
        private System.Windows.Forms.TextBox txtBuildingNumber;
    }
}