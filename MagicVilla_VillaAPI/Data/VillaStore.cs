using MagicVilla_VillaAPI.Model.Dto;
namespace MagicVilla_VillaAPI.Data
{
    public static class VillaStore
    {
        public static List<VillaDTO> villaList =  new List<VillaDTO> {
                new VillaDTO{ Id = 1 ,Name= "Pool View", Sqft = 300, Occupancy = 4 },
                new VillaDTO{ Id = 2 ,Name= "Beach View", Sqft = 100, Occupancy = 3 },
                new VillaDTO{ Id = 3, Name = "Country Inn", Sqft = 200, Occupancy = 2},
                new VillaDTO{ Id = 4, Name = "Tech Mahindra", Sqft = 450, Occupancy = 9},
                new VillaDTO{ Id= 5, Name= "Radisson", Sqft = 170, Occupancy = 4}
            };
    }
}
