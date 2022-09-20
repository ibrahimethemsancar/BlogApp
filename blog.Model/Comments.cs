using System;
namespace blog.Model
{
   public class Comments : Core.ModelBase
    {
        public int ContentId { get; set; }
        public string FullName { get; set; }
        public string Mail { get; set; }
        public string Text { get; set; }
        public bool IsApprovied { get; set; }
   
    }
}
