//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Data_Access.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Project
    {
        public Project()
        {
            this.Users = new HashSet<User>();
        }
    
        public int id { get; set; }
        public string title { get; set; }
        public string state { get; set; }
        public string confirm_status { get; set; }
    
        public virtual ICollection<User> Users { get; set; }
    }
}
