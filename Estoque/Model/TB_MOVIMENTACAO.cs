//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Estoque.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class TB_MOVIMENTACAO
    {
        public int HANDLE { get; set; }
        public Nullable<System.DateTime> DATA { get; set; }
        public Nullable<int> CLIENTE { get; set; }
        public Nullable<int> TIPOMOVIMENTACAO { get; set; }
        public Nullable<int> CODIGO { get; set; }
        public Nullable<int> ORDEM { get; set; }
        public Nullable<decimal> QUANTIDADE { get; set; }
        public Nullable<decimal> VALORUNITARIO { get; set; }
        public Nullable<decimal> VALORTOTAL { get; set; }
        public Nullable<decimal> PESOLIQUIDO { get; set; }
        public Nullable<decimal> PESOBRUTO { get; set; }
        public Nullable<int> ITEM { get; set; }
        public Nullable<int> UNIDADEMEDIDA { get; set; }
        public string TIPOMOVIMENTACAONOME { get; set; }
        public string CLIENTENOME { get; set; }
        public string ITEMNOME { get; set; }
        public string UNIDADESIGLA { get; set; }

        public virtual TB_ITEM TB_ITEM { get; set; }
        public virtual TB_PESSOA TB_PESSOA { get; set; }
        public virtual TB_ORDEM TB_ORDEM { get; set; }
    }
}
