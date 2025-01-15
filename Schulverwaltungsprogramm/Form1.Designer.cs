namespace Schulverwaltungsprogramm
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_add_Teacher = new System.Windows.Forms.Button();
            this.btn_add_student = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_delete_person = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_add_Teacher
            // 
            this.btn_add_Teacher.Location = new System.Drawing.Point(660, 24);
            this.btn_add_Teacher.Name = "btn_add_Teacher";
            this.btn_add_Teacher.Size = new System.Drawing.Size(128, 30);
            this.btn_add_Teacher.TabIndex = 1;
            this.btn_add_Teacher.Text = "Lehrer hinzufügen";
            this.btn_add_Teacher.UseVisualStyleBackColor = true;
            this.btn_add_Teacher.Click += new System.EventHandler(this.btn_add_Teacher_Click);
            // 
            // btn_add_student
            // 
            this.btn_add_student.Location = new System.Drawing.Point(660, 71);
            this.btn_add_student.Name = "btn_add_student";
            this.btn_add_student.Size = new System.Drawing.Size(128, 30);
            this.btn_add_student.TabIndex = 2;
            this.btn_add_student.Text = "Schüler hinzufügen";
            this.btn_add_student.UseVisualStyleBackColor = true;
            this.btn_add_student.Click += new System.EventHandler(this.btn_add_student_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(628, 426);
            this.dataGridView1.TabIndex = 1;
            // 
            // btn_delete_person
            // 
            this.btn_delete_person.Location = new System.Drawing.Point(660, 122);
            this.btn_delete_person.Name = "btn_delete_person";
            this.btn_delete_person.Size = new System.Drawing.Size(128, 30);
            this.btn_delete_person.TabIndex = 3;
            this.btn_delete_person.Text = "Person löschen";
            this.btn_delete_person.UseVisualStyleBackColor = true;
            this.btn_delete_person.Click += new System.EventHandler(this.btn_delete_person_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_delete_person);
            this.Controls.Add(this.btn_add_student);
            this.Controls.Add(this.btn_add_Teacher);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Schulverwaltungsprogramm";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_add_Teacher;
        private System.Windows.Forms.Button btn_add_student;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_delete_person;
    }
}

