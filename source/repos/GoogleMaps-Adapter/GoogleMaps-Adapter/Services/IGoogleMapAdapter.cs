using GoogleMaps_Adapter.Models;

namespace GoogleMaps_Adapter.Services
{
    // Adapter Service
    public interface IGoogleMapAdapter
    {
        void ProcessCoordinates(List<CoordinatesModel> coordinates);
    }
}
