//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace demopr30
{
    using System;
    using System.Collections.Generic;
    
    public partial class Состав_заказа
    {
        public long id_состав { get; set; }
        public long id_продукции { get; set; }
        public long id_заказа { get; set; }
        public int Количество { get; set; }
    
        public virtual Заказы Заказы { get; set; }
        public virtual Продукция Продукция { get; set; }
    }
}
