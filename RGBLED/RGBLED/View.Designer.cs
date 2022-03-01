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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageHSV = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelHSV = new System.Windows.Forms.TableLayoutPanel();
            this.vScrollBarHSV = new System.Windows.Forms.VScrollBar();
            this.labelHSVval = new System.Windows.Forms.Label();
            this.tabPageSettings = new System.Windows.Forms.TabPage();
            this.propertyGrid = new System.Windows.Forms.PropertyGrid();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panelColor = new System.Windows.Forms.Panel();
            this.tabControl.SuspendLayout();
            this.tabPageHSV.SuspendLayout();
            this.tableLayoutPanelHSV.SuspendLayout();
            this.tabPageSettings.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageHSV);
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
            this.tabPageHSV.Size = new System.Drawing.Size(201, 348);
            this.tabPageHSV.TabIndex = 0;
            this.tabPageHSV.Text = "HSV";
            this.tabPageHSV.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelHSV
            // 
            this.tableLayoutPanelHSV.ColumnCount = 1;
            this.tableLayoutPanelHSV.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelHSV.Controls.Add(this.vScrollBarHSV, 0, 0);
            this.tableLayoutPanelHSV.Controls.Add(this.labelHSVval, 0, 1);
            this.tableLayoutPanelHSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelHSV.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelHSV.Name = "tableLayoutPanelHSV";
            this.tableLayoutPanelHSV.RowCount = 2;
            this.tableLayoutPanelHSV.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelHSV.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelHSV.Size = new System.Drawing.Size(195, 342);
            this.tableLayoutPanelHSV.TabIndex = 0;
            // 
            // vScrollBarHSV
            // 
            this.vScrollBarHSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vScrollBarHSV.LargeChange = 1;
            this.vScrollBarHSV.Location = new System.Drawing.Point(0, 0);
            this.vScrollBarHSV.Maximum = 360;
            this.vScrollBarHSV.Name = "vScrollBarHSV";
            this.vScrollBarHSV.Size = new System.Drawing.Size(195, 329);
            this.vScrollBarHSV.TabIndex = 0;
            // 
            // labelHSVval
            // 
            this.labelHSVval.AutoSize = true;
            this.labelHSVval.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelHSVval.Location = new System.Drawing.Point(3, 329);
            this.labelHSVval.Name = "labelHSVval";
            this.labelHSVval.Size = new System.Drawing.Size(189, 13);
            this.labelHSVval.TabIndex = 1;
            this.labelHSVval.Text = "0°";
            this.labelHSVval.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // FormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 400);
            this.Controls.Add(this.tableLayoutPanel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FormView";
            this.Text = "RGBLED";
            this.tabControl.ResumeLayout(false);
            this.tabPageHSV.ResumeLayout(false);
            this.tableLayoutPanelHSV.ResumeLayout(false);
            this.tableLayoutPanelHSV.PerformLayout();
            this.tabPageSettings.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageHSV;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelHSV;
        private System.Windows.Forms.Label labelHSVval;
        private System.Windows.Forms.TabPage tabPageSettings;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.PropertyGrid propertyGrid;
        public System.Windows.Forms.VScrollBar vScrollBarHSV;
        public System.Windows.Forms.Panel panelColor;
    }
}

