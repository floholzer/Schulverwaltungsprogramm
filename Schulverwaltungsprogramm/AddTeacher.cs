using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schulverwaltungsprogramm
{
    public partial class AddTeacher : Form
    {
        public AddTeacher()
        {
            InitializeComponent();
            comboBox_Gender.Items.Add("Männlich");
            comboBox_Gender.Items.Add("Weiblich");
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (
               tB_Firstname.Text.Length <= 0 ||
               tB_Lastname.Text.Length <= 0 ||
               dateTimePicker1.Value >= DateTime.Today ||
               comboBox_Gender.SelectedIndex == -1
               ) { MessageBox.Show("Bitte füllen Sie alle Felder aus!"); Console.WriteLine(dateTimePicker1.Value); }
            else
            {
                Form1.personen.Add(new Lehrer
                {
                    vorname = tB_Firstname.Text,
                    nachname = tB_Lastname.Text,
                    geburtsdatum = dateTimePicker1.Value,
                    geschlecht = comboBox_Gender.SelectedItem.ToString()
                });
                Hide();
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
