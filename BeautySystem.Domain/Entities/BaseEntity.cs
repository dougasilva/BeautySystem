
namespace BeautySystem.Domain.Entities
{
    public class BaseEntity
    {
        public int id { get; set; }
        public bool ativo { get; set; }
        public string nome { get; set; }
        public string? observacoes { get; set; }
        public DateTime dtCadastro { get; set; }
        public int idUsuarioCadastro { get; set; }
        public DateTime? dtAlteracao { get; set; }
        public int? idUsuarioAlteracao { get; set; }
        public DateTime? dtExclusao { get; set; }
        public int? idUsuarioExclusao { get; set; }
    }
}
