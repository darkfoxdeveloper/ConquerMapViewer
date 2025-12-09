namespace ConquerMapViewer
{
    partial class ConquerMapViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConquerMapViewer));
            btnChooseClient = new ReaLTaiizor.Controls.MetroButton();
            tbxClientPath = new ReaLTaiizor.Controls.MetroTextBox();
            btnLoadClient = new ReaLTaiizor.Controls.MetroButton();
            lstMaps = new ReaLTaiizor.Controls.MetroListBox();
            clientPathSelector = new FolderBrowserDialog();
            lblMaps = new ReaLTaiizor.Controls.MetroLabel();
            pbxMap = new ReaLTaiizor.Controls.HopePictureBox();
            btnClose = new ReaLTaiizor.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)pbxMap).BeginInit();
            SuspendLayout();
            // 
            // btnChooseClient
            // 
            btnChooseClient.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            btnChooseClient.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            btnChooseClient.DisabledForeColor = Color.Gray;
            btnChooseClient.Font = new Font("Microsoft Sans Serif", 10F);
            btnChooseClient.HoverBorderColor = Color.FromArgb(95, 207, 255);
            btnChooseClient.HoverColor = Color.FromArgb(95, 207, 255);
            btnChooseClient.HoverTextColor = Color.White;
            btnChooseClient.IsDerivedStyle = true;
            btnChooseClient.Location = new Point(823, 99);
            btnChooseClient.Name = "btnChooseClient";
            btnChooseClient.NormalBorderColor = Color.FromArgb(65, 177, 225);
            btnChooseClient.NormalColor = Color.FromArgb(65, 177, 225);
            btnChooseClient.NormalTextColor = Color.White;
            btnChooseClient.PressBorderColor = Color.FromArgb(35, 147, 195);
            btnChooseClient.PressColor = Color.FromArgb(35, 147, 195);
            btnChooseClient.PressTextColor = Color.White;
            btnChooseClient.Size = new Size(82, 63);
            btnChooseClient.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            btnChooseClient.StyleManager = null;
            btnChooseClient.TabIndex = 0;
            btnChooseClient.Text = "...";
            btnChooseClient.ThemeAuthor = "Taiizor";
            btnChooseClient.ThemeName = "MetroLight";
            btnChooseClient.Click += BtnChooseClient_Click;
            // 
            // tbxClientPath
            // 
            tbxClientPath.AutoCompleteCustomSource = null;
            tbxClientPath.AutoCompleteMode = AutoCompleteMode.None;
            tbxClientPath.AutoCompleteSource = AutoCompleteSource.None;
            tbxClientPath.BorderColor = Color.FromArgb(155, 155, 155);
            tbxClientPath.DisabledBackColor = Color.FromArgb(204, 204, 204);
            tbxClientPath.DisabledBorderColor = Color.FromArgb(155, 155, 155);
            tbxClientPath.DisabledForeColor = Color.FromArgb(136, 136, 136);
            tbxClientPath.Font = new Font("Microsoft Sans Serif", 10F);
            tbxClientPath.HoverColor = Color.FromArgb(102, 102, 102);
            tbxClientPath.Image = null;
            tbxClientPath.IsDerivedStyle = true;
            tbxClientPath.Lines = null;
            tbxClientPath.Location = new Point(15, 99);
            tbxClientPath.MaxLength = 32767;
            tbxClientPath.Multiline = false;
            tbxClientPath.Name = "tbxClientPath";
            tbxClientPath.ReadOnly = false;
            tbxClientPath.Size = new Size(788, 63);
            tbxClientPath.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            tbxClientPath.StyleManager = null;
            tbxClientPath.TabIndex = 1;
            tbxClientPath.TextAlign = HorizontalAlignment.Left;
            tbxClientPath.ThemeAuthor = "Taiizor";
            tbxClientPath.ThemeName = "MetroLight";
            tbxClientPath.UseSystemPasswordChar = false;
            tbxClientPath.WatermarkText = "Your client path";
            // 
            // btnLoadClient
            // 
            btnLoadClient.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            btnLoadClient.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            btnLoadClient.DisabledForeColor = Color.Gray;
            btnLoadClient.Font = new Font("Microsoft Sans Serif", 10F);
            btnLoadClient.HoverBorderColor = Color.FromArgb(95, 207, 255);
            btnLoadClient.HoverColor = Color.FromArgb(95, 207, 255);
            btnLoadClient.HoverTextColor = Color.White;
            btnLoadClient.IsDerivedStyle = true;
            btnLoadClient.Location = new Point(922, 99);
            btnLoadClient.Name = "btnLoadClient";
            btnLoadClient.NormalBorderColor = Color.FromArgb(65, 177, 225);
            btnLoadClient.NormalColor = Color.FromArgb(65, 177, 225);
            btnLoadClient.NormalTextColor = Color.White;
            btnLoadClient.PressBorderColor = Color.FromArgb(35, 147, 195);
            btnLoadClient.PressColor = Color.FromArgb(35, 147, 195);
            btnLoadClient.PressTextColor = Color.White;
            btnLoadClient.Size = new Size(145, 63);
            btnLoadClient.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            btnLoadClient.StyleManager = null;
            btnLoadClient.TabIndex = 2;
            btnLoadClient.Text = "Load";
            btnLoadClient.ThemeAuthor = "Taiizor";
            btnLoadClient.ThemeName = "MetroLight";
            btnLoadClient.Click += BtnLoadClient_Click;
            // 
            // lstMaps
            // 
            lstMaps.BackColor = Color.White;
            lstMaps.BorderColor = Color.LightGray;
            lstMaps.DisabledBackColor = Color.FromArgb(204, 204, 204);
            lstMaps.DisabledForeColor = Color.FromArgb(136, 136, 136);
            lstMaps.Font = new Font("Microsoft Sans Serif", 10F);
            lstMaps.HoveredItemBackColor = Color.LightGray;
            lstMaps.HoveredItemColor = Color.DimGray;
            lstMaps.IsDerivedStyle = true;
            lstMaps.ItemHeight = 30;
            lstMaps.Location = new Point(15, 238);
            lstMaps.MultiSelect = false;
            lstMaps.Name = "lstMaps";
            lstMaps.SelectedIndex = -1;
            lstMaps.SelectedItem = null;
            lstMaps.SelectedItemBackColor = Color.FromArgb(65, 177, 225);
            lstMaps.SelectedItemColor = Color.White;
            lstMaps.SelectedText = null;
            lstMaps.SelectedValue = null;
            lstMaps.ShowBorder = false;
            lstMaps.ShowScrollBar = false;
            lstMaps.Size = new Size(788, 862);
            lstMaps.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            lstMaps.StyleManager = null;
            lstMaps.TabIndex = 3;
            lstMaps.ThemeAuthor = "Taiizor";
            lstMaps.ThemeName = "MetroLight";
            lstMaps.SelectedIndexChanged += LstMaps_SelectedIndexChanged;
            // 
            // lblMaps
            // 
            lblMaps.Font = new Font("Microsoft Sans Serif", 10F);
            lblMaps.IsDerivedStyle = true;
            lblMaps.Location = new Point(15, 185);
            lblMaps.Name = "lblMaps";
            lblMaps.Size = new Size(150, 34);
            lblMaps.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            lblMaps.StyleManager = null;
            lblMaps.TabIndex = 4;
            lblMaps.Text = "Maps:";
            lblMaps.ThemeAuthor = "Taiizor";
            lblMaps.ThemeName = "MetroLight";
            // 
            // pbxMap
            // 
            pbxMap.BackColor = Color.FromArgb(192, 196, 204);
            pbxMap.Location = new Point(809, 238);
            pbxMap.Name = "pbxMap";
            pbxMap.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            pbxMap.Size = new Size(1227, 862);
            pbxMap.SizeMode = PictureBoxSizeMode.Zoom;
            pbxMap.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            pbxMap.TabIndex = 5;
            pbxMap.TabStop = false;
            pbxMap.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // btnClose
            // 
            btnClose.DisabledBackColor = Color.FromArgb(120, 65, 177, 225);
            btnClose.DisabledBorderColor = Color.FromArgb(120, 65, 177, 225);
            btnClose.DisabledForeColor = Color.Gray;
            btnClose.Font = new Font("Microsoft Sans Serif", 10F);
            btnClose.HoverBorderColor = Color.FromArgb(95, 207, 255);
            btnClose.HoverColor = Color.FromArgb(95, 207, 255);
            btnClose.HoverTextColor = Color.White;
            btnClose.IsDerivedStyle = true;
            btnClose.Location = new Point(1996, 9);
            btnClose.Name = "btnClose";
            btnClose.NormalBorderColor = Color.FromArgb(65, 177, 225);
            btnClose.NormalColor = Color.FromArgb(65, 177, 225);
            btnClose.NormalTextColor = Color.White;
            btnClose.PressBorderColor = Color.FromArgb(35, 147, 195);
            btnClose.PressColor = Color.FromArgb(35, 147, 195);
            btnClose.PressTextColor = Color.White;
            btnClose.Size = new Size(40, 51);
            btnClose.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            btnClose.StyleManager = null;
            btnClose.TabIndex = 6;
            btnClose.Text = "x";
            btnClose.ThemeAuthor = "Taiizor";
            btnClose.ThemeName = "MetroLight";
            btnClose.Click += BtnClose_Click;
            // 
            // ConquerMapViewer
            // 
            AllowResize = false;
            AutoScaleDimensions = new SizeF(15F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2051, 1115);
            Controls.Add(btnClose);
            Controls.Add(pbxMap);
            Controls.Add(lblMaps);
            Controls.Add(lstMaps);
            Controls.Add(btnLoadClient);
            Controls.Add(tbxClientPath);
            Controls.Add(btnChooseClient);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ConquerMapViewer";
            Padding = new Padding(12, 90, 12, 12);
            Text = "ConquerMapViewer 1.0";
            Load += MapViewer_Load;
            ((System.ComponentModel.ISupportInitialize)pbxMap).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MetroButton btnChooseClient;
        private ReaLTaiizor.Controls.MetroTextBox tbxClientPath;
        private ReaLTaiizor.Controls.MetroButton btnLoadClient;
        private ReaLTaiizor.Controls.MetroListBox lstMaps;
        private FolderBrowserDialog clientPathSelector;
        private ReaLTaiizor.Controls.MetroLabel lblMaps;
        private ReaLTaiizor.Controls.HopePictureBox pbxMap;
        private ReaLTaiizor.Controls.MetroButton btnClose;
    }
}