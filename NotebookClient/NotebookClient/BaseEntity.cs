using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;

namespace NotebookClient
{
    //[Serializable]
    //[KnownType(typeof(Contact))]
    //[KnownType(typeof(ContactType))]
    //[DataContract(IsReference = true)]
    public class BaseEntity
    {
        public int Id { get; set; }
    }
}
