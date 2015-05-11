namespace SOLID.PATTERN.ISP.Solucao
{
    public interface ICadastroCliente
    {
        void ValidarDados();
        void SalvarBanco();
        void EnviarEmail();
    }
}