using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace NotebookClient
{
    public class Contact : BaseEntity
    {
        public string Value { get; set; }

        public int? PersonId { get; set; }
        [JsonIgnore]
        public Person Person { get; set; }

        public int? ContactTypeId { get; set; }
        [JsonIgnore]
        public ContactType ContactType { get; set; }
    }
}
