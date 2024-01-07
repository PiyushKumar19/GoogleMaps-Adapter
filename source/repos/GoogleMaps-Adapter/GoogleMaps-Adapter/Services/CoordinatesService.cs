using GoogleMaps_Adapter.Models;

namespace GoogleMaps_Adapter.Services
{
    public class CoordinatesService : ICoordinateService
    {
        public List<CoordinatesModel> GetCoordinates()
        {
            return new List<CoordinatesModel>
            {
                new CoordinatesModel { Id = 1, LocationName = "India Gate", Lati = 28.61400454931849, Longi = 77.22968136137236},
                new CoordinatesModel { Id = 1, LocationName = "Gauri Shankar Mandir", Lati = 28.65825545790221, Longi = 77.235516885868}
            };
        }
    }
}
