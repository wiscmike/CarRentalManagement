namespace CarRentalManagement.Client.Static
{
    public static class EndPoints
    {
        private static string _prefix = "api";

        public static string MakesEndPoint = $"{_prefix}/makes";
        public static string ModelsEndPoint = $"{_prefix}/models";
        public static string VehiclesEndPoint = $"{_prefix}/vehicles";
        public static string ColorsEndPoint = $"{_prefix}/colors";
        public static string CustomersEndPoint = $"{_prefix}/customers";
        public static string BookingsEndPoint = $"{_prefix}/bookings";
    }
}
