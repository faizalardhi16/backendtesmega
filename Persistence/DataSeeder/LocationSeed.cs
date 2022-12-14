using Domain;

namespace Persistence.DataSeeder
{
    public class LocationSeed
    {
        public static async Task SeedData(DataContext context)
        {
            if (context.Locations.Any()) return;

            var locations = new List<Location>{
                new Location{
                   LocationId = Guid.Parse("4C3FDE10-EC52-4A53-8D06-04753A455108"),
                   LocationName = "Jakarta"
                },
                new Location{
                    LocationId = Guid.Parse("AF82FFDF-4225-4EF6-A1B5-D02819B3FE47"),
                    LocationName = "Surakarta"
                },
                new Location{
                    LocationId = Guid.Parse("CD881AE2-AAFD-4254-BB64-9B120C8FE15B"),
                    LocationName = "Semarang"
                }
            };

            await context.Locations.AddRangeAsync(locations);
            await context.SaveChangesAsync();
        }
    }
}