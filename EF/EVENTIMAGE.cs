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
    
    public partial class EVENTIMAGE
    {
        public int EVENTIMAGEID { get; set; }
        public Nullable<int> EVENTID { get; set; }
        public string FILEPATH { get; set; }
        public string FILENAME { get; set; }
        public string FULLPATH { get; set; }
    
        public virtual EVENT EVENT { get; set; }
    }
}