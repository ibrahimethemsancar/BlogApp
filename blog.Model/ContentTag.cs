using System;
namespace blog.Model
{
   public class ContentTag : Core.ModelBase
    {
        public ContentTag(int contentId , int tagId)
        {
            TagId = tagId;
            ContentId = contentId;
        }
        public int TagId { get; set; }
        public int ContentId { get; set; }
    }
}
