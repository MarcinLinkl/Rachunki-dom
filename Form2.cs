using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using System.Web;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace WinFormsApp1
{
    public partial class Form2 : MaterialSkin.Controls.MaterialForm
    {
        MaterialSkin.MaterialSkinManager skinManager;
        public Form2()
        {
            InitializeComponent();
            skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new ColorScheme(Primary.Green700, Primary.Grey800, Primary.Grey900, Accent.LightBlue200, TextShade.WHITE);

        }

        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textAdd = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(69, 84);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(251, 214);
            this.listBox1.TabIndex = 0;
            // 
            // textAdd
            // 
            this.textAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textAdd.Location = new System.Drawing.Point(69, 331);
            this.textAdd.Name = "textAdd";
            this.textAdd.Size = new System.Drawing.Size(251, 23);
            this.textAdd.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(69, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(251, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(69, 389);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(251, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Usuń";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(69, 418);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(251, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(394, 495);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textAdd);
            this.Controls.Add(this.listBox1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

    
        private void button1_Click(object sender, EventArgs e)
        {
            string a = textAdd.Text.ToString();
            if (listBox1.Items.Contains(a))
            {
                DialogResult result = MessageBox.Show("Element już jest, czy chcesz go dodać kolejny raz?", "Uwaga!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error);
                if (result != DialogResult.Yes)
                {
                    return;
                }
            }
                listBox1.Items.Add(a);
        }
                
        

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textAdd2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {

           
            
            this.Close();

            
          
        }
       
           public void save_to_json(string jsondata)
        {
            string path = String.Format(@"{0}\data.json", Application.StartupPath);
            MessageBox.Show(jsondata);
            File.WriteAllText(path, jsondata);
        }
    }
}


