namespace SOLID.PATTERN.LSP.Solucao
{
    public class Quadrado : Forma
    {
        public override double Altura
        {
            get
            {
                return base.Altura;
            }
            set
            {
                base.Altura = value;
                base.Largura = value;
            }
        }
        public override double Largura
        {
            get
            {
                return base.Largura;
            }
            set
            {
                base.Largura = value;
                base.Altura = value;
            }
        }
    }
}