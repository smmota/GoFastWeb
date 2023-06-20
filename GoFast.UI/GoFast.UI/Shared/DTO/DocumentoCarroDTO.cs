using GoFast.UI.Shared.DTO.Enums;
using System.ComponentModel.DataAnnotations;

namespace GoFast.UI.Shared.DTO
{
    public class DocumentoCarroDTO : DocumentoDTO
    {
        public DocumentoCarroDTO(DateTime renovacao) : base(TipoDocumentoEnum.Renavam, "", DateTime.Now)
        {
            Renovacao = renovacao;
        }

        [Required]
        public DateTime Renovacao { get; set; }
    }
}
