//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DatabaseManagement
{
    using System;
    using System.Collections.Generic;
    
    public partial class Player
    {
        public Player()
        {
            this.Histories = new HashSet<History>();
        }
    
        public long id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public Nullable<long> age { get; set; }
    
        public virtual ICollection<History> Histories { get; set; }
    }
}
