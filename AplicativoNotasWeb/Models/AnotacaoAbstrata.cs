namespace AplicativoNotasWeb.Models
{
    public abstract class AnotacaoAbstrata
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Tipo { get; set; }

        public string Conteudo { get; set; }
    }
}
