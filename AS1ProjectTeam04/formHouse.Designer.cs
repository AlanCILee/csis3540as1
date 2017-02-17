namespace AS1ProjectTeam04
{
    partial class formHouse
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGetListings = new System.Windows.Forms.Button();
            this.gridListings = new System.Windows.Forms.DataGridView();
            this.labelCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbCountListings = new System.Windows.Forms.Label();
            this.lbAvgListings = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rbCondo = new System.Windows.Forms.RadioButton();
            this.rbTownhouse = new System.Windows.Forms.RadioButton();
            this.rbHouse = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbMaxPrice = new System.Windows.Forms.TextBox();
            this.tbBedrooms = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnFindHouses = new System.Windows.Forms.Button();
            this.gridResults = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbCoundResults = new System.Windows.Forms.Label();
            this.lbAvgResults = new System.Windows.Forms.Label();
            this.houseCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.houseType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.neighborhood = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bedrooms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridListings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridResults)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(406, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Listings";
            // 
            // btnGetListings
            // 
            this.btnGetListings.Location = new System.Drawing.Point(47, 108);
            this.btnGetListings.Name = "btnGetListings";
            this.btnGetListings.Size = new System.Drawing.Size(120, 40);
            this.btnGetListings.TabIndex = 1;
            this.btnGetListings.Text = "Get Listings";
            this.btnGetListings.UseVisualStyleBackColor = true;
            this.btnGetListings.Click += new System.EventHandler(this.btnGetListings_Click);
            // 
            // gridListings
            // 
            this.gridListings.AllowUserToAddRows = false;
            this.gridListings.AllowUserToDeleteRows = false;
            this.gridListings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridListings.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridListings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridListings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.houseCode,
            this.houseType,
            this.neighborhood,
            this.price,
            this.bedrooms});
            this.gridListings.Location = new System.Drawing.Point(183, 57);
            this.gridListings.Name = "gridListings";
            this.gridListings.ReadOnly = true;
            this.gridListings.Size = new System.Drawing.Size(562, 210);
            this.gridListings.TabIndex = 2;
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(288, 293);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(35, 13);
            this.labelCount.TabIndex = 3;
            this.labelCount.Text = "Count";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(517, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Average Price";
            // 
            // lbCountListings
            // 
            this.lbCountListings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbCountListings.Location = new System.Drawing.Point(329, 288);
            this.lbCountListings.Name = "lbCountListings";
            this.lbCountListings.Size = new System.Drawing.Size(100, 23);
            this.lbCountListings.TabIndex = 5;
            this.lbCountListings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbAvgListings
            // 
            this.lbAvgListings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbAvgListings.Location = new System.Drawing.Point(597, 288);
            this.lbAvgListings.Name = "lbAvgListings";
            this.lbAvgListings.Size = new System.Drawing.Size(100, 23);
            this.lbAvgListings.TabIndex = 6;
            this.lbAvgListings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(343, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Desired Attributes";
            // 
            // rbCondo
            // 
            this.rbCondo.AutoSize = true;
            this.rbCondo.Location = new System.Drawing.Point(61, 390);
            this.rbCondo.Name = "rbCondo";
            this.rbCondo.Size = new System.Drawing.Size(56, 17);
            this.rbCondo.TabIndex = 8;
            this.rbCondo.Text = "Condo";
            this.rbCondo.UseVisualStyleBackColor = true;
            // 
            // rbTownhouse
            // 
            this.rbTownhouse.AutoSize = true;
            this.rbTownhouse.Location = new System.Drawing.Point(144, 390);
            this.rbTownhouse.Name = "rbTownhouse";
            this.rbTownhouse.Size = new System.Drawing.Size(86, 17);
            this.rbTownhouse.TabIndex = 9;
            this.rbTownhouse.Text = "Town House";
            this.rbTownhouse.UseVisualStyleBackColor = true;
            // 
            // rbHouse
            // 
            this.rbHouse.AutoSize = true;
            this.rbHouse.Location = new System.Drawing.Point(250, 390);
            this.rbHouse.Name = "rbHouse";
            this.rbHouse.Size = new System.Drawing.Size(56, 17);
            this.rbHouse.TabIndex = 10;
            this.rbHouse.Text = "House";
            this.rbHouse.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(47, 364);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 64);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Housing Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(344, 390);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Maximum Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(583, 389);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Bedrooms";
            // 
            // tbMaxPrice
            // 
            this.tbMaxPrice.Location = new System.Drawing.Point(426, 387);
            this.tbMaxPrice.Name = "tbMaxPrice";
            this.tbMaxPrice.Size = new System.Drawing.Size(100, 20);
            this.tbMaxPrice.TabIndex = 14;
            this.tbMaxPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbBedrooms
            // 
            this.tbBedrooms.Location = new System.Drawing.Point(645, 387);
            this.tbBedrooms.Name = "tbBedrooms";
            this.tbBedrooms.Size = new System.Drawing.Size(100, 20);
            this.tbBedrooms.TabIndex = 15;
            this.tbBedrooms.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(381, 452);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Suitable Homes";
            // 
            // btnFindHouses
            // 
            this.btnFindHouses.Location = new System.Drawing.Point(47, 523);
            this.btnFindHouses.Name = "btnFindHouses";
            this.btnFindHouses.Size = new System.Drawing.Size(120, 40);
            this.btnFindHouses.TabIndex = 17;
            this.btnFindHouses.Text = "Find Houses";
            this.btnFindHouses.UseVisualStyleBackColor = true;
            this.btnFindHouses.Click += new System.EventHandler(this.btnFindHouses_Click);
            // 
            // gridResults
            // 
            this.gridResults.AllowUserToAddRows = false;
            this.gridResults.AllowUserToDeleteRows = false;
            this.gridResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridResults.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.gridResults.Location = new System.Drawing.Point(183, 487);
            this.gridResults.Name = "gridResults";
            this.gridResults.ReadOnly = true;
            this.gridResults.Size = new System.Drawing.Size(562, 210);
            this.gridResults.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(288, 716);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Count";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(517, 716);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Average Price";
            // 
            // lbCoundResults
            // 
            this.lbCoundResults.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbCoundResults.Location = new System.Drawing.Point(329, 709);
            this.lbCoundResults.Name = "lbCoundResults";
            this.lbCoundResults.Size = new System.Drawing.Size(100, 23);
            this.lbCoundResults.TabIndex = 21;
            this.lbCoundResults.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbAvgResults
            // 
            this.lbAvgResults.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbAvgResults.Location = new System.Drawing.Point(597, 711);
            this.lbAvgResults.Name = "lbAvgResults";
            this.lbAvgResults.Size = new System.Drawing.Size(100, 23);
            this.lbAvgResults.TabIndex = 22;
            this.lbAvgResults.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // houseCode
            // 
            this.houseCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.houseCode.DefaultCellStyle = dataGridViewCellStyle11;
            this.houseCode.HeaderText = "Code";
            this.houseCode.Name = "houseCode";
            this.houseCode.ReadOnly = true;
            // 
            // houseType
            // 
            this.houseType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.houseType.DefaultCellStyle = dataGridViewCellStyle12;
            this.houseType.HeaderText = "Type";
            this.houseType.Name = "houseType";
            this.houseType.ReadOnly = true;
            // 
            // neighborhood
            // 
            this.neighborhood.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.neighborhood.DefaultCellStyle = dataGridViewCellStyle13;
            this.neighborhood.HeaderText = "Neighborhood";
            this.neighborhood.Name = "neighborhood";
            this.neighborhood.ReadOnly = true;
            // 
            // price
            // 
            this.price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.price.DefaultCellStyle = dataGridViewCellStyle14;
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // bedrooms
            // 
            this.bedrooms.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.bedrooms.DefaultCellStyle = dataGridViewCellStyle15;
            this.bedrooms.HeaderText = "BRs";
            this.bedrooms.Name = "bedrooms";
            this.bedrooms.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridViewTextBoxColumn1.HeaderText = "Code";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridViewTextBoxColumn2.HeaderText = "Type";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridViewTextBoxColumn3.HeaderText = "Neighborhood";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle19;
            this.dataGridViewTextBoxColumn4.HeaderText = "Price";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridViewTextBoxColumn5.HeaderText = "BRs";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // formHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 783);
            this.Controls.Add(this.lbAvgResults);
            this.Controls.Add(this.lbCoundResults);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.gridResults);
            this.Controls.Add(this.btnFindHouses);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbBedrooms);
            this.Controls.Add(this.tbMaxPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rbHouse);
            this.Controls.Add(this.rbTownhouse);
            this.Controls.Add(this.rbCondo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbAvgListings);
            this.Controls.Add(this.lbCountListings);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.gridListings);
            this.Controls.Add(this.btnGetListings);
            this.Controls.Add(this.label1);
            this.Name = "formHouse";
            this.Text = "House Purchase";
            ((System.ComponentModel.ISupportInitialize)(this.gridListings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGetListings;
        private System.Windows.Forms.DataGridView gridListings;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbCountListings;
        private System.Windows.Forms.Label lbAvgListings;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbCondo;
        private System.Windows.Forms.RadioButton rbTownhouse;
        private System.Windows.Forms.RadioButton rbHouse;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbMaxPrice;
        private System.Windows.Forms.TextBox tbBedrooms;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnFindHouses;
        private System.Windows.Forms.DataGridView gridResults;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbCoundResults;
        private System.Windows.Forms.Label lbAvgResults;
        private System.Windows.Forms.DataGridViewTextBoxColumn houseCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn houseType;
        private System.Windows.Forms.DataGridViewTextBoxColumn neighborhood;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn bedrooms;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}

