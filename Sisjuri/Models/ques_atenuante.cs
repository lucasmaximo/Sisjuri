//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sisjuri.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ques_atenuante
    {
        public int id_quesito_atenuante { get; set; }
        public string quesito_atenuante { get; set; }
        public Nullable<int> qat_sim { get; set; }
        public Nullable<int> qat_nao { get; set; }
        public int fk_id_processo { get; set; }
    
        public virtual processo processo { get; set; }
    }
}