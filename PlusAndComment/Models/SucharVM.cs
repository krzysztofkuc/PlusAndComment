using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlusAndComment.Models
{
	public class SucharVM
	{
        public int Id { get; set; }
        public string Content { get; set; }
        public string AbsThumbPath { get; set; }
        public string RelThumbPath { get; set; }
        public DateTime AddedTime { get; set; }
    }
}