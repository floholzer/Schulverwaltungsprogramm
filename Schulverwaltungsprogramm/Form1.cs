using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schulverwaltungsprogramm
{
    public partial class Form1 : Form
    {
        public static List<Person> personen = new List<Person>();
        public Form1()
        {
            InitializeComponent();
            
        }
        AddTeacher Form_AddTeacher = new AddTeacher();


        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = personen;
        }

        private void btn_add_Teacher_Click(object sender, EventArgs e)
        {
            DialogResult result = Form_AddTeacher.ShowDialog();

            if (result == DialogResult.OK)
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = personen;
            }

        }
        private void btn_add_student_Click(object sender, EventArgs e)
        {

        }

        private void btn_delete_person_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedPerson = (Person)dataGridView1.SelectedRows[0].DataBoundItem;
                personen.Remove(selectedPerson);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = personen;
            }
        }
    }
}
