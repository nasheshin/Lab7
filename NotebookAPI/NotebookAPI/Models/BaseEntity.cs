﻿using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;

namespace NotebookAPI.Models
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
