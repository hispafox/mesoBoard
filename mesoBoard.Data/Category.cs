//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace mesoBoard.Data
{
    using System;
    using System.Collections.Generic;

    public partial class Category
    {
        public Category()
        {
            this.Forums = new HashSet<Forum>();
        }

        public int CategoryID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int Order { get; set; }

        public virtual ICollection<Forum> Forums { get; set; }
    }
}