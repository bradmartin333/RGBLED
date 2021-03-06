namespace RGBLED
{
    partial class View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View));
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.PanelColor = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxPort = new System.Windows.Forms.TextBox();
            this.ScrollHSV = new System.Windows.Forms.VScrollBar();
            this.LabelHSV = new System.Windows.Forms.Label();
            this.ButtonConnect = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.NumWhite = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumWhite)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 3;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Controls.Add(this.PanelColor, 0, 4);
            this.tableLayoutPanel.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.TextBoxPort, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.ScrollHSV, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.LabelHSV, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.ButtonConnect, 2, 0);
            this.tableLayoutPanel.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.NumWhite, 1, 1);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 5;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(185, 400);
            this.tableLayoutPanel.TabIndex = 1;
            // 
            // PanelColor
            // 
            this.PanelColor.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel.SetColumnSpan(this.PanelColor, 3);
            this.PanelColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelColor.Location = new System.Drawing.Point(3, 368);
            this.PanelColor.Name = "PanelColor";
            this.PanelColor.Size = new System.Drawing.Size(179, 29);
            this.PanelColor.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Brainbox Port";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBoxPort
            // 
            this.TextBoxPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxPort.Location = new System.Drawing.Point(79, 3);
            this.TextBoxPort.Name = "TextBoxPort";
            this.TextBoxPort.Size = new System.Drawing.Size(83, 20);
            this.TextBoxPort.TabIndex = 4;
            this.TextBoxPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ScrollHSV
            // 
            this.tableLayoutPanel.SetColumnSpan(this.ScrollHSV, 3);
            this.ScrollHSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScrollHSV.LargeChange = 1;
            this.ScrollHSV.Location = new System.Drawing.Point(0, 55);
            this.ScrollHSV.Maximum = 360;
            this.ScrollHSV.Name = "ScrollHSV";
            this.ScrollHSV.Size = new System.Drawing.Size(185, 290);
            this.ScrollHSV.TabIndex = 6;
            // 
            // LabelHSV
            // 
            this.LabelHSV.AutoSize = true;
            this.tableLayoutPanel.SetColumnSpan(this.LabelHSV, 3);
            this.LabelHSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelHSV.Location = new System.Drawing.Point(3, 345);
            this.LabelHSV.Name = "LabelHSV";
            this.LabelHSV.Size = new System.Drawing.Size(179, 20);
            this.LabelHSV.TabIndex = 7;
            this.LabelHSV.Text = "0°";
            this.LabelHSV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonConnect
            // 
            this.ButtonConnect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonConnect.BackgroundImage")));
            this.ButtonConnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonConnect.FlatAppearance.BorderSize = 0;
            this.ButtonConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonConnect.Location = new System.Drawing.Point(168, 3);
            this.ButtonConnect.Name = "ButtonConnect";
            this.ButtonConnect.Size = new System.Drawing.Size(14, 23);
            this.ButtonConnect.TabIndex = 9;
            this.ButtonConnect.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 26);
            this.label3.TabIndex = 10;
            this.label3.Text = "White";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NumWhite
            // 
            this.tableLayoutPanel.SetColumnSpan(this.NumWhite, 2);
            this.NumWhite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NumWhite.Location = new System.Drawing.Point(79, 32);
            this.NumWhite.Name = "NumWhite";
            this.NumWhite.Size = new System.Drawing.Size(103, 20);
            this.NumWhite.TabIndex = 11;
            this.NumWhite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(185, 400);
            this.Controls.Add(this.tableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "View";
            this.Text = "RGBLED";
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumWhite)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxPort;
        private System.Windows.Forms.VScrollBar ScrollHSV;
        private System.Windows.Forms.Label LabelHSV;
        private System.Windows.Forms.Panel PanelColor;
        private System.Windows.Forms.Button ButtonConnect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown NumWhite;
    }
}

