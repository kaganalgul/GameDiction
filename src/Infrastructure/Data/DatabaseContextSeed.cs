using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class DatabaseContextSeed
    {
        public static async Task SeedAsync(DatabaseContext db)
        {
            Category[] categories = {
                new Category() { Name = "Aksiyon" },
                new Category() { Name = "Strateji" },
                new Category() { Name = "MMORGP" },
                new Category() { Name = "Spor" },
                new Category() { Name = "RYO" },
                new Category() { Name = "Yarış" },
                new Category() { Name = "Erken Erişim" },
                new Category() { Name = "Kart" }
            };
            db.Categories.AddRange(categories);
            await db.SaveChangesAsync();
        }
    }
}
