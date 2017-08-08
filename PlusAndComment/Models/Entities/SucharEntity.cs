using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlusAndComment.Models.Entities
{
    [Table("Suchary")]
    public class SucharEntity
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public string AbsThumbPath { get; set; }
        public string RelThumbPath { get; set; }
        public DateTime AddedTime { get; set; }
    }
}