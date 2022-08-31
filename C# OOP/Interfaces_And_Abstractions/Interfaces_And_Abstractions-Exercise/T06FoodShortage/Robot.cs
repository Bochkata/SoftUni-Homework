namespace T06FoodShortage
{
    public class Robot : IIdentifiable
    {
        public Robot(string id, string model)
        {
            Model = model;
            Id = id;
        }
        public string Id { get; set; }
        public string Model { get; set; }
    }
}