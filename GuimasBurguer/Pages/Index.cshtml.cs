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
                Descricao = "Solu��o sob medida para seu neg�cio: aplicativo mobile ou web com design intuitivo e funcionalidades escal�veis.",
                ImagemUri = "/imagens/app-personalizado.jpg",
                DataCadastro = DateTime.Now,
                EntregaRapida = true,
                Preco = 15000.00,
            },
            new Aluguel
            {
                AluguelId = 2,
                Nome = "Otimiza��o de SEO",
                Descricao = "Aumente sua visibilidade no Google com an�lise t�cnica, ajustes de conte�do e estrat�gia de keywords.",
                ImagemUri = "/imagens/seo-optimization.jpg",
                DataCadastro = DateTime.Now,
                EntregaRapida = false,
                Preco = 3200.00,
            },
            new Aluguel
            {
                AluguelId = 3,
                Nome = "Landing Page de Alta Convers�o",
                Descricao = "P�gina focada em resultados: design persuasivo, carregamento ultrarr�pido e integra��o com ferramentas de marketing.",
                ImagemUri = "/imagens/landing-page.jpg",
                DataCadastro = DateTime.Now,
                EntregaRapida = true,
                Preco = 5000.00,
            },
            new Aluguel
            {
                AluguelId = 4,
                Nome = "Manuten��o de Sistemas Legados",
                Descricao = "Atualiza��o e corre��o de sistemas antigos: melhore performance, seguran�a e compatibilidade sem recome�ar do zero.",
                ImagemUri = "/imagens/sistema-legado.jpg",
                DataCadastro = DateTime.Now,
                EntregaRapida = false,
                Preco = 8000.00,
            }
        };
        }
    }
}
