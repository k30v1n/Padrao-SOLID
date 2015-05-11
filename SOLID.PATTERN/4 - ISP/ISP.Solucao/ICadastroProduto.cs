using SOLID.PATTERN._4___ISP.ISP.Solucao;
namespace SOLID.PATTERN.ISP.Solucao
{
    public interface ICadastroProduto : ICadastro
    {
        // Criando uma interface para o produto mesmo que ele não tenha função é
        // Recomendavel para que este cadastro tenha uma maior posisbilidade de extensão de 
        // funcionalidades
    }
}