namespace CSharpFeatures
{
    public struct GeoCoordinate
    {
        private int _latitude;
        public int Latitude
        {
            get => _latitude;
            set => _latitude = value >= 0 ? value : throw new ArgumentOutOfRangeException();
        }

        public GeoCoordinate(int latitude)
        {
            /* The compiler will automatically insert below line
             * ensuring that all fields are definitely assigned before returning or use */

            // _latitude = default;
        }
    }
}