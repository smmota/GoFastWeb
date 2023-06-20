﻿using GoFast.UI.Shared.DTO.Enums;
using System.ComponentModel.DataAnnotations;

namespace GoFast.UI.Shared.DTO
{
    public class DocumentoDTO
    {
        public TipoDocumentoEnum TipoDocumento { get; set; }

        [Required]
        [MaxLength(30)]
        public string Numero { get; set; }

        [Required]
        public DateTime Expedicao { get; set; }

        public DocumentoDTO(TipoDocumentoEnum tipoDocumento, string numero, DateTime expedicao)
        {
            TipoDocumento = tipoDocumento;
            Numero = numero;
            Expedicao = expedicao;
        }
    }
}
