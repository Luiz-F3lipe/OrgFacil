using System;

namespace Organics.API.Domain.Entities
{
    public class Provider
    {
        public int Id { get; set; }
        public string PersonImage { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Adress { get; set; }
    }
}
