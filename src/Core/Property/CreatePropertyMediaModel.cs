namespace Core.Property
{
    public class CreatePropertyMediaModel
    {
       // public string Path { get; set; }
        public int MediaTypeId { get; set; }
       // public byte[] Image { get; set; }
       
       /// <summary>
       ///    image in base64
       /// </summary>
        public string Image { get; set; }
        public string Description { get; set; }
        public int PropertyId { get; set; }
    }
}
