namespace DrawApp.UI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.startButton = new System.Windows.Forms.Button();
            this.Pot1Label = new System.Windows.Forms.Label();
            this.Pot4Label = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Pot3Label = new System.Windows.Forms.Label();
            this.Pot2Label = new System.Windows.Forms.Label();
            this.franceLabel = new System.Windows.Forms.Label();
            this.spainLabel = new System.Windows.Forms.Label();
            this.germanyLabel = new System.Windows.Forms.Label();
            this.engLabel = new System.Windows.Forms.Label();
            this.rusLabel = new System.Windows.Forms.Label();
            this.belLabel = new System.Windows.Forms.Label();
            this.netLabel = new System.Windows.Forms.Label();
            this.italyLabel = new System.Windows.Forms.Label();
            this.polLabel = new System.Windows.Forms.Label();
            this.sweLabel = new System.Windows.Forms.Label();
            this.turLabel = new System.Windows.Forms.Label();
            this.denLabel = new System.Windows.Forms.Label();
            this.irlLabel = new System.Windows.Forms.Label();
            this.scotLabel = new System.Windows.Forms.Label();
            this.ukrLabel = new System.Windows.Forms.Label();
            this.autLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Chartreuse;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.startButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.startButton.Location = new System.Drawing.Point(325, 387);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(158, 56);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start Simulation";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // Pot1Label
            // 
            this.Pot1Label.AutoEllipsis = true;
            this.Pot1Label.AutoSize = true;
            this.Pot1Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pot1Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pot1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pot1Label.Location = new System.Drawing.Point(3, 0);
            this.Pot1Label.Name = "Pot1Label";
            this.Pot1Label.Size = new System.Drawing.Size(149, 57);
            this.Pot1Label.TabIndex = 0;
            this.Pot1Label.Text = "Pot 1";
            this.Pot1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pot4Label
            // 
            this.Pot4Label.AutoSize = true;
            this.Pot4Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pot4Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pot4Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pot4Label.Location = new System.Drawing.Point(468, 0);
            this.Pot4Label.Name = "Pot4Label";
            this.Pot4Label.Size = new System.Drawing.Size(151, 57);
            this.Pot4Label.TabIndex = 0;
            this.Pot4Label.Text = "Pot 4";
            this.Pot4Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.franceLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Pot3Label, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.Pot1Label, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Pot4Label, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.Pot2Label, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.spainLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.germanyLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.engLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.rusLabel, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.belLabel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.netLabel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.italyLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.polLabel, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.sweLabel, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.turLabel, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.denLabel, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.irlLabel, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.scotLabel, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.ukrLabel, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.autLabel, 3, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(109, 55);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(622, 288);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // Pot3Label
            // 
            this.Pot3Label.AutoSize = true;
            this.Pot3Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pot3Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pot3Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pot3Label.Location = new System.Drawing.Point(313, 0);
            this.Pot3Label.Name = "Pot3Label";
            this.Pot3Label.Size = new System.Drawing.Size(149, 57);
            this.Pot3Label.TabIndex = 4;
            this.Pot3Label.Text = "Pot 3";
            this.Pot3Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pot2Label
            // 
            this.Pot2Label.AutoSize = true;
            this.Pot2Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pot2Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pot2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pot2Label.Location = new System.Drawing.Point(158, 0);
            this.Pot2Label.Name = "Pot2Label";
            this.Pot2Label.Size = new System.Drawing.Size(149, 57);
            this.Pot2Label.TabIndex = 3;
            this.Pot2Label.Text = "Pot 2";
            this.Pot2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // franceLabel
            // 
            this.franceLabel.AutoSize = true;
            this.franceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.franceLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.franceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.franceLabel.Image = ((System.Drawing.Image)(resources.GetObject("franceLabel.Image")));
            this.franceLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.franceLabel.Location = new System.Drawing.Point(3, 114);
            this.franceLabel.Name = "franceLabel";
            this.franceLabel.Size = new System.Drawing.Size(149, 57);
            this.franceLabel.TabIndex = 6;
            this.franceLabel.Text = "     France";
            this.franceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // spainLabel
            // 
            this.spainLabel.AutoSize = true;
            this.spainLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.spainLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.spainLabel.Image = global::DrawApp.UI.Properties.Resources.icons8_spain_flag_48;
            this.spainLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.spainLabel.Location = new System.Drawing.Point(3, 57);
            this.spainLabel.Name = "spainLabel";
            this.spainLabel.Size = new System.Drawing.Size(149, 57);
            this.spainLabel.TabIndex = 5;
            this.spainLabel.Text = "   Spain";
            this.spainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // germanyLabel
            // 
            this.germanyLabel.AutoSize = true;
            this.germanyLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.germanyLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.germanyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.germanyLabel.Image = ((System.Drawing.Image)(resources.GetObject("germanyLabel.Image")));
            this.germanyLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.germanyLabel.Location = new System.Drawing.Point(3, 171);
            this.germanyLabel.Name = "germanyLabel";
            this.germanyLabel.Size = new System.Drawing.Size(149, 57);
            this.germanyLabel.TabIndex = 6;
            this.germanyLabel.Text = "        Germany";
            this.germanyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // engLabel
            // 
            this.engLabel.AutoSize = true;
            this.engLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.engLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.engLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.engLabel.Image = ((System.Drawing.Image)(resources.GetObject("engLabel.Image")));
            this.engLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.engLabel.Location = new System.Drawing.Point(3, 228);
            this.engLabel.Name = "engLabel";
            this.engLabel.Size = new System.Drawing.Size(149, 60);
            this.engLabel.TabIndex = 6;
            this.engLabel.Text = "       England";
            this.engLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rusLabel
            // 
            this.rusLabel.AutoSize = true;
            this.rusLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rusLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.rusLabel.Image = ((System.Drawing.Image)(resources.GetObject("rusLabel.Image")));
            this.rusLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rusLabel.Location = new System.Drawing.Point(158, 228);
            this.rusLabel.Name = "rusLabel";
            this.rusLabel.Size = new System.Drawing.Size(149, 60);
            this.rusLabel.TabIndex = 6;
            this.rusLabel.Text = "    Russia";
            this.rusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // belLabel
            // 
            this.belLabel.AutoSize = true;
            this.belLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.belLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.belLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.belLabel.Image = ((System.Drawing.Image)(resources.GetObject("belLabel.Image")));
            this.belLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.belLabel.Location = new System.Drawing.Point(158, 171);
            this.belLabel.Name = "belLabel";
            this.belLabel.Size = new System.Drawing.Size(149, 57);
            this.belLabel.TabIndex = 6;
            this.belLabel.Text = "       Belgium";
            this.belLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // netLabel
            // 
            this.netLabel.AutoSize = true;
            this.netLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.netLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.netLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.netLabel.Image = ((System.Drawing.Image)(resources.GetObject("netLabel.Image")));
            this.netLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.netLabel.Location = new System.Drawing.Point(158, 114);
            this.netLabel.Name = "netLabel";
            this.netLabel.Size = new System.Drawing.Size(149, 57);
            this.netLabel.TabIndex = 6;
            this.netLabel.Text = "      Holland";
            this.netLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // italyLabel
            // 
            this.italyLabel.AutoSize = true;
            this.italyLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.italyLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.italyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.italyLabel.Image = ((System.Drawing.Image)(resources.GetObject("italyLabel.Image")));
            this.italyLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.italyLabel.Location = new System.Drawing.Point(158, 57);
            this.italyLabel.Name = "italyLabel";
            this.italyLabel.Size = new System.Drawing.Size(149, 57);
            this.italyLabel.TabIndex = 6;
            this.italyLabel.Text = " Italy";
            this.italyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // polLabel
            // 
            this.polLabel.AutoSize = true;
            this.polLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.polLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.polLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.polLabel.Image = ((System.Drawing.Image)(resources.GetObject("polLabel.Image")));
            this.polLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.polLabel.Location = new System.Drawing.Point(313, 57);
            this.polLabel.Name = "polLabel";
            this.polLabel.Size = new System.Drawing.Size(149, 57);
            this.polLabel.TabIndex = 6;
            this.polLabel.Text = "    Poland";
            this.polLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sweLabel
            // 
            this.sweLabel.AutoSize = true;
            this.sweLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sweLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sweLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.sweLabel.Image = ((System.Drawing.Image)(resources.GetObject("sweLabel.Image")));
            this.sweLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sweLabel.Location = new System.Drawing.Point(313, 114);
            this.sweLabel.Name = "sweLabel";
            this.sweLabel.Size = new System.Drawing.Size(149, 57);
            this.sweLabel.TabIndex = 6;
            this.sweLabel.Text = "       Sweden";
            this.sweLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // turLabel
            // 
            this.turLabel.AutoSize = true;
            this.turLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.turLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.turLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.turLabel.Image = ((System.Drawing.Image)(resources.GetObject("turLabel.Image")));
            this.turLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.turLabel.Location = new System.Drawing.Point(313, 171);
            this.turLabel.Name = "turLabel";
            this.turLabel.Size = new System.Drawing.Size(149, 57);
            this.turLabel.TabIndex = 6;
            this.turLabel.Text = "    Turkey";
            this.turLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // denLabel
            // 
            this.denLabel.AutoSize = true;
            this.denLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.denLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.denLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.denLabel.Image = ((System.Drawing.Image)(resources.GetObject("denLabel.Image")));
            this.denLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.denLabel.Location = new System.Drawing.Point(313, 228);
            this.denLabel.Name = "denLabel";
            this.denLabel.Size = new System.Drawing.Size(149, 60);
            this.denLabel.TabIndex = 6;
            this.denLabel.Text = "       Denmark";
            this.denLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // irlLabel
            // 
            this.irlLabel.AutoSize = true;
            this.irlLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.irlLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.irlLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.irlLabel.Image = ((System.Drawing.Image)(resources.GetObject("irlLabel.Image")));
            this.irlLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.irlLabel.Location = new System.Drawing.Point(468, 228);
            this.irlLabel.Name = "irlLabel";
            this.irlLabel.Size = new System.Drawing.Size(151, 60);
            this.irlLabel.TabIndex = 6;
            this.irlLabel.Text = "     Ireland";
            this.irlLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scotLabel
            // 
            this.scotLabel.AutoSize = true;
            this.scotLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scotLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scotLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.scotLabel.Image = ((System.Drawing.Image)(resources.GetObject("scotLabel.Image")));
            this.scotLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.scotLabel.Location = new System.Drawing.Point(468, 171);
            this.scotLabel.Name = "scotLabel";
            this.scotLabel.Size = new System.Drawing.Size(151, 57);
            this.scotLabel.TabIndex = 6;
            this.scotLabel.Text = "       Scotland";
            this.scotLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ukrLabel
            // 
            this.ukrLabel.AutoSize = true;
            this.ukrLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ukrLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ukrLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.ukrLabel.Image = ((System.Drawing.Image)(resources.GetObject("ukrLabel.Image")));
            this.ukrLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ukrLabel.Location = new System.Drawing.Point(468, 114);
            this.ukrLabel.Name = "ukrLabel";
            this.ukrLabel.Size = new System.Drawing.Size(151, 57);
            this.ukrLabel.TabIndex = 6;
            this.ukrLabel.Text = "     Ukraine";
            this.ukrLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // autLabel
            // 
            this.autLabel.AutoSize = true;
            this.autLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.autLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.autLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.autLabel.Image = ((System.Drawing.Image)(resources.GetObject("autLabel.Image")));
            this.autLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.autLabel.Location = new System.Drawing.Point(468, 57);
            this.autLabel.Name = "autLabel";
            this.autLabel.Size = new System.Drawing.Size(151, 57);
            this.autLabel.TabIndex = 6;
            this.autLabel.Text = "     Austria";
            this.autLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(809, 455);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.startButton);
            this.MaximumSize = new System.Drawing.Size(825, 494);
            this.MinimumSize = new System.Drawing.Size(825, 494);
            this.Name = "MainForm";
            this.Text = "Main Menu";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label Pot1Label;
        private System.Windows.Forms.Label Pot4Label;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Pot3Label;
        private System.Windows.Forms.Label Pot2Label;
        private System.Windows.Forms.Label franceLabel;
        private System.Windows.Forms.Label spainLabel;
        private System.Windows.Forms.Label germanyLabel;
        private System.Windows.Forms.Label engLabel;
        private System.Windows.Forms.Label rusLabel;
        private System.Windows.Forms.Label belLabel;
        private System.Windows.Forms.Label netLabel;
        private System.Windows.Forms.Label italyLabel;
        private System.Windows.Forms.Label polLabel;
        private System.Windows.Forms.Label sweLabel;
        private System.Windows.Forms.Label turLabel;
        private System.Windows.Forms.Label denLabel;
        private System.Windows.Forms.Label irlLabel;
        private System.Windows.Forms.Label scotLabel;
        private System.Windows.Forms.Label ukrLabel;
        private System.Windows.Forms.Label autLabel;
    }
}

