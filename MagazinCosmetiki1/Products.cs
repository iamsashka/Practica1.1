//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MagazinCosmetiki1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Products
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int CategoriiID { get; set; }
        public int CountryID { get; set; }
        public Nullable<decimal> Price { get; set; }
    
        public virtual Categories Categories { get; set; }
        public virtual Country Country { get; set; }
    }
}
