namespace AplicativoNotasWeb.Models
{
    public class AnotacaoProjeto : AnotacaoAbstrata
    {
        public int AnotacaoProjetoId { get; set; }
        public string NomeProjeto { get; set; }
        public string LinguagemProjeto { get; set; }
        public string LinkProjeto { get; set; }
    }
}
