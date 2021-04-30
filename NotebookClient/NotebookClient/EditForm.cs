using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NotebookClient
{
    public partial class EditForm : Form
    {
        Form1 _mainForm;
        int _id;

        public EditForm(Form1 mainForm, Person person, int id)
        {
            InitializeComponent();

            _mainForm = mainForm;
            _id = id;

            firstnameBox.Text = person.Firstname;
            secondnameBox.Text = person.Secondname;
            birthDateBox.Value = person.BirthDay;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            var person = new Person() { Firstname = firstnameBox.Text, Secondname = secondnameBox.Text, BirthDay = birthDateBox.Value };
            _mainForm.Edit(person, _id);
            this.Close();
        }
    }
}
