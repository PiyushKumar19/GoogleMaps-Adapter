using GoogleMaps_Adapter.Models;

namespace GoogleMaps_Adapter.Services
{
    public interface ICoordinateService
    {
        List<CoordinatesModel> GetCoordinates();
    }
}
