//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebMVCdp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Multiplex
    {
        public int Multi_id { get; set; }
        public string Multi_Name { get; set; }
        public string Location { get; set; }
        public string Movie_id { get; set; }
        public int MovieMovie_id { get; set; }
    
        public virtual Movie Movie { get; set; }
    }
}
