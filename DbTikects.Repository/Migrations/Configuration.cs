using DbTikets.Domain;

namespace DbTikects.Repository.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DbTikects.Repository.DbTikectsContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DbTikects.Repository.DbTikectsContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Productos.AddOrUpdate(
                p=>p.Codigo,
                new Producto() { 
                    Codigo = "GT001", 
                    Descripcion = "Producto 001", 
                    Categoria = new Categoria() { Descripcion = "Categoria 1"},
                    Precio = 24,
                    Descontinuado = false},
                 new Producto()
                 {
                     Codigo = "GT002",
                     Descripcion = "Producto 002",
                     Categoria = new Categoria() { Descripcion = "Categoria 2" },
                     Precio = 24,
                     Descontinuado = false
                 },
                  new Producto()
                  {
                      Codigo = "GT003",
                      Descripcion = "Producto 003",
                      Categoria = new Categoria() { Descripcion = "Categoria 3" },
                      Precio = 24,
                      Descontinuado = false
                  }
                );
        }
    }
}
