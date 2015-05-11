using SOLID.PATTERN._4___ISP.ISP.Solucao;
namespace SOLID.PATTERN.ISP.Solucao
{
    public interface ICadastroCliente : ICadastro
    {
        void EnviarEmail();
    }
}