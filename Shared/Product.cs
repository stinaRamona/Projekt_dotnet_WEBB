namespace Projekt_dotnet_WEBB.Shared; 

    public class Product 
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Description { get; set; }

        public int Price { get; set; }

        public string? ImageName { get; set; }

        public int CategoryModelId { get; set; }
    }