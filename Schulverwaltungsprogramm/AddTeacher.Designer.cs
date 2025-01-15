namespace Schulverwaltungsprogramm
{
    partial class AddTeacher
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
            this.tB_Firstname = new System.Windows.Forms.TextBox();
            this.label_Firstname = new System.Windows.Forms.Label();
            this.label_Lastname = new System.Windows.Forms.Label();
            this.tB_Lastname = new System.Windows.Forms.TextBox();
            this.label_Birthdate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox_Gender = new System.Windows.Forms.ComboBox();
            this.label_Gender = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tB_Firstname
            // 
            this.tB_Firstname.Location = new System.Drawing.Point(12, 28);
            this.tB_Firstname.Name = "tB_Firstname";
            this.tB_Firstname.Size = new System.Drawing.Size(200, 20);
            this.tB_Firstname.TabIndex = 0;
            // 
            // label_Firstname
            // 
            this.label_Firstname.AutoSize = true;
            this.label_Firstname.Location = new System.Drawing.Point(13, 13);
            this.label_Firstname.Name = "label_Firstname";
            this.label_Firstname.Size = new System.Drawing.Size(49, 13);
            this.label_Firstname.TabIndex = 1;
            this.label_Firstname.Text = "Vorname";
            // 
            // label_Lastname
            // 
            this.label_Lastname.AutoSize = true;
            this.label_Lastname.Location = new System.Drawing.Point(13, 59);
            this.label_Lastname.Name = "label_Lastname";
            this.label_Lastname.Size = new System.Drawing.Size(59, 13);
            this.label_Lastname.TabIndex = 3;
            this.label_Lastname.Text = "Nachname";
            // 
            // tB_Lastname
            // 
            this.tB_Lastname.Location = new System.Drawing.Point(12, 74);
            this.tB_Lastname.Name = "tB_Lastname";
            this.tB_Lastname.Size = new System.Drawing.Size(200, 20);
            this.tB_Lastname.TabIndex = 2;
            // 
            // label_Birthdate
            // 
            this.label_Birthdate.AutoSize = true;
            this.label_Birthdate.Location = new System.Drawing.Point(13, 105);
            this.label_Birthdate.Name = "label_Birthdate";
            this.label_Birthdate.Size = new System.Drawing.Size(73, 13);
            this.label_Birthdate.TabIndex = 5;
            this.label_Birthdate.Text = "Geburtsdatum";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 121);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // comboBox_Gender
            // 
            this.comboBox_Gender.FormattingEnabled = true;
            this.comboBox_Gender.Location = new System.Drawing.Point(12, 173);
            this.comboBox_Gender.Name = "comboBox_Gender";
            this.comboBox_Gender.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Gender.TabIndex = 7;
            // 
            // label_Gender
            // 
            this.label_Gender.AutoSize = true;
            this.label_Gender.Location = new System.Drawing.Point(13, 157);
            this.label_Gender.Name = "label_Gender";
            this.label_Gender.Size = new System.Drawing.Size(61, 13);
            this.label_Gender.TabIndex = 8;
            this.label_Gender.Text = "Geschlecht";
            // 
            // btn_save
            // 
            this.btn_save.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_save.Location = new System.Drawing.Point(137, 219);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 11;
            this.btn_save.Text = "Speichern";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(11, 219);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 12;
            this.btn_cancel.Text = "Abbrechen";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // AddTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 255);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label_Gender);
            this.Controls.Add(this.comboBox_Gender);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label_Birthdate);
            this.Controls.Add(this.label_Lastname);
            this.Controls.Add(this.tB_Lastname);
            this.Controls.Add(this.label_Firstname);
            this.Controls.Add(this.tB_Firstname);
            this.Name = "AddTeacher";
            this.Text = "Lehrer hinzufügen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tB_Firstname;
        private System.Windows.Forms.Label label_Firstname;
        private System.Windows.Forms.Label label_Lastname;
        private System.Windows.Forms.TextBox tB_Lastname;
        private System.Windows.Forms.Label label_Birthdate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox_Gender;
        private System.Windows.Forms.Label label_Gender;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
    }
}