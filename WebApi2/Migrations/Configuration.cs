namespace WebApi2.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebApi2.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApi2.Models.WebApi2Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebApi2.Models.WebApi2Context context)
        {
            context.Contacts.AddOrUpdate(p => p.Name,

          new Contacts

          {
              ContactId = 1,
              Name = "Jessica Diaz",
              Address = "Ctra. Valencia km 7",
              City = "Madrid",
              State = "Spain",
              Zip = "28555",
              Email = "jdiaz@etsisi.upm.es",
          },

          new Contacts

          {
              ContactId = 2,
              Name = "Jennifer Perez",
              Address = "Ctra. Valencia km 7",
              City = "Madrid",
              State = "Spain",
              Zip = "28555",
              Email = "jperez@etsisi.upm.es",
          },

          new Contacts

          {
              ContactId = 1,
              Name = "Agustin Yague",
              Address = "Ctra. Valencia km 7",
              City = "Madrid",
              State = "Spain",
              Zip = "28555",
              Email = "ayague@etsisi.upm.es",
          }
);
        }
    }
}
