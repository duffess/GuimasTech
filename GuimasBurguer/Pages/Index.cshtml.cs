using GuimasBurguer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GuimasBurguer.Pages
{
    public class IndexModel : PageModel
    {
        public IList<Aluguel> _alugueis;

        public IndexModel()
        {           
        }

        public void OnGet()
        {
            _alugueis = new List<Aluguel>()
        {
            new Aluguel
            {
                AluguelId = 1,
                Nome = "Desenvolvimento de Aplicativo Personalizado",
                Descricao = "Solução sob medida para seu negócio: aplicativo mobile ou web com design intuitivo e funcionalidades escaláveis.",
                ImagemUri = "/imagens/app-personalizado.jpg",
                DataCadastro = DateTime.Now,
                EntregaRapida = true,
                Preco = 15000.00,
            },
            new Aluguel
            {
                AluguelId = 2,
                Nome = "Otimização de SEO",
                Descricao = "Aumente sua visibilidade no Google com análise técnica, ajustes de conteúdo e estratégia de keywords.",
                ImagemUri = "/imagens/seo-optimization.jpg",
                DataCadastro = DateTime.Now,
                EntregaRapida = false,
                Preco = 3200.00,
            },
            new Aluguel
            {
                AluguelId = 3,
                Nome = "Landing Page de Alta Conversão",
                Descricao = "Página focada em resultados: design persuasivo, carregamento ultrarrápido e integração com ferramentas de marketing.",
                ImagemUri = "/imagens/landing-page.jpg",
                DataCadastro = DateTime.Now,
                EntregaRapida = true,
                Preco = 5000.00,
            },
            new Aluguel
            {
                AluguelId = 4,
                Nome = "Manutenção de Sistemas Legados",
                Descricao = "Atualização e correção de sistemas antigos: melhore performance, segurança e compatibilidade sem recomeçar do zero.",
                ImagemUri = "/imagens/sistema-legado.jpg",
                DataCadastro = DateTime.Now,
                EntregaRapida = false,
                Preco = 8000.00,
            }
        };
        }
    }
}
