﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class demkapr30Entities : DbContext
    {
        public demkapr30Entities()
            : base("name=demkapr30Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Заказы> Заказы { get; set; }
        public virtual DbSet<Заявки> Заявки { get; set; }
        public virtual DbSet<Категории_продукции> Категории_продукции { get; set; }
        public virtual DbSet<Пользователи> Пользователи { get; set; }
        public virtual DbSet<Поставщик> Поставщик { get; set; }
        public virtual DbSet<Продукция> Продукция { get; set; }
        public virtual DbSet<Пункт_выдачи> Пункт_выдачи { get; set; }
        public virtual DbSet<Роли> Роли { get; set; }
        public virtual DbSet<Состав_заказа> Состав_заказа { get; set; }
        public virtual DbSet<Статус_заказа> Статус_заказа { get; set; }
    }
}
