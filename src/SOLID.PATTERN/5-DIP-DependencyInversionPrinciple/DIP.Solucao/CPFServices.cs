using SOLID.PATTERN.DIP.Solucao.Interfaces;

namespace SOLID.PATTERN.DIP.Solucao
{
    public class CPFServices : ICPFServices
    {
        public bool IsValid(string cpf)
        {
            return cpf.Length == 11;
        }
    }
}