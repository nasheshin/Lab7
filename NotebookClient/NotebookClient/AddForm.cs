using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NotebookClient
{
    public partial class AddForm : Form
    {
        Form1 _mainForm;

        public AddForm(Form1 mainForm)
        {
            InitializeComponent();

            _mainForm = mainForm;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var person = new Person() { Firstname = firstnameBox.Text, Secondname = secondnameBox.Text, BirthDay = birthDateBox.Value};
            _mainForm.Add(person);
            this.Close();
        }
    }
}
