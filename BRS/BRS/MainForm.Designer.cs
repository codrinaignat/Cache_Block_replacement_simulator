namespace BRS
{
    partial class BRS
    {
              private System.ComponentModel.IContainer components = null;

               protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

      
        private void InitializeComponent()
        {
            System.Windows.Forms.Panel panel2;
            this.help = new System.Windows.Forms.Button();
            this.showCache = new System.Windows.Forms.Button();
            this.inputBox = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.replacementPolicyComboBox = new System.Windows.Forms.ComboBox();
            this.numberOfSetsComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cacheSizeComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cacheHitsLabel = new System.Windows.Forms.Label();
            this.conflictMissesLabel = new System.Windows.Forms.Label();
            this.capacityMissesLabel = new System.Windows.Forms.Label();
            this.compulsoryMissesLabel = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.hitRateLabel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.missRateLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.missesLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.queriesLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            panel2.Controls.Add(this.help);
            panel2.Controls.Add(this.showCache);
            panel2.Controls.Add(this.inputBox);
            panel2.Controls.Add(this.label6);
            panel2.Controls.Add(this.label5);
            panel2.Controls.Add(this.label4);
            panel2.Controls.Add(this.replacementPolicyComboBox);
            panel2.Controls.Add(this.numberOfSetsComboBox);
            panel2.Controls.Add(this.label3);
            panel2.Controls.Add(this.cacheSizeComboBox);
            panel2.Controls.Add(this.label2);
            panel2.Controls.Add(this.label1);
            panel2.Controls.Add(this.vScrollBar1);
            panel2.Location = new System.Drawing.Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(313, 524);
            panel2.TabIndex = 1;
            panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // help
            // 
            this.help.Location = new System.Drawing.Point(96, 234);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(49, 24);
            this.help.TabIndex = 14;
            this.help.Text = "Help";
            this.help.UseVisualStyleBackColor = true;
            this.help.Click += new System.EventHandler(this.help_Click);
            // 
            // showCache
            // 
            this.showCache.Location = new System.Drawing.Point(7, 234);
            this.showCache.Name = "showCache";
            this.showCache.Size = new System.Drawing.Size(80, 24);
            this.showCache.TabIndex = 13;
            this.showCache.Text = "Show Cache";
            this.showCache.UseVisualStyleBackColor = true;
            this.showCache.Click += new System.EventHandler(this.showCache_Click);
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(7, 152);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(272, 75);
            this.inputBox.TabIndex = 12;
            this.inputBox.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(2, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Multi-tasking in Decimal\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(230, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Enter Query Sequence - Task A for ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Replacement Policy";
            // 
            // replacementPolicyComboBox
            // 
            this.replacementPolicyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.replacementPolicyComboBox.FormattingEnabled = true;
            this.replacementPolicyComboBox.Items.AddRange(new object[] {
            "LRU",
            "FIFO",
            "RAND"});
            this.replacementPolicyComboBox.Location = new System.Drawing.Point(142, 61);
            this.replacementPolicyComboBox.Name = "replacementPolicyComboBox";
            this.replacementPolicyComboBox.Size = new System.Drawing.Size(58, 21);
            this.replacementPolicyComboBox.TabIndex = 6;
            // 
            // numberOfSetsComboBox
            // 
            this.numberOfSetsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.numberOfSetsComboBox.FormattingEnabled = true;
            this.numberOfSetsComboBox.Items.AddRange(new object[] {
            ""});
            this.numberOfSetsComboBox.Location = new System.Drawing.Point(177, 34);
            this.numberOfSetsComboBox.Name = "numberOfSetsComboBox";
            this.numberOfSetsComboBox.Size = new System.Drawing.Size(42, 21);
            this.numberOfSetsComboBox.TabIndex = 5;
            this.numberOfSetsComboBox.SelectedIndexChanged += new System.EventHandler(this.numberOfSetsComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(127, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "# Sets";
            // 
            // cacheSizeComboBox
            // 
            this.cacheSizeComboBox.AllowDrop = true;
            this.cacheSizeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cacheSizeComboBox.FormattingEnabled = true;
            this.cacheSizeComboBox.Items.AddRange(new object[] {
            "4 ",
            "8 ",
            "16",
            "32",
            "64",
            "128",
            "256"});
            this.cacheSizeComboBox.Location = new System.Drawing.Point(80, 34);
            this.cacheSizeComboBox.Name = "cacheSizeComboBox";
            this.cacheSizeComboBox.Size = new System.Drawing.Size(46, 21);
            this.cacheSizeComboBox.TabIndex = 3;
            this.cacheSizeComboBox.SelectedIndexChanged += new System.EventHandler(this.cacheSize_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cache Size";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Lime;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(66, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Block Replacement Simulator";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vScrollBar1.Location = new System.Drawing.Point(290, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(19, 520);
            this.vScrollBar1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Aquamarine;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.dataGridView);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(317, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(569, 524);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Aquamarine;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.cacheHitsLabel);
            this.panel3.Controls.Add(this.conflictMissesLabel);
            this.panel3.Controls.Add(this.capacityMissesLabel);
            this.panel3.Controls.Add(this.compulsoryMissesLabel);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.hitRateLabel);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.missRateLabel);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.missesLabel);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.queriesLabel);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 402);
            this.panel3.MaximumSize = new System.Drawing.Size(1024, 200);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(565, 118);
            this.panel3.TabIndex = 3;
            // 
            // cacheHitsLabel
            // 
            this.cacheHitsLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cacheHitsLabel.AutoSize = true;
            this.cacheHitsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cacheHitsLabel.Location = new System.Drawing.Point(135, 50);
            this.cacheHitsLabel.Name = "cacheHitsLabel";
            this.cacheHitsLabel.Size = new System.Drawing.Size(14, 13);
            this.cacheHitsLabel.TabIndex = 30;
            this.cacheHitsLabel.Text = "0";
            // 
            // conflictMissesLabel
            // 
            this.conflictMissesLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.conflictMissesLabel.AutoSize = true;
            this.conflictMissesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conflictMissesLabel.Location = new System.Drawing.Point(135, 37);
            this.conflictMissesLabel.Name = "conflictMissesLabel";
            this.conflictMissesLabel.Size = new System.Drawing.Size(14, 13);
            this.conflictMissesLabel.TabIndex = 29;
            this.conflictMissesLabel.Text = "0";
            // 
            // capacityMissesLabel
            // 
            this.capacityMissesLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.capacityMissesLabel.AutoSize = true;
            this.capacityMissesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capacityMissesLabel.Location = new System.Drawing.Point(135, 24);
            this.capacityMissesLabel.Name = "capacityMissesLabel";
            this.capacityMissesLabel.Size = new System.Drawing.Size(14, 13);
            this.capacityMissesLabel.TabIndex = 28;
            this.capacityMissesLabel.Text = "0";
            // 
            // compulsoryMissesLabel
            // 
            this.compulsoryMissesLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.compulsoryMissesLabel.AutoSize = true;
            this.compulsoryMissesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compulsoryMissesLabel.Location = new System.Drawing.Point(135, 11);
            this.compulsoryMissesLabel.Name = "compulsoryMissesLabel";
            this.compulsoryMissesLabel.Size = new System.Drawing.Size(14, 13);
            this.compulsoryMissesLabel.TabIndex = 27;
            this.compulsoryMissesLabel.Text = "0";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(55, 50);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(73, 13);
            this.label16.TabIndex = 26;
            this.label16.Text = "Cache Hits:";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(33, 37);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(96, 13);
            this.label15.TabIndex = 25;
            this.label15.Text = "Conflict Misses:";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(27, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(102, 13);
            this.label14.TabIndex = 24;
            this.label14.Text = "Capacity Misses:";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 11);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Compulsory Misses:";
            // 
            // hitRateLabel
            // 
            this.hitRateLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.hitRateLabel.AutoSize = true;
            this.hitRateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hitRateLabel.Location = new System.Drawing.Point(496, 50);
            this.hitRateLabel.Name = "hitRateLabel";
            this.hitRateLabel.Size = new System.Drawing.Size(14, 13);
            this.hitRateLabel.TabIndex = 22;
            this.hitRateLabel.Text = "0";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(432, 50);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "Hit Rate:";
            // 
            // missRateLabel
            // 
            this.missRateLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.missRateLabel.AutoSize = true;
            this.missRateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.missRateLabel.Location = new System.Drawing.Point(496, 37);
            this.missRateLabel.Name = "missRateLabel";
            this.missRateLabel.Size = new System.Drawing.Size(14, 13);
            this.missRateLabel.TabIndex = 20;
            this.missRateLabel.Text = "0";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(423, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Miss Rate:";
            // 
            // missesLabel
            // 
            this.missesLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.missesLabel.AutoSize = true;
            this.missesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.missesLabel.Location = new System.Drawing.Point(496, 24);
            this.missesLabel.Name = "missesLabel";
            this.missesLabel.Size = new System.Drawing.Size(14, 13);
            this.missesLabel.TabIndex = 18;
            this.missesLabel.Text = "0";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(408, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Total Misses:";
            // 
            // queriesLabel
            // 
            this.queriesLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.queriesLabel.AutoSize = true;
            this.queriesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.queriesLabel.Location = new System.Drawing.Point(496, 11);
            this.queriesLabel.Name = "queriesLabel";
            this.queriesLabel.Size = new System.Drawing.Size(14, 13);
            this.queriesLabel.TabIndex = 16;
            this.queriesLabel.Text = "0";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(363, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Total Cache Queries:";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView.Location = new System.Drawing.Point(17, 34);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView.Size = new System.Drawing.Size(537, 349);
            this.dataGridView.StandardTab = true;
            this.dataGridView.TabIndex = 2;
            this.dataGridView.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "Cache Contents";
            // 
            // BRS
            // 
            this.AccessibleDescription = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(885, 524);
            this.Controls.Add(panel2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "BRS";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Block Replacement Simulator";
            this.Load += new System.EventHandler(this.BRS_Load);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cacheSizeComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox numberOfSetsComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox replacementPolicyComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox inputBox;
        private System.Windows.Forms.Button help;
        private System.Windows.Forms.Button showCache;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label missesLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label queriesLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label hitRateLabel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label missRateLabel;
        private System.Windows.Forms.Label cacheHitsLabel;
        private System.Windows.Forms.Label conflictMissesLabel;
        private System.Windows.Forms.Label capacityMissesLabel;
        private System.Windows.Forms.Label compulsoryMissesLabel;
    }
}

