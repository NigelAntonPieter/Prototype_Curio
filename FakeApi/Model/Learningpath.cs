namespace FakeApi.Model
{
    public class Learningpath
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Navigeerbare Eigenschap voor de bedrijven die bij deze leerweg horen
        public ICollection<Company> Companies { get; set; }
    }
}
