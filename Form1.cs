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

using System.Collections.Generic;
namespace WinFormsApp1

{
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {
        MaterialSkin.MaterialSkinManager skinManager;
        DataTable table = new DataTable("table");
        DataTable table2 = new DataTable("table");

        public Form1()
        {
            

            InitializeComponent();
            skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new ColorScheme(Primary.Green700, Primary.Grey800, Primary.Grey900, Accent.LightBlue200, TextShade.WHITE);
           
        }




        List<string> Op³aty = new List<string>()
     
        {
            "Telefon","Czynsz","Gaz", "Woda","Pr¹d","Ubezpieczenie samochodu"
        };

      

        public void AddOplaty()

        {
           

            
            table.Rows.Add(comboNazwa.Text, txtbox2.Text, dtpicker.Text, txtbox3.Text);
          



        }


        Object[] miesiace = new object[] {
            "styczeñ",
            "luty",
            "marzec",
            "kwiecieñ",
            "maj",
            "czerwiec",
            "lipiec",
            "sierpieñ",
            "wrzesieñ",
            "paŸdziernik",
            "listopad",
            "grudzieñ"};
       
        private void Form1_Load(object sender, EventArgs e)
        {
          
            dataGridGlowny.DefaultCellStyle.ForeColor = Color.Green;
            table.Columns.Add("Nazwa", Type.GetType("System.String"));
            table.Columns.Add("Op³ata", Type.GetType("System.Single"));
            table.Columns.Add("Data", Type.GetType("System.DateTime"));
            table.Columns.Add("Komentarz", Type.GetType("System.String"));
            dataGridGlowny.DataSource = table;

            dataGridReszta.DefaultCellStyle.ForeColor = Color.DarkRed;
            table2.Columns.Add("Op³aty", Type.GetType("System.String"));
            dataGridReszta.DataSource = table2;

            materialComboBox1.Items.AddRange(miesiace);
            int mTD= DateTime.Today.Month;
            materialComboBox1.SelectedIndex = mTD-1;
            int yTD = DateTime.Today.Year;
            IEnumerable<int> items = Enumerable.Range(2015, yTD - 2014).Reverse();
            Object[] lata = items.Cast<object>().ToArray();
            materialComboBox2.Items.AddRange(lata);
            materialComboBox2.SelectedIndex = 0;
            comboNazwa.Items.AddRange(Op³aty.ToArray());
            //read("Data.json");
            aktualizuj_oplaty();

        }

   
        public void aktualizuj_oplaty()
        {   
            List<string> list = new List<string>();
            if (dataGridGlowny.Rows.Count > 1)
            {

                foreach (DataGridViewRow item in dataGridGlowny.Rows)
                {
                    string a = Convert.ToString(item.Cells[0].Value);
                    if (Op³aty.Contains(a)){

                        Op³aty.Remove(a);
                    }

                }
            }
            table2.Rows.Clear();
            foreach (var item in Op³aty)
            {
                table2.Rows.Add(item);
            }
            

        }


        private void read(object file)
        {
            string path = String.Format(@"{0}\{1}", Application.StartupPath, file);
            var a=File.ReadAllLines(path);
           
        }

        private void edytuj_Click(object sender, EventArgs e)
        {
            var myForm2 = new Form2();
            myForm2.ShowDialog();
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            var myForm2 = new Form2();
            myForm2.ShowDialog();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            if (txtbox2.Text == "" || comboNazwa.SelectedItem== null)
            {
                DialogResult result = MessageBox.Show("Mimo to dodaæ op³atê?", "Uwaga! Komórka pusta", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (result != DialogResult.Yes)
                {
                    return;
                }
            }
            long number1 = 0;
            bool canConvert = long.TryParse(txtbox2.Text, out number1);
            if (canConvert != true)
            {
                MessageBox.Show("WprowadŸ wartoœæ liczbow¹ w komórce \"Op³ata\" aby kontynuowaæ", "Uwaga! B³¹d, nie wprowadzono wartoœci liczbowej", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
                
            }
            
            AddOplaty();
            aktualizuj_oplaty();



            aktualizuj_sume();
            comboNazwa.Items.Clear();
            comboNazwa.Items.AddRange(Op³aty.ToArray());
        }

  

        public void materialButton2_Click_1(object sender, EventArgs e)
        {
            if (dataGridGlowny.Rows.Count > 0)
            {
                int rowIndex = dataGridGlowny.CurrentCell.RowIndex;
                
               
                dataGridGlowny.Rows.RemoveAt(rowIndex);
                aktualizuj_oplaty();
                aktualizuj_sume();

            }
            

        }

        private void aktualizuj_sume()
        {
            decimal valorAcumulado = 0;
            for (int i = 0; i < dataGridGlowny.Rows.Count; i++)
            {

                valorAcumulado += Convert.ToDecimal(dataGridGlowny.Rows[i].Cells[1].Value);
            }

            listViewSuma.Items.Clear();

            listViewSuma.Items.Add(valorAcumulado.ToString() + "zl");
        }

    

        internal record struct NewStruct(object Item1, object Item2)
    {
        public static implicit operator (object, object)(NewStruct value)
        {
            return (value.Item1, value.Item2);
        }

        public static implicit operator NewStruct((object, object) value)
        {
            return new NewStruct(value.Item1, value.Item2);
        }
    }
}


}