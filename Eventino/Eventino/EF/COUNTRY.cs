//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Eventino.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class COUNTRY
    {
        public COUNTRY()
        {
            this.ACCOUNTs = new HashSet<ACCOUNT>();
        }
    
        public int COUNTRYID { get; set; }
        public string NAME { get; set; }
    
        public virtual ICollection<ACCOUNT> ACCOUNTs { get; set; }
    }
}
