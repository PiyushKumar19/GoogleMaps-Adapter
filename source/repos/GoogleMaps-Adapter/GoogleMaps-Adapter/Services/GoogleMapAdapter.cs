using GoogleMaps_Adapter.Models;

namespace GoogleMaps_Adapter.Services
{
    public class GoogleMapAdapter : IGoogleMapAdapter
    {
        private readonly IGoogleMapService mapService;

        public GoogleMapAdapter(IGoogleMapService mapService)
        {
            this.mapService = mapService;
        }

        public void ProcessCoordinates(List<CoordinatesModel> coordinates)
        {
            var coordinatesString = System.Text.Json.JsonSerializer.Serialize(coordinates);
            mapService.GenerateCoordinateToken(coordinatesString);
        }
    }
}
