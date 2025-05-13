namespace GuimasBurguer.Models
{
    public class Aluguel
    {
        public int AluguelId { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public string ImagemUri { get; set; }

        public DateTime DataCadastro { get; set; }

        public bool EntregaRapida { get; set; }

        public double Preco { get; set; }
    }
}
