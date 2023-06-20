using GoFast.UI.Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoFast.UI.Shared.Services.Interfaces
{
    public interface IBlobService
    {
        Task<BlobDTO> GetById(string id);

        Task<String> Create(string base64);

        Task DeleteById(Guid id);
    }
}
