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
    
    public partial class holders
    {
        public holders()
        {
            this.bakery = new HashSet<bakery>();
        }
    
        public int H_ID { get; set; }
        public string H_NAME { get; set; }
        public string H_EMAIL { get; set; }
    
        public virtual ICollection<bakery> bakery { get; set; }
    }
}
