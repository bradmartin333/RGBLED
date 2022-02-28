namespace RGBLED
{
    partial class FormMain
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageHSV = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelHSV = new System.Windows.Forms.TableLayoutPanel();
            this.vScrollBarHSV = new System.Windows.Forms.VScrollBar();
            this.labelHSV = new System.Windows.Forms.Label();
            this.tabPageRGB = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelR = new System.Windows.Forms.Label();
            this.labelG = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.labelRval = new System.Windows.Forms.Label();
            this.labelGval = new System.Windows.Forms.Label();
            this.labelBval = new System.Windows.Forms.Label();
            this.vScrollBarR = new System.Windows.Forms.VScrollBar();
            this.vScrollBarG = new System.Windows.Forms.VScrollBar();
            this.vScrollBarB = new System.Windows.Forms.VScrollBar();
            this.tabPageSettings = new System.Windows.Forms.TabPage();
            this.propertyGrid = new System.Windows.Forms.PropertyGrid();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panelColor = new System.Windows.Forms.Panel();
            this.tabControl.SuspendLayout();
            this.tabPageHSV.SuspendLayout();
            this.tableLayoutPanelHSV.SuspendLayout();
            this.tabPageRGB.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPageSettings.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageHSV);
            this.tabControl.Controls.Add(this.tabPageRGB);
            this.tabControl.Controls.Add(this.tabPageSettings);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(3, 3);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(209, 374);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageHSV
            // 
            this.tabPageHSV.Controls.Add(this.tableLayoutPanelHSV);
            this.tabPageHSV.Location = new System.Drawing.Point(4, 22);
            this.tabPageHSV.Name = "tabPageHSV";
            this.tabPageHSV.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHSV.Size = new System.Drawing.Size(131, 348);
            this.tabPageHSV.TabIndex = 0;
            this.tabPageHSV.Text = "HSV";
            this.tabPageHSV.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelHSV
            // 
            this.tableLayoutPanelHSV.ColumnCount = 1;
            this.tableLayoutPanelHSV.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelHSV.Controls.Add(this.vScrollBarHSV, 0, 0);
            this.tableLayoutPanelHSV.Controls.Add(this.labelHSV, 0, 1);
            this.tableLayoutPanelHSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelHSV.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelHSV.Name = "tableLayoutPanelHSV";
            this.tableLayoutPanelHSV.RowCount = 2;
            this.tableLayoutPanelHSV.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelHSV.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelHSV.Size = new System.Drawing.Size(125, 342);
            this.tableLayoutPanelHSV.TabIndex = 0;
            // 
            // vScrollBarHSV
            // 
            this.vScrollBarHSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vScrollBarHSV.Location = new System.Drawing.Point(0, 0);
            this.vScrollBarHSV.Name = "vScrollBarHSV";
            this.vScrollBarHSV.Size = new System.Drawing.Size(125, 329);
            this.vScrollBarHSV.TabIndex = 0;
            // 
            // labelHSV
            // 
            this.labelHSV.AutoSize = true;
            this.labelHSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelHSV.Location = new System.Drawing.Point(3, 329);
            this.labelHSV.Name = "labelHSV";
            this.labelHSV.Size = new System.Drawing.Size(119, 13);
            this.labelHSV.TabIndex = 1;
            this.labelHSV.Text = "0°";
            this.labelHSV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPageRGB
            // 
            this.tabPageRGB.Controls.Add(this.tableLayoutPanel1);
            this.tabPageRGB.Location = new System.Drawing.Point(4, 22);
            this.tabPageRGB.Name = "tabPageRGB";
            this.tabPageRGB.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRGB.Size = new System.Drawing.Size(131, 348);
            this.tabPageRGB.TabIndex = 1;
            this.tabPageRGB.Text = "RGB";
            this.tabPageRGB.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.labelR, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelG, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelB, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelRval, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelGval, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelBval, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.vScrollBarR, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.vScrollBarG, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.vScrollBarB, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(125, 342);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // labelR
            // 
            this.labelR.AutoSize = true;
            this.labelR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelR.Location = new System.Drawing.Point(3, 0);
            this.labelR.Name = "labelR";
            this.labelR.Size = new System.Drawing.Size(35, 20);
            this.labelR.TabIndex = 0;
            this.labelR.Text = "R";
            this.labelR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelG
            // 
            this.labelG.AutoSize = true;
            this.labelG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelG.Location = new System.Drawing.Point(44, 0);
            this.labelG.Name = "labelG";
            this.labelG.Size = new System.Drawing.Size(35, 20);
            this.labelG.TabIndex = 1;
            this.labelG.Text = "G";
            this.labelG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelB.Location = new System.Drawing.Point(85, 0);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(37, 20);
            this.labelB.TabIndex = 2;
            this.labelB.Text = "B";
            this.labelB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRval
            // 
            this.labelRval.AutoSize = true;
            this.labelRval.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelRval.Location = new System.Drawing.Point(3, 322);
            this.labelRval.Name = "labelRval";
            this.labelRval.Size = new System.Drawing.Size(35, 20);
            this.labelRval.TabIndex = 3;
            this.labelRval.Text = "0";
            this.labelRval.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelGval
            // 
            this.labelGval.AutoSize = true;
            this.labelGval.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelGval.Location = new System.Drawing.Point(44, 322);
            this.labelGval.Name = "labelGval";
            this.labelGval.Size = new System.Drawing.Size(35, 20);
            this.labelGval.TabIndex = 4;
            this.labelGval.Text = "0";
            this.labelGval.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBval
            // 
            this.labelBval.AutoSize = true;
            this.labelBval.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelBval.Location = new System.Drawing.Point(85, 322);
            this.labelBval.Name = "labelBval";
            this.labelBval.Size = new System.Drawing.Size(37, 20);
            this.labelBval.TabIndex = 5;
            this.labelBval.Text = "0";
            this.labelBval.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vScrollBarR
            // 
            this.vScrollBarR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vScrollBarR.Location = new System.Drawing.Point(0, 20);
            this.vScrollBarR.Maximum = 255;
            this.vScrollBarR.Name = "vScrollBarR";
            this.vScrollBarR.Size = new System.Drawing.Size(41, 302);
            this.vScrollBarR.TabIndex = 6;
            // 
            // vScrollBarG
            // 
            this.vScrollBarG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vScrollBarG.Location = new System.Drawing.Point(41, 20);
            this.vScrollBarG.Maximum = 255;
            this.vScrollBarG.Name = "vScrollBarG";
            this.vScrollBarG.Size = new System.Drawing.Size(41, 302);
            this.vScrollBarG.TabIndex = 7;
            // 
            // vScrollBarB
            // 
            this.vScrollBarB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vScrollBarB.Location = new System.Drawing.Point(82, 20);
            this.vScrollBarB.Maximum = 255;
            this.vScrollBarB.Name = "vScrollBarB";
            this.vScrollBarB.Size = new System.Drawing.Size(43, 302);
            this.vScrollBarB.TabIndex = 8;
            // 
            // tabPageSettings
            // 
            this.tabPageSettings.Controls.Add(this.propertyGrid);
            this.tabPageSettings.Location = new System.Drawing.Point(4, 22);
            this.tabPageSettings.Name = "tabPageSettings";
            this.tabPageSettings.Size = new System.Drawing.Size(201, 348);
            this.tabPageSettings.TabIndex = 2;
            this.tabPageSettings.Text = "Settings";
            this.tabPageSettings.UseVisualStyleBackColor = true;
            // 
            // propertyGrid
            // 
            this.propertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid.Location = new System.Drawing.Point(0, 0);
            this.propertyGrid.Name = "propertyGrid";
            this.propertyGrid.Size = new System.Drawing.Size(201, 348);
            this.propertyGrid.TabIndex = 0;
            this.propertyGrid.ToolbarVisible = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.tabControl, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.panelColor, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(215, 400);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // panelColor
            // 
            this.panelColor.BackColor = System.Drawing.Color.Black;
            this.panelColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelColor.Location = new System.Drawing.Point(3, 383);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(209, 14);
            this.panelColor.TabIndex = 1;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 400);
            this.Controls.Add(this.tableLayoutPanel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FormMain";
            this.Text = "RGBLED";
            this.tabControl.ResumeLayout(false);
            this.tabPageHSV.ResumeLayout(false);
            this.tableLayoutPanelHSV.ResumeLayout(false);
            this.tableLayoutPanelHSV.PerformLayout();
            this.tabPageRGB.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabPageSettings.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageHSV;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelHSV;
        private System.Windows.Forms.VScrollBar vScrollBarHSV;
        private System.Windows.Forms.Label labelHSV;
        private System.Windows.Forms.TabPage tabPageRGB;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelR;
        private System.Windows.Forms.Label labelG;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelRval;
        private System.Windows.Forms.Label labelGval;
        private System.Windows.Forms.Label labelBval;
        private System.Windows.Forms.VScrollBar vScrollBarR;
        private System.Windows.Forms.VScrollBar vScrollBarG;
        private System.Windows.Forms.VScrollBar vScrollBarB;
        private System.Windows.Forms.TabPage tabPageSettings;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panelColor;
        private System.Windows.Forms.PropertyGrid propertyGrid;
    }
}

