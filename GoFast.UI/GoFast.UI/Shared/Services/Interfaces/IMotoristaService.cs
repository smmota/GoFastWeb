using GoFast.UI.Shared.DTO;
using GoFast.UI.Shared.DTO.ViewModels;

namespace GoFast.UI.Shared.Services.Interfaces
{
    public interface IMotoristaService
    {
        Task<List<MotoristaViewModel>> GetAll();

        Task<MotoristaViewModel> GetById(string id);

        Task<String> Create(MotoristaDTO motoristaDTO);

        Task DeleteById(Guid id);

        Task Update(MotoristaViewModel motoristaDTO);
    }
}
