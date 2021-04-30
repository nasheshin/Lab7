using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotebookClient
{
    public partial class Form1 : Form
    {
        const string _baseAddress = "https://localhost:44358/";

        public Form1()
        {
            InitializeComponent();
        }


        private void updateButton_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count != 0)
            {
                int id = (int)listView.SelectedItems[0].Tag;

                Remove(id);
                Update();
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var addForm = new AddForm(this);
            addForm.Show();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count != 0)
            {
                int id = (int)listView.SelectedItems[0].Tag;
                var person = new Person() { 
                    Firstname = listView.SelectedItems[0].SubItems[0].Text,
                    Secondname = listView.SelectedItems[0].SubItems[1].Text,
                    BirthDay = DateTime.Parse(listView.SelectedItems[0].SubItems[2].Text)
                };

                var editForm = new EditForm(this, person, id);
                editForm.Show();
            }
        }

        public void Edit(Person person, int id)
        {
            Remove(id);
            Add(person);
            Update();
        }

        private new void Update()
        {
            listView.Items.Clear();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseAddress);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response;

                response = client.GetAsync("api/People").Result;
                if (response.IsSuccessStatusCode)
                {
                    Person[] reports = response.Content.ReadAsAsync<Person[]>().Result;
                    foreach (var p in reports)
                    {
                        var item = new ListViewItem(new[] { p.Firstname, p.Secondname, p.BirthDay.ToShortDateString() });
                        item.Tag = p.Id;
                        listView.Items.Add(item);
                    }
                }
            }
        }

        private void Remove(int delete)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseAddress);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = client.DeleteAsync("api/People/" + delete).Result;
            }
        }

        public void Add(Person person)
        { 
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseAddress);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = client.PostAsJsonAsync("api/People", person).Result;

            }

            Update();
        }
    }
}
