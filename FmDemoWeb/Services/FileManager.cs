using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;

namespace FmDemoWeb.Services
{
    public class FileManager : IFileManager
    {
        private readonly string _baseUploadPath;

        public FileManager(string baseUploadPath)
        {
            _baseUploadPath = baseUploadPath;

            if (!Directory.Exists(_baseUploadPath))
                Directory.CreateDirectory(_baseUploadPath);
        }

        public async Task<string> UploadFileAsync(IFormFile file, string folderPath)
        {
            if (file == null || file.Length == 0)
                throw new ArgumentException("Geçersiz dosya");

            var fullFolderPath = Path.Combine(_baseUploadPath, folderPath);

            if (!Directory.Exists(fullFolderPath))
                Directory.CreateDirectory(fullFolderPath);

            var fileName = $"{Guid.NewGuid()}_{file.FileName}";
            var filePath = Path.Combine(fullFolderPath, fileName);

            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            return Path.Combine(folderPath, fileName);
        }

        public Task DeleteFileAsync(string filePath)
        {
            var fullPath = Path.Combine(_baseUploadPath, filePath);

            if (File.Exists(fullPath))
                File.Delete(fullPath);

            return Task.CompletedTask;
        }

        public async Task<string> CropImageAsync(string filePath, int x, int y, int width, int height)
        {
            var fullPath = Path.Combine(_baseUploadPath, filePath);

            if (!File.Exists(fullPath))
                throw new FileNotFoundException("Dosya bulunamadı");

            using (var image = await Image.LoadAsync(fullPath))
            {
                image.Mutate(ctx => ctx.Crop(new Rectangle(x, y, width, height)));

                var croppedFileName = $"cropped_{Path.GetFileName(filePath)}";
                var croppedPath = Path.Combine(Path.GetDirectoryName(fullPath), croppedFileName);

                await image.SaveAsync(croppedPath);

                return Path.Combine(Path.GetDirectoryName(filePath), croppedFileName);
            }
        }

        public async Task<string> ResizeImageAsync(string filePath, int width, int height)
        {
            var fullPath = Path.Combine(_baseUploadPath, filePath);

            if (!File.Exists(fullPath))
                throw new FileNotFoundException("Dosya bulunamadı");

            using (var image = await Image.LoadAsync(fullPath))
            {
                image.Mutate(ctx => ctx.Resize(width, height));

                var resizedFileName = $"resized_{width}x{height}_{Path.GetFileName(filePath)}";
                var resizedPath = Path.Combine(Path.GetDirectoryName(fullPath), resizedFileName);

                await image.SaveAsync(resizedPath);

                return Path.Combine(Path.GetDirectoryName(filePath), resizedFileName);
            }
        }

        public Task CreateFolderAsync(string folderPath)
        {
            var fullPath = Path.Combine(_baseUploadPath, folderPath);

            if (!Directory.Exists(fullPath))
                Directory.CreateDirectory(fullPath);

            return Task.CompletedTask;
        }

        public Task DeleteFolderAsync(string folderPath)
        {
            var fullPath = Path.Combine(_baseUploadPath, folderPath);

            if (Directory.Exists(fullPath))
                Directory.Delete(fullPath, true);

            return Task.CompletedTask;
        }

        public string[] GetFolders(string basePath)
        {
            var fullPath = Path.Combine(_baseUploadPath, basePath ?? "");

            if (!Directory.Exists(fullPath))
                return Array.Empty<string>();

            return Directory.GetDirectories(fullPath)
                .Select(d => Path.GetFileName(d))
                .ToArray();
        }

        public string[] GetFiles(string folderPath)
        {
            var fullPath = Path.Combine(_baseUploadPath, folderPath ?? "");

            if (!Directory.Exists(fullPath))
                return Array.Empty<string>();

            return Directory.GetFiles(fullPath)
                .Select(f => Path.GetFileName(f))
                .ToArray();
        }
    }
}
