using BlazorInputFile;

namespace GoFast.UI.Shared.Services.Interfaces
{
    public interface IFileConverter
    {
        Task<string> UploadAsync(IFileListEntry arquivo);
    }
}
