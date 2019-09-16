namespace GB_Calc
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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.tbCurrentPoints = new System.Windows.Forms.TextBox();
			this.tbCurrentMax = new System.Windows.Forms.TextBox();
			this.tbYourPoints = new System.Windows.Forms.TextBox();
			this.tbTheirPoints = new System.Windows.Forms.TextBox();
			this.tbRewardPoints = new System.Windows.Forms.TextBox();
			this.tbRewardPrints = new System.Windows.Forms.TextBox();
			this.tbCurrentLoosePoints = new System.Windows.Forms.TextBox();
			this.labelPointsLeft = new System.Windows.Forms.Label();
			this.labelPointsLead = new System.Windows.Forms.Label();
			this.labelPointsCatchup = new System.Windows.Forms.Label();
			this.labelPoints2Lock = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.labelRewardPoints = new System.Windows.Forms.Label();
			this.labelRewardPrints = new System.Windows.Forms.Label();
			this.labelTotalInvestment = new System.Windows.Forms.Label();
			this.labelPointsPerPrint = new System.Windows.Forms.Label();
			this.labelArcPercent = new System.Windows.Forms.Label();
			this.labelPoints2LockTotal = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.nArcLevel = new System.Windows.Forms.NumericUpDown();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nArcLevel)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(580, 614);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.tableLayoutPanel1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(572, 588);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Lock Calc";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 4;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.83274F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.16726F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 99F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109F));
			this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
			this.tableLayoutPanel1.Controls.Add(this.label7, 0, 6);
			this.tableLayoutPanel1.Controls.Add(this.label8, 0, 7);
			this.tableLayoutPanel1.Controls.Add(this.label9, 0, 8);
			this.tableLayoutPanel1.Controls.Add(this.label10, 0, 9);
			this.tableLayoutPanel1.Controls.Add(this.label11, 0, 10);
			this.tableLayoutPanel1.Controls.Add(this.label12, 0, 11);
			this.tableLayoutPanel1.Controls.Add(this.label13, 0, 12);
			this.tableLayoutPanel1.Controls.Add(this.label14, 0, 13);
			this.tableLayoutPanel1.Controls.Add(this.tbCurrentPoints, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.tbCurrentMax, 2, 1);
			this.tableLayoutPanel1.Controls.Add(this.tbYourPoints, 2, 2);
			this.tableLayoutPanel1.Controls.Add(this.tbTheirPoints, 2, 3);
			this.tableLayoutPanel1.Controls.Add(this.tbRewardPoints, 2, 9);
			this.tableLayoutPanel1.Controls.Add(this.tbRewardPrints, 2, 10);
			this.tableLayoutPanel1.Controls.Add(this.tbCurrentLoosePoints, 2, 11);
			this.tableLayoutPanel1.Controls.Add(this.labelPointsLeft, 2, 4);
			this.tableLayoutPanel1.Controls.Add(this.labelPointsLead, 2, 5);
			this.tableLayoutPanel1.Controls.Add(this.labelPointsCatchup, 2, 6);
			this.tableLayoutPanel1.Controls.Add(this.labelPoints2Lock, 2, 7);
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.labelRewardPoints, 3, 9);
			this.tableLayoutPanel1.Controls.Add(this.labelRewardPrints, 3, 10);
			this.tableLayoutPanel1.Controls.Add(this.labelTotalInvestment, 2, 12);
			this.tableLayoutPanel1.Controls.Add(this.labelPointsPerPrint, 2, 13);
			this.tableLayoutPanel1.Controls.Add(this.labelArcPercent, 3, 8);
			this.tableLayoutPanel1.Controls.Add(this.labelPoints2LockTotal, 3, 7);
			this.tableLayoutPanel1.Controls.Add(this.nArcLevel, 2, 8);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 15;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(566, 582);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 53);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(304, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Current Max";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 93);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(304, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Your Points";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(3, 133);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(304, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Their Points";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(3, 173);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(304, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "Points Left";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(3, 213);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(304, 13);
			this.label6.TabIndex = 5;
			this.label6.Text = "Points Lead";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label7
			// 
			this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(3, 253);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(304, 13);
			this.label7.TabIndex = 6;
			this.label7.Text = "Points After Catchup";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label8
			// 
			this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(3, 293);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(304, 13);
			this.label8.TabIndex = 7;
			this.label8.Text = "Points to Lock 1st (Total)";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label9
			// 
			this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(3, 333);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(304, 13);
			this.label9.TabIndex = 8;
			this.label9.Text = "Arc Level (Arc Percent)";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label10
			// 
			this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(3, 373);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(304, 13);
			this.label10.TabIndex = 9;
			this.label10.Text = "Reward: Points";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label11
			// 
			this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(3, 413);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(304, 13);
			this.label11.TabIndex = 10;
			this.label11.Text = "Reward: Prints";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label12
			// 
			this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(3, 453);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(304, 13);
			this.label12.TabIndex = 11;
			this.label12.Text = "Current Loose Points";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label13
			// 
			this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(3, 493);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(304, 13);
			this.label13.TabIndex = 12;
			this.label13.Text = "Total Investment";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label14
			// 
			this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(3, 533);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(304, 13);
			this.label14.TabIndex = 13;
			this.label14.Text = "Points / Print";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tbCurrentPoints
			// 
			this.tbCurrentPoints.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.SetColumnSpan(this.tbCurrentPoints, 2);
			this.tbCurrentPoints.Location = new System.Drawing.Point(360, 10);
			this.tbCurrentPoints.Name = "tbCurrentPoints";
			this.tbCurrentPoints.Size = new System.Drawing.Size(203, 20);
			this.tbCurrentPoints.TabIndex = 14;
			this.tbCurrentPoints.Leave += new System.EventHandler(this.textBoxes_Leave);
			// 
			// tbCurrentMax
			// 
			this.tbCurrentMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.SetColumnSpan(this.tbCurrentMax, 2);
			this.tbCurrentMax.Location = new System.Drawing.Point(360, 50);
			this.tbCurrentMax.Name = "tbCurrentMax";
			this.tbCurrentMax.Size = new System.Drawing.Size(203, 20);
			this.tbCurrentMax.TabIndex = 15;
			this.tbCurrentMax.Leave += new System.EventHandler(this.textBoxes_Leave);
			// 
			// tbYourPoints
			// 
			this.tbYourPoints.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.SetColumnSpan(this.tbYourPoints, 2);
			this.tbYourPoints.Location = new System.Drawing.Point(360, 90);
			this.tbYourPoints.Name = "tbYourPoints";
			this.tbYourPoints.Size = new System.Drawing.Size(203, 20);
			this.tbYourPoints.TabIndex = 16;
			this.tbYourPoints.Leave += new System.EventHandler(this.textBoxes_Leave);
			// 
			// tbTheirPoints
			// 
			this.tbTheirPoints.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.SetColumnSpan(this.tbTheirPoints, 2);
			this.tbTheirPoints.Location = new System.Drawing.Point(360, 130);
			this.tbTheirPoints.Name = "tbTheirPoints";
			this.tbTheirPoints.Size = new System.Drawing.Size(203, 20);
			this.tbTheirPoints.TabIndex = 17;
			this.tbTheirPoints.Leave += new System.EventHandler(this.textBoxes_Leave);
			// 
			// tbRewardPoints
			// 
			this.tbRewardPoints.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.tbRewardPoints.Location = new System.Drawing.Point(360, 370);
			this.tbRewardPoints.Name = "tbRewardPoints";
			this.tbRewardPoints.Size = new System.Drawing.Size(93, 20);
			this.tbRewardPoints.TabIndex = 19;
			this.tbRewardPoints.Leave += new System.EventHandler(this.textBoxes_Leave);
			// 
			// tbRewardPrints
			// 
			this.tbRewardPrints.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.tbRewardPrints.Location = new System.Drawing.Point(360, 410);
			this.tbRewardPrints.Name = "tbRewardPrints";
			this.tbRewardPrints.Size = new System.Drawing.Size(93, 20);
			this.tbRewardPrints.TabIndex = 20;
			this.tbRewardPrints.Leave += new System.EventHandler(this.textBoxes_Leave);
			// 
			// tbCurrentLoosePoints
			// 
			this.tbCurrentLoosePoints.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.SetColumnSpan(this.tbCurrentLoosePoints, 2);
			this.tbCurrentLoosePoints.Location = new System.Drawing.Point(360, 450);
			this.tbCurrentLoosePoints.Name = "tbCurrentLoosePoints";
			this.tbCurrentLoosePoints.Size = new System.Drawing.Size(203, 20);
			this.tbCurrentLoosePoints.TabIndex = 21;
			this.tbCurrentLoosePoints.Leave += new System.EventHandler(this.textBoxes_Leave);
			// 
			// labelPointsLeft
			// 
			this.labelPointsLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.labelPointsLeft.AutoSize = true;
			this.tableLayoutPanel1.SetColumnSpan(this.labelPointsLeft, 2);
			this.labelPointsLeft.Location = new System.Drawing.Point(360, 173);
			this.labelPointsLeft.Name = "labelPointsLeft";
			this.labelPointsLeft.Size = new System.Drawing.Size(203, 13);
			this.labelPointsLeft.TabIndex = 22;
			this.labelPointsLeft.Text = "?";
			this.labelPointsLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelPointsLead
			// 
			this.labelPointsLead.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.labelPointsLead.AutoSize = true;
			this.tableLayoutPanel1.SetColumnSpan(this.labelPointsLead, 2);
			this.labelPointsLead.Location = new System.Drawing.Point(360, 213);
			this.labelPointsLead.Name = "labelPointsLead";
			this.labelPointsLead.Size = new System.Drawing.Size(203, 13);
			this.labelPointsLead.TabIndex = 23;
			this.labelPointsLead.Text = "?";
			this.labelPointsLead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelPointsCatchup
			// 
			this.labelPointsCatchup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.labelPointsCatchup.AutoSize = true;
			this.tableLayoutPanel1.SetColumnSpan(this.labelPointsCatchup, 2);
			this.labelPointsCatchup.Location = new System.Drawing.Point(360, 253);
			this.labelPointsCatchup.Name = "labelPointsCatchup";
			this.labelPointsCatchup.Size = new System.Drawing.Size(203, 13);
			this.labelPointsCatchup.TabIndex = 24;
			this.labelPointsCatchup.Text = "?";
			this.labelPointsCatchup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelPoints2Lock
			// 
			this.labelPoints2Lock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.labelPoints2Lock.AutoSize = true;
			this.labelPoints2Lock.Location = new System.Drawing.Point(360, 293);
			this.labelPoints2Lock.Name = "labelPoints2Lock";
			this.labelPoints2Lock.Size = new System.Drawing.Size(93, 13);
			this.labelPoints2Lock.TabIndex = 25;
			this.labelPoints2Lock.Text = "?";
			this.labelPoints2Lock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(304, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Current Points";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// labelRewardPoints
			// 
			this.labelRewardPoints.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.labelRewardPoints.AutoSize = true;
			this.labelRewardPoints.Location = new System.Drawing.Point(459, 373);
			this.labelRewardPoints.Name = "labelRewardPoints";
			this.labelRewardPoints.Size = new System.Drawing.Size(104, 13);
			this.labelRewardPoints.TabIndex = 26;
			this.labelRewardPoints.Text = "?";
			this.labelRewardPoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelRewardPrints
			// 
			this.labelRewardPrints.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.labelRewardPrints.AutoSize = true;
			this.labelRewardPrints.Location = new System.Drawing.Point(459, 413);
			this.labelRewardPrints.Name = "labelRewardPrints";
			this.labelRewardPrints.Size = new System.Drawing.Size(104, 13);
			this.labelRewardPrints.TabIndex = 27;
			this.labelRewardPrints.Text = "?";
			this.labelRewardPrints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelTotalInvestment
			// 
			this.labelTotalInvestment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.labelTotalInvestment.AutoSize = true;
			this.tableLayoutPanel1.SetColumnSpan(this.labelTotalInvestment, 2);
			this.labelTotalInvestment.Location = new System.Drawing.Point(360, 493);
			this.labelTotalInvestment.Name = "labelTotalInvestment";
			this.labelTotalInvestment.Size = new System.Drawing.Size(203, 13);
			this.labelTotalInvestment.TabIndex = 28;
			this.labelTotalInvestment.Text = "?";
			this.labelTotalInvestment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelPointsPerPrint
			// 
			this.labelPointsPerPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.labelPointsPerPrint.AutoSize = true;
			this.tableLayoutPanel1.SetColumnSpan(this.labelPointsPerPrint, 2);
			this.labelPointsPerPrint.Location = new System.Drawing.Point(360, 533);
			this.labelPointsPerPrint.Name = "labelPointsPerPrint";
			this.labelPointsPerPrint.Size = new System.Drawing.Size(203, 13);
			this.labelPointsPerPrint.TabIndex = 29;
			this.labelPointsPerPrint.Text = "?";
			this.labelPointsPerPrint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelArcPercent
			// 
			this.labelArcPercent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.labelArcPercent.AutoSize = true;
			this.labelArcPercent.Location = new System.Drawing.Point(459, 333);
			this.labelArcPercent.Name = "labelArcPercent";
			this.labelArcPercent.Size = new System.Drawing.Size(104, 13);
			this.labelArcPercent.TabIndex = 30;
			this.labelArcPercent.Text = "?";
			this.labelArcPercent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelPoints2LockTotal
			// 
			this.labelPoints2LockTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.labelPoints2LockTotal.AutoSize = true;
			this.labelPoints2LockTotal.Location = new System.Drawing.Point(459, 293);
			this.labelPoints2LockTotal.Name = "labelPoints2LockTotal";
			this.labelPoints2LockTotal.Size = new System.Drawing.Size(104, 13);
			this.labelPoints2LockTotal.TabIndex = 31;
			this.labelPoints2LockTotal.Text = "?";
			this.labelPoints2LockTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tabPage2
			// 
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(572, 588);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "tabPage2";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// nArcLevel
			// 
			this.nArcLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.nArcLevel.Location = new System.Drawing.Point(360, 330);
			this.nArcLevel.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
			this.nArcLevel.Name = "nArcLevel";
			this.nArcLevel.Size = new System.Drawing.Size(93, 20);
			this.nArcLevel.TabIndex = 32;
			this.nArcLevel.ValueChanged += new System.EventHandler(this.textBoxes_Leave);
			this.nArcLevel.Leave += new System.EventHandler(this.textBoxes_Leave);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(580, 614);
			this.Controls.Add(this.tabControl1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nArcLevel)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox tbCurrentPoints;
		private System.Windows.Forms.TextBox tbCurrentMax;
		private System.Windows.Forms.TextBox tbYourPoints;
		private System.Windows.Forms.TextBox tbTheirPoints;
		private System.Windows.Forms.TextBox tbRewardPoints;
		private System.Windows.Forms.TextBox tbRewardPrints;
		private System.Windows.Forms.TextBox tbCurrentLoosePoints;
		private System.Windows.Forms.Label labelPointsLeft;
		private System.Windows.Forms.Label labelPointsLead;
		private System.Windows.Forms.Label labelPointsCatchup;
		private System.Windows.Forms.Label labelPoints2Lock;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label labelRewardPoints;
		private System.Windows.Forms.Label labelRewardPrints;
		private System.Windows.Forms.Label labelTotalInvestment;
		private System.Windows.Forms.Label labelPointsPerPrint;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Label labelArcPercent;
		private System.Windows.Forms.Label labelPoints2LockTotal;
		private System.Windows.Forms.NumericUpDown nArcLevel;
	}
}

