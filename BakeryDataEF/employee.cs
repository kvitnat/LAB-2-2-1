//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BakeryDataEF
{
    using System;
    using System.Collections.Generic;
    
    public partial class employee
    {
        public int EM_ID { get; set; }
        public string EM_NAME { get; set; }
        public string EM_SURNAME { get; set; }
        public Nullable<int> EM_BK { get; set; }
        public Nullable<int> EM_P { get; set; }
    
        public virtual bakery bakery { get; set; }
        public virtual positions positions { get; set; }
    }
}
