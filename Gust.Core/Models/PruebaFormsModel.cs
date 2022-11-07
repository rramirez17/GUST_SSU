namespace Gust.Core.Models
{
    public class PruebaFormsModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Cedula { get; set; }

        public PruebaFormsModel()
        {
            FirstName = string.Empty;
            LastName = string.Empty;
            Cedula = string.Empty;
        }
    }
}
