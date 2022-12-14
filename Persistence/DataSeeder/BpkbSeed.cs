using Domain;

namespace Persistence.DataSeeder
{
    public class BpkbSeed
    {
        public static async Task SeedData(DataContext context)
        {
            if (context.BPKBs.Any()) return;

            var bpkbs = new List<BPKB>{
                new BPKB{
                    AgreementNumber = "123321123321",
                    BPKBNumber = "123123123123",
                    BranchId = Guid.NewGuid(),
                    BPKBDate = new DateTime(),
                    FakturNumber = "123.345.456.678",
                    LocationId = Guid.Parse("4C3FDE10-EC52-4A53-8D06-04753A455108"),
                    PoliceNo = "B 123 LAH",
                    BPKBDateIn = new DateTime(),
                    FakturDate = new DateTime()
                },
                new BPKB{
                    AgreementNumber = "49295038583920",
                    BPKBNumber = "3947285929048",
                    BranchId = Guid.NewGuid(),
                    BPKBDate = new DateTime(),
                    FakturNumber = "323.445.556.678",
                    LocationId = Guid.Parse("AF82FFDF-4225-4EF6-A1B5-D02819B3FE47"),
                    PoliceNo = "B 123 LDH",
                    BPKBDateIn = new DateTime(),
                    FakturDate = new DateTime()
                },
            };

            await context.BPKBs.AddRangeAsync(bpkbs);
            await context.SaveChangesAsync();
        }
    }
}