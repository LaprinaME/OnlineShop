using System;
using OnlineShop.Models;
using Microsoft.EntityFrameworkCore;

namespace OnlineShop.DataContext
{
    public class OnlineShopContext : DbContext
    {
        // DbSet для каждой таблицы в базе данных
        public DbSet<Детали_заказа> Детали_заказа { get; set; }
        public DbSet<Заказы> Заказы { get; set; }
        public DbSet<Клиенты> Клиенты { get; set; }
        public DbSet<Обслуживание> Обслуживание { get; set; }
        public DbSet<Пользователи> Пользователи { get; set; }
        public DbSet<Поставщики> Поставщики { get; set; }
        public DbSet<Продавцы> Продавцы { get; set; }
        public DbSet<Пункты_выдачи> Пункты_выдачи { get; set; }
        public DbSet<Роли> Роли { get; set; }
        public DbSet<Склад_продавца> Склад_продавца { get; set; }
        public DbSet<Сотрудники> Сотрудники { get; set; }
        public DbSet<Товары> Товары { get; set; }

        // Переопределение метода для указания строки подключения к базе данных
        public OnlineShopContext(DbContextOptions<OnlineShopContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        // Переопределение метода OnModelCreating для конфигурации модели данных
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Пользователи>()
                .HasOne(p => p.Роли)
                .WithMany()
                .HasForeignKey(p => p.Код_Роли); // Используйте имя столбца, которое соответствует столбцу в таблице "Пользователи" для роли

            base.OnModelCreating(modelBuilder);
        }
    }
}
