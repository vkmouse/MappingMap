
namespace MappingMap
{
    partial class MappingMapView
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
            this.btnSetting = new System.Windows.Forms.Button();
            this.pnlSetting = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboMode = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRelativeLocation = new System.Windows.Forms.TextBox();
            this.txtImagePath = new MappingMap.SelectPathControl();
            this.vsbImageScale = new MappingMap.TextScrollBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.picDisplayImage = new System.Windows.Forms.PictureBox();
            this.pnlSetting.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDisplayImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSetting
            // 
            this.btnSetting.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSetting.Location = new System.Drawing.Point(257, 0);
            this.btnSetting.Margin = new System.Windows.Forms.Padding(0);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(20, 450);
            this.btnSetting.TabIndex = 28;
            this.btnSetting.UseVisualStyleBackColor = true;
            // 
            // pnlSetting
            // 
            this.pnlSetting.Controls.Add(this.tableLayoutPanel1);
            this.pnlSetting.Controls.Add(this.menuStrip1);
            this.pnlSetting.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSetting.Font = new System.Drawing.Font("Arial", 9.75F);
            this.pnlSetting.Location = new System.Drawing.Point(0, 0);
            this.pnlSetting.Name = "pnlSetting";
            this.pnlSetting.Size = new System.Drawing.Size(257, 450);
            this.pnlSetting.TabIndex = 32;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cboMode, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtRelativeLocation, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtImagePath, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.vsbImageScale, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(257, 105);
            this.tableLayoutPanel1.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mode";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 23);
            this.label6.TabIndex = 1;
            this.label6.Text = "Image Path";
            // 
            // cboMode
            // 
            this.cboMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMode.Font = new System.Drawing.Font("Arial", 9.75F);
            this.cboMode.FormattingEnabled = true;
            this.cboMode.Items.AddRange(new object[] {
            "Setting",
            "Mapping"});
            this.cboMode.Location = new System.Drawing.Point(129, 2);
            this.cboMode.Margin = new System.Windows.Forms.Padding(0);
            this.cboMode.Name = "cboMode";
            this.cboMode.Size = new System.Drawing.Size(126, 24);
            this.cboMode.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Image Scale";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Relative Location";
            // 
            // txtRelativeLocation
            // 
            this.txtRelativeLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRelativeLocation.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txtRelativeLocation.Location = new System.Drawing.Point(129, 77);
            this.txtRelativeLocation.Margin = new System.Windows.Forms.Padding(0);
            this.txtRelativeLocation.Name = "txtRelativeLocation";
            this.txtRelativeLocation.ReadOnly = true;
            this.txtRelativeLocation.Size = new System.Drawing.Size(126, 22);
            this.txtRelativeLocation.TabIndex = 31;
            // 
            // txtImagePath
            // 
            this.txtImagePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtImagePath.Location = new System.Drawing.Point(129, 27);
            this.txtImagePath.Margin = new System.Windows.Forms.Padding(0);
            this.txtImagePath.Name = "txtImagePath";
            this.txtImagePath.Size = new System.Drawing.Size(126, 23);
            this.txtImagePath.TabIndex = 32;
            // 
            // vsbImageScale
            // 
            this.vsbImageScale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vsbImageScale.Location = new System.Drawing.Point(129, 52);
            this.vsbImageScale.Margin = new System.Windows.Forms.Padding(0);
            this.vsbImageScale.Maximum = 9999;
            this.vsbImageScale.Minimum = -9999;
            this.vsbImageScale.Name = "vsbImageScale";
            this.vsbImageScale.Size = new System.Drawing.Size(126, 23);
            this.vsbImageScale.TabIndex = 33;
            this.vsbImageScale.Value = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(257, 24);
            this.menuStrip1.TabIndex = 31;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSave,
            this.mnuLoad});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mnuSave
            // 
            this.mnuSave.Name = "mnuSave";
            this.mnuSave.Size = new System.Drawing.Size(103, 22);
            this.mnuSave.Text = "Save";
            // 
            // mnuLoad
            // 
            this.mnuLoad.Name = "mnuLoad";
            this.mnuLoad.Size = new System.Drawing.Size(103, 22);
            this.mnuLoad.Text = "Load";
            // 
            // picDisplayImage
            // 
            this.picDisplayImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picDisplayImage.Location = new System.Drawing.Point(277, 0);
            this.picDisplayImage.Name = "picDisplayImage";
            this.picDisplayImage.Size = new System.Drawing.Size(523, 450);
            this.picDisplayImage.TabIndex = 33;
            this.picDisplayImage.TabStop = false;
            // 
            // MappingMapView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picDisplayImage);
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.pnlSetting);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MappingMapView";
            this.Text = "MappingMap";
            this.pnlSetting.ResumeLayout(false);
            this.pnlSetting.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDisplayImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Button btnSetting;
        public System.Windows.Forms.Panel pnlSetting;
        public System.Windows.Forms.ToolStripMenuItem mnuSave;
        public System.Windows.Forms.ToolStripMenuItem mnuLoad;
        public System.Windows.Forms.ComboBox cboMode;
        public System.Windows.Forms.TextBox txtRelativeLocation;
        public SelectPathControl txtImagePath;
        public TextScrollBar vsbImageScale;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;        
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.PictureBox picDisplayImage;
    }
}

