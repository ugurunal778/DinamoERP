//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Interrupt
    {
        public int Id { get; set; }
        public int workNo { get; set; }
        public System.DateTime Start { get; set; }
        public System.DateTime Stop { get; set; }
        public string Stats { get; set; }
        public string Reason { get; set; }
    }
}