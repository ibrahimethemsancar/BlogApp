﻿using System;
namespace blog.Model
{
   public class ContentCategory : Core.ModelBase
    {
        public ContentCategory(int contentId , int categoryId)
        {
            CategoryId = categoryId;
            ContentId = contentId;
        }
        public int CategoryId { get; set; }
        public int ContentId { get; set; }
    }
}
