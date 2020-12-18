using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace YoutubeRepoTwo.Models
{
    public class PersonModel
    {
        [PrimaryKey, AutoIncrement]
        public Guid PersonId { get; set; }

        [MaxLength(30)]
        public string NameField { get; set; }

        [MaxLength(2)]
        public int AgeField { get; set; }

    }
}
