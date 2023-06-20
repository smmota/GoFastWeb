using BlazorInputFile;
using GoFast.UI.Shared.Services.Interfaces;

namespace GoFast.UI.Shared.Services
{
    public class FileConverter : IFileConverter
    {

        public async Task<string> UploadAsync(IFileListEntry arquivoEntrada)
        {
            string pathRoot = new DirectoryInfo(Environment.CurrentDirectory).Parent.Parent.FullName;

            string file;
            var path = Path.Combine(pathRoot, "Uploads",
                    arquivoEntrada.Name);

            var ms = new MemoryStream();

            await arquivoEntrada.Data.CopyToAsync(ms);

            using (FileStream arquivo = new FileStream(path, FileMode.Create,
                FileAccess.Write))
            {
                ms.WriteTo(arquivo);
            }

            Byte[] bytes = File.ReadAllBytes(path);
            file = Convert.ToBase64String(bytes);

            //var fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.None, 4096, FileOptions.DeleteOnClose);

            using (FileStream stream = new FileStream(path, FileMode.Truncate, FileAccess.Write, FileShare.Delete, 4096, true))
            {
                stream.Flush();
                File.Delete(path);
            }

            return file;
        }
    }
}
