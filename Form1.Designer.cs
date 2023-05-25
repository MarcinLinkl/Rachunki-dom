using System.Linq;

namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.materialComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            this.materialComboBox2 = new MaterialSkin.Controls.MaterialComboBox();
            this.dtpicker = new System.Windows.Forms.DateTimePicker();
            this.txtbox2 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.btnWprowadz = new MaterialSkin.Controls.MaterialButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edytuj = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridReszta = new System.Windows.Forms.DataGridView();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.btnUsun = new MaterialSkin.Controls.MaterialButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listViewSuma = new System.Windows.Forms.ListView();
            this.txtbox3 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.dataGridGlowny = new System.Windows.Forms.DataGridView();
            this.comboNazwa = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReszta)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGlowny)).BeginInit();
            this.SuspendLayout();
            // 
            // materialComboBox1
            // 
            this.materialComboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.materialComboBox1.AutoResize = false;
            this.materialComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBox1.Depth = 0;
            this.materialComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox1.DropDownHeight = 174;
            this.materialComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox1.DropDownWidth = 121;
            this.materialComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBox1.FormattingEnabled = true;
            this.materialComboBox1.IntegralHeight = false;
            this.materialComboBox1.ItemHeight = 43;
            this.materialComboBox1.Location = new System.Drawing.Point(9, 131);
            this.materialComboBox1.MaxDropDownItems = 4;
            this.materialComboBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBox1.Name = "materialComboBox1";
            this.materialComboBox1.Size = new System.Drawing.Size(147, 49);
            this.materialComboBox1.StartIndex = 0;
            this.materialComboBox1.TabIndex = 1;
            // 
            // materialComboBox2
            // 
            this.materialComboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.materialComboBox2.AutoResize = false;
            this.materialComboBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBox2.Depth = 0;
            this.materialComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox2.DropDownHeight = 174;
            this.materialComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox2.DropDownWidth = 121;
            this.materialComboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBox2.FormattingEnabled = true;
            this.materialComboBox2.IntegralHeight = false;
            this.materialComboBox2.ItemHeight = 43;
            this.materialComboBox2.Location = new System.Drawing.Point(9, 186);
            this.materialComboBox2.MaxDropDownItems = 4;
            this.materialComboBox2.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBox2.Name = "materialComboBox2";
            this.materialComboBox2.Size = new System.Drawing.Size(147, 49);
            this.materialComboBox2.StartIndex = 0;
            this.materialComboBox2.TabIndex = 2;
            // 
            // dtpicker
            // 
            this.dtpicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpicker.Location = new System.Drawing.Point(668, 224);
            this.dtpicker.Name = "dtpicker";
            this.dtpicker.Size = new System.Drawing.Size(97, 29);
            this.dtpicker.TabIndex = 3;
            // 
            // txtbox2
            // 
            this.txtbox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbox2.AnimateReadOnly = false;
            this.txtbox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox2.Depth = 0;
            this.txtbox2.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtbox2.LeadingIcon = null;
            this.txtbox2.Location = new System.Drawing.Point(791, 120);
            this.txtbox2.MaxLength = 50;
            this.txtbox2.MouseState = MaterialSkin.MouseState.OUT;
            this.txtbox2.Multiline = false;
            this.txtbox2.Name = "txtbox2";
            this.txtbox2.Size = new System.Drawing.Size(124, 50);
            this.txtbox2.TabIndex = 4;
            this.txtbox2.Text = "";
            this.txtbox2.TrailingIcon = null;
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(829, 84);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(48, 19);
            this.materialLabel2.TabIndex = 6;
            this.materialLabel2.Text = "Opłata";
            // 
            // btnWprowadz
            // 
            this.btnWprowadz.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWprowadz.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnWprowadz.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnWprowadz.Depth = 0;
            this.btnWprowadz.HighEmphasis = true;
            this.btnWprowadz.Icon = null;
            this.btnWprowadz.Location = new System.Drawing.Point(810, 281);
            this.btnWprowadz.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnWprowadz.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnWprowadz.Name = "btnWprowadz";
            this.btnWprowadz.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnWprowadz.Size = new System.Drawing.Size(104, 36);
            this.btnWprowadz.TabIndex = 7;
            this.btnWprowadz.Text = "Wprowadź";
            this.btnWprowadz.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnWprowadz.UseAccentColor = false;
            this.btnWprowadz.UseVisualStyleBackColor = true;
            this.btnWprowadz.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 79);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(58, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.AutoToolTip = true;
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.edytuj});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // edytuj
            // 
            this.edytuj.Name = "edytuj";
            this.edytuj.Size = new System.Drawing.Size(107, 22);
            this.edytuj.Tag = "edytuj";
            this.edytuj.Text = "Edytuj";
            this.edytuj.Click += new System.EventHandler(this.edytuj_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridReszta);
            this.groupBox1.Location = new System.Drawing.Point(6, 358);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 228);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pozostałe opłaty do zapłacenia";
            // 
            // dataGridReszta
            // 
            this.dataGridReszta.AllowUserToAddRows = false;
            this.dataGridReszta.AllowUserToDeleteRows = false;
            this.dataGridReszta.AllowUserToResizeColumns = false;
            this.dataGridReszta.AllowUserToResizeRows = false;
            this.dataGridReszta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridReszta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridReszta.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridReszta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridReszta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridReszta.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridReszta.Location = new System.Drawing.Point(3, 19);
            this.dataGridReszta.Name = "dataGridReszta";
            this.dataGridReszta.RowHeadersVisible = false;
            this.dataGridReszta.RowTemplate.Height = 25;
            this.dataGridReszta.Size = new System.Drawing.Size(223, 206);
            this.dataGridReszta.TabIndex = 25;
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(694, 84);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(50, 19);
            this.materialLabel1.TabIndex = 16;
            this.materialLabel1.Text = "Nazwa";
            this.materialLabel1.UseAccent = true;
            // 
            // materialLabel4
            // 
            this.materialLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(697, 190);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(35, 19);
            this.materialLabel4.TabIndex = 17;
            this.materialLabel4.Text = "Data";
            // 
            // btnUsun
            // 
            this.btnUsun.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUsun.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUsun.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnUsun.Depth = 0;
            this.btnUsun.HighEmphasis = true;
            this.btnUsun.Icon = null;
            this.btnUsun.Location = new System.Drawing.Point(829, 358);
            this.btnUsun.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnUsun.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnUsun.Size = new System.Drawing.Size(64, 36);
            this.btnUsun.TabIndex = 20;
            this.btnUsun.Text = "Usuń";
            this.btnUsun.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnUsun.UseAccentColor = false;
            this.btnUsun.UseVisualStyleBackColor = true;
            this.btnUsun.Click += new System.EventHandler(this.materialButton2_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.listViewSuma);
            this.groupBox2.Location = new System.Drawing.Point(655, 282);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(148, 67);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Suma";
            // 
            // listViewSuma
            // 
            this.listViewSuma.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.listViewSuma.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewSuma.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewSuma.Location = new System.Drawing.Point(3, 19);
            this.listViewSuma.Name = "listViewSuma";
            this.listViewSuma.Size = new System.Drawing.Size(142, 45);
            this.listViewSuma.TabIndex = 0;
            this.listViewSuma.UseCompatibleStateImageBehavior = false;
            // 
            // txtbox3
            // 
            this.txtbox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbox3.AnimateReadOnly = false;
            this.txtbox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox3.Depth = 0;
            this.txtbox3.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtbox3.LeadingIcon = null;
            this.txtbox3.Location = new System.Drawing.Point(789, 212);
            this.txtbox3.MaxLength = 50;
            this.txtbox3.MouseState = MaterialSkin.MouseState.OUT;
            this.txtbox3.Multiline = false;
            this.txtbox3.Name = "txtbox3";
            this.txtbox3.Size = new System.Drawing.Size(125, 50);
            this.txtbox3.TabIndex = 23;
            this.txtbox3.Text = "";
            this.txtbox3.TrailingIcon = null;
            // 
            // materialLabel3
            // 
            this.materialLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(815, 179);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(78, 19);
            this.materialLabel3.TabIndex = 22;
            this.materialLabel3.Text = "Komentarz";
            this.materialLabel3.UseAccent = true;
            // 
            // dataGridGlowny
            // 
            this.dataGridGlowny.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridGlowny.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridGlowny.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridGlowny.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridGlowny.Location = new System.Drawing.Point(195, 85);
            this.dataGridGlowny.Name = "dataGridGlowny";
            this.dataGridGlowny.RowHeadersVisible = false;
            this.dataGridGlowny.RowTemplate.Height = 25;
            this.dataGridGlowny.Size = new System.Drawing.Size(454, 232);
            this.dataGridGlowny.TabIndex = 26;
            // 
            // comboNazwa
            // 
            this.comboNazwa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboNazwa.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboNazwa.FormattingEnabled = true;
            this.comboNazwa.Location = new System.Drawing.Point(668, 120);
            this.comboNazwa.Name = "comboNazwa";
            this.comboNazwa.Size = new System.Drawing.Size(110, 38);
            this.comboNazwa.TabIndex = 27;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(921, 624);
            this.Controls.Add(this.comboNazwa);
            this.Controls.Add(this.dataGridGlowny);
            this.Controls.Add(this.txtbox3);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnWprowadz);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.txtbox2);
            this.Controls.Add(this.dtpicker);
            this.Controls.Add(this.materialComboBox2);
            this.Controls.Add(this.materialComboBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Dom";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReszta)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGlowny)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

           
        #endregion
        private MaterialSkin.Controls.MaterialComboBox materialComboBox1;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox2;
        private DateTimePicker dtpicker;
        private MaterialSkin.Controls.MaterialTextBox txtbox2;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
      
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem edytuj;
        private GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialButton btnUsun;
        private GroupBox groupBox2;
        private ListView listViewSuma;
        private MaterialSkin.Controls.MaterialTextBox txtBox3;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private DataGridView dataGridReszta;
        private MaterialSkin.Controls.MaterialTextBox txtbox3;
        private MaterialSkin.Controls.MaterialButton btnWprowadz;
        private DataGridView dataGridGlowny;
        private ComboBox comboNazwa;
    }
}