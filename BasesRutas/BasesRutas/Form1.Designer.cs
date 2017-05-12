namespace BasesRutas
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddFirst = new System.Windows.Forms.Button();
            this.btnAddLast = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelateLast = new System.Windows.Forms.Button();
            this.btnDelateFirst = new System.Windows.Forms.Button();
            this.btnDelate = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnTour = new System.Windows.Forms.Button();
            this.lbBase = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.txbNameBase = new System.Windows.Forms.TextBox();
            this.txbTime = new System.Windows.Forms.TextBox();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.txbReport = new System.Windows.Forms.TextBox();
            this.txbDelate = new System.Windows.Forms.TextBox();
            this.txbBaseTour = new System.Windows.Forms.TextBox();
            this.lbTimeToStart = new System.Windows.Forms.Label();
            this.lbTimeToFinish = new System.Windows.Forms.Label();
            this.txbStart = new System.Windows.Forms.TextBox();
            this.txbFinish = new System.Windows.Forms.TextBox();
            this.lbReport = new System.Windows.Forms.Label();
            this.txbInsert = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddFirst
            // 
            this.btnAddFirst.Location = new System.Drawing.Point(267, 10);
            this.btnAddFirst.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddFirst.Name = "btnAddFirst";
            this.btnAddFirst.Size = new System.Drawing.Size(100, 28);
            this.btnAddFirst.TabIndex = 1;
            this.btnAddFirst.Text = "&Add First";
            this.btnAddFirst.UseVisualStyleBackColor = true;
            this.btnAddFirst.Click += new System.EventHandler(this.btnAddFirst_Click);
            // 
            // btnAddLast
            // 
            this.btnAddLast.Location = new System.Drawing.Point(267, 46);
            this.btnAddLast.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddLast.Name = "btnAddLast";
            this.btnAddLast.Size = new System.Drawing.Size(100, 28);
            this.btnAddLast.TabIndex = 2;
            this.btnAddLast.Text = "A&dd Last";
            this.btnAddLast.UseVisualStyleBackColor = true;
            this.btnAddLast.Click += new System.EventHandler(this.btnAddLast_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(373, 47);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 28);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDelateLast
            // 
            this.btnDelateLast.Location = new System.Drawing.Point(373, 10);
            this.btnDelateLast.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelateLast.Name = "btnDelateLast";
            this.btnDelateLast.Size = new System.Drawing.Size(100, 28);
            this.btnDelateLast.TabIndex = 4;
            this.btnDelateLast.Text = "&DelateLast";
            this.btnDelateLast.UseVisualStyleBackColor = true;
            this.btnDelateLast.Click += new System.EventHandler(this.btnDelateLast_Click);
            // 
            // btnDelateFirst
            // 
            this.btnDelateFirst.Location = new System.Drawing.Point(483, 10);
            this.btnDelateFirst.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelateFirst.Name = "btnDelateFirst";
            this.btnDelateFirst.Size = new System.Drawing.Size(100, 28);
            this.btnDelateFirst.TabIndex = 5;
            this.btnDelateFirst.Text = "D&elate First";
            this.btnDelateFirst.UseVisualStyleBackColor = true;
            this.btnDelateFirst.Click += new System.EventHandler(this.btnDelateFirst_Click);
            // 
            // btnDelate
            // 
            this.btnDelate.Location = new System.Drawing.Point(373, 85);
            this.btnDelate.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelate.Name = "btnDelate";
            this.btnDelate.Size = new System.Drawing.Size(100, 28);
            this.btnDelate.TabIndex = 6;
            this.btnDelate.Text = "De&late";
            this.btnDelate.UseVisualStyleBackColor = true;
            this.btnDelate.Click += new System.EventHandler(this.btnDelate_Click);
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(267, 84);
            this.btnReport.Margin = new System.Windows.Forms.Padding(4);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(100, 28);
            this.btnReport.TabIndex = 7;
            this.btnReport.Text = "&Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnTour
            // 
            this.btnTour.Location = new System.Drawing.Point(29, 138);
            this.btnTour.Margin = new System.Windows.Forms.Padding(4);
            this.btnTour.Name = "btnTour";
            this.btnTour.Size = new System.Drawing.Size(100, 28);
            this.btnTour.TabIndex = 8;
            this.btnTour.Text = "&Tour";
            this.btnTour.UseVisualStyleBackColor = true;
            this.btnTour.Click += new System.EventHandler(this.btnDelate_Click);
            // 
            // lbBase
            // 
            this.lbBase.AutoSize = true;
            this.lbBase.Location = new System.Drawing.Point(47, 16);
            this.lbBase.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBase.Name = "lbBase";
            this.lbBase.Size = new System.Drawing.Size(81, 17);
            this.lbBase.TabIndex = 1;
            this.lbBase.Text = "Name Base";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Location = new System.Drawing.Point(88, 50);
            this.lbTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(39, 17);
            this.lbTime.TabIndex = 1;
            this.lbTime.Text = "Time";
            // 
            // txbNameBase
            // 
            this.txbNameBase.Location = new System.Drawing.Point(137, 16);
            this.txbNameBase.Margin = new System.Windows.Forms.Padding(4);
            this.txbNameBase.Name = "txbNameBase";
            this.txbNameBase.Size = new System.Drawing.Size(99, 23);
            this.txbNameBase.TabIndex = 1;
            // 
            // txbTime
            // 
            this.txbTime.Location = new System.Drawing.Point(137, 49);
            this.txbTime.Margin = new System.Windows.Forms.Padding(4);
            this.txbTime.Name = "txbTime";
            this.txbTime.Size = new System.Drawing.Size(99, 23);
            this.txbTime.TabIndex = 2;
            // 
            // txbSearch
            // 
            this.txbSearch.Location = new System.Drawing.Point(483, 46);
            this.txbSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(99, 23);
            this.txbSearch.TabIndex = 2;
            // 
            // txbReport
            // 
            this.txbReport.Enabled = false;
            this.txbReport.Location = new System.Drawing.Point(267, 143);
            this.txbReport.Margin = new System.Windows.Forms.Padding(4);
            this.txbReport.Multiline = true;
            this.txbReport.Name = "txbReport";
            this.txbReport.Size = new System.Drawing.Size(315, 87);
            this.txbReport.TabIndex = 2;
            // 
            // txbDelate
            // 
            this.txbDelate.Location = new System.Drawing.Point(483, 87);
            this.txbDelate.Margin = new System.Windows.Forms.Padding(4);
            this.txbDelate.Name = "txbDelate";
            this.txbDelate.Size = new System.Drawing.Size(99, 23);
            this.txbDelate.TabIndex = 2;
            // 
            // txbBaseTour
            // 
            this.txbBaseTour.Location = new System.Drawing.Point(137, 142);
            this.txbBaseTour.Margin = new System.Windows.Forms.Padding(4);
            this.txbBaseTour.Name = "txbBaseTour";
            this.txbBaseTour.Size = new System.Drawing.Size(99, 23);
            this.txbBaseTour.TabIndex = 2;
            // 
            // lbTimeToStart
            // 
            this.lbTimeToStart.AutoSize = true;
            this.lbTimeToStart.Location = new System.Drawing.Point(39, 177);
            this.lbTimeToStart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTimeToStart.Name = "lbTimeToStart";
            this.lbTimeToStart.Size = new System.Drawing.Size(89, 17);
            this.lbTimeToStart.TabIndex = 1;
            this.lbTimeToStart.Text = "Time to Start";
            // 
            // lbTimeToFinish
            // 
            this.lbTimeToFinish.AutoSize = true;
            this.lbTimeToFinish.Location = new System.Drawing.Point(39, 211);
            this.lbTimeToFinish.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTimeToFinish.Name = "lbTimeToFinish";
            this.lbTimeToFinish.Size = new System.Drawing.Size(96, 17);
            this.lbTimeToFinish.TabIndex = 1;
            this.lbTimeToFinish.Text = "Time to Finish";
            // 
            // txbStart
            // 
            this.txbStart.Location = new System.Drawing.Point(137, 174);
            this.txbStart.Margin = new System.Windows.Forms.Padding(4);
            this.txbStart.Name = "txbStart";
            this.txbStart.Size = new System.Drawing.Size(99, 23);
            this.txbStart.TabIndex = 1;
            // 
            // txbFinish
            // 
            this.txbFinish.Location = new System.Drawing.Point(137, 207);
            this.txbFinish.Margin = new System.Windows.Forms.Padding(4);
            this.txbFinish.Name = "txbFinish";
            this.txbFinish.Size = new System.Drawing.Size(99, 23);
            this.txbFinish.TabIndex = 2;
            // 
            // lbReport
            // 
            this.lbReport.AutoSize = true;
            this.lbReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReport.Location = new System.Drawing.Point(263, 118);
            this.lbReport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbReport.Name = "lbReport";
            this.lbReport.Size = new System.Drawing.Size(55, 16);
            this.lbReport.TabIndex = 1;
            this.lbReport.Text = "Report";
            // 
            // txbInsert
            // 
            this.txbInsert.Location = new System.Drawing.Point(137, 87);
            this.txbInsert.Name = "txbInsert";
            this.txbInsert.Size = new System.Drawing.Size(100, 23);
            this.txbInsert.TabIndex = 9;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(29, 83);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(100, 28);
            this.btnInsert.TabIndex = 10;
            this.btnInsert.Text = "&Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // frmPrincipal
            // 
            this.AcceptButton = this.btnAddLast;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 243);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txbInsert);
            this.Controls.Add(this.txbReport);
            this.Controls.Add(this.txbBaseTour);
            this.Controls.Add(this.txbDelate);
            this.Controls.Add(this.txbSearch);
            this.Controls.Add(this.txbFinish);
            this.Controls.Add(this.txbStart);
            this.Controls.Add(this.txbTime);
            this.Controls.Add(this.lbReport);
            this.Controls.Add(this.lbTimeToFinish);
            this.Controls.Add(this.txbNameBase);
            this.Controls.Add(this.lbTimeToStart);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.lbBase);
            this.Controls.Add(this.btnTour);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnDelate);
            this.Controls.Add(this.btnDelateFirst);
            this.Controls.Add(this.btnDelateLast);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnAddLast);
            this.Controls.Add(this.btnAddFirst);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.Text = "Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddFirst;
        private System.Windows.Forms.Button btnAddLast;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelateLast;
        private System.Windows.Forms.Button btnDelateFirst;
        private System.Windows.Forms.Button btnDelate;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnTour;
        private System.Windows.Forms.Label lbBase;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.TextBox txbNameBase;
        private System.Windows.Forms.TextBox txbTime;
        private System.Windows.Forms.TextBox txbSearch;
        private System.Windows.Forms.TextBox txbReport;
        private System.Windows.Forms.TextBox txbDelate;
        private System.Windows.Forms.TextBox txbBaseTour;
        private System.Windows.Forms.Label lbTimeToStart;
        private System.Windows.Forms.Label lbTimeToFinish;
        private System.Windows.Forms.TextBox txbStart;
        private System.Windows.Forms.TextBox txbFinish;
        private System.Windows.Forms.Label lbReport;
        private System.Windows.Forms.TextBox txbInsert;
        private System.Windows.Forms.Button btnInsert;
    }
}

