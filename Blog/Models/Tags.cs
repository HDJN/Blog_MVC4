//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Blog.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tags
    {
        public Tags()
        {
            this.ArticleTagMapping = new HashSet<ArticleTagMapping>();
        }
    
        public int TID { get; set; }
        public string TName { get; set; }
        public int UID { get; set; }
    
        public virtual ICollection<ArticleTagMapping> ArticleTagMapping { get; set; }
        public virtual Users Users { get; set; }
    }
}