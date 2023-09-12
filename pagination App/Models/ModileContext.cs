using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace pagination_App.Models
{
    public class MobileContext : DbContext
    {
        public DbSet<Phone> Phones { get; set; }
    }

    public class MobileDbInitializer : DropCreateDatabaseAlways<MobileContext> {

        protected override void Seed(MobileContext db) {
            db.Phones.Add(new Phone { Model = "TestModel1", Producer = "TestProducer1"});
            db.Phones.Add(new Phone { Model = "TestModel2", Producer = "TestProducer2"});
            db.Phones.Add(new Phone { Model = "TestModel3", Producer = "TestProducer3"});
            db.Phones.Add(new Phone { Model = "TestModel4", Producer = "TestProducer4"});
            db.Phones.Add(new Phone { Model = "TestModel5", Producer = "TestProducer5"});
            db.Phones.Add(new Phone { Model = "TestModel6", Producer = "TestProducer6"});
            db.Phones.Add(new Phone { Model = "TestModel7", Producer = "TestProducer7"});
            db.Phones.Add(new Phone { Model = "TestModel8", Producer = "TestProducer8"});
            db.Phones.Add(new Phone { Model = "TestModel9", Producer = "TestProducer9"});
            db.SaveChanges();
        }
    
    }
}