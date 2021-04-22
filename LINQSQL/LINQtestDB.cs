using System;
using System.Data.Entity;
using System.Linq;

namespace LINQSQL
{
    public class LINQtestDB : DbContext
    {
        // Контекст настроен для использования строки подключения "LINQtestDB" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "LINQSQL.LINQtestDB" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "LINQtestDB" 
        // в файле конфигурации приложения.
        public LINQtestDB()
            : base("name=LINQtestDB")
        {
        }

        public DbSet<Worker> workers { get; set; }
        public DbSet<Boss> bosses { get; set; }
        public DbSet<Salary> salary { get; set; }
        public DbSet<Type> types { get; set; }

        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}