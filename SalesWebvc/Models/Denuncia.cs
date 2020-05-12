namespace SalesWebvc.Models
{
    public class Denuncia
    {
        public int Id { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Municipio { get; set; }
        public string Estado { get; set; }
        public string Zona { get; set; }
        public string Tipo { get; set; }
        public double Aream3 { get; set; }
        public string Responsavel { get; set; }
    }
}
