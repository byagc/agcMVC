//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace agcMVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class analise
    {
        public int id { get; set; }
        public Nullable<int> client_id { get; set; }
        public Nullable<System.DateTime> date_emissao { get; set; }
        public Nullable<System.DateTime> date_retorno { get; set; }
        public Nullable<System.DateTime> date_entrega { get; set; }
        public string prod_id { get; set; }
        public string prod_desc { get; set; }
        public Nullable<bool> pcp_captec { get; set; }
        public string pcp_captec_obs { get; set; }
        public Nullable<bool> pcp_capope { get; set; }
        public string pcp_capope_obs { get; set; }
        public Nullable<bool> pcp_proj { get; set; }
        public string pcp_proj_obs { get; set; }
        public string conclusao { get; set; }
    }
}