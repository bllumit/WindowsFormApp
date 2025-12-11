namespace FmDemoWeb.Services
{
    public interface IFileManager
    {
        Task<string> UploadFileAsync(IFormFile file, string folderPath);
        Task DeleteFileAsync(string filePath);
        Task<string> CropImageAsync(string filePath, int x, int y, int width, int height);
        Task<string> ResizeImageAsync(string filePath, int width, int height);
        Task CreateFolderAsync(string folderPath);
        Task DeleteFolderAsync(string folderPath);
        string[] GetFolders(string basePath);
        string[] GetFiles(string folderPath);
    }
}
