using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace NotebookClient
{
    public class Person : BaseEntity
    {
        public Person()
        {
            Contacts = new List<Contact>();
        }

        public string Firstname { get; set; }
        public string Secondname { get; set; }
        public DateTime BirthDay { get; set; }

        [JsonIgnore]
        public ICollection<Contact> Contacts { get; set; }
    }
}