using FmDemoWeb.Services;
using Microsoft.AspNetCore.Mvc;

namespace FmDemoWeb.Controllers
{
    public class FileManagerController : Controller
    {
        private readonly IFileManager _fileManager;
        private readonly string[] _allowedExtensions = new[]
        {
            ".jpg", ".jpeg", ".png", ".gif", ".bmp", ".webp",  // Images
            ".mp4", ".avi", ".mov", ".wmv", ".flv", ".mkv",     // Videos
            ".pdf",                                              // PDF
            ".doc", ".docx", ".xls", ".xlsx", ".ppt", ".pptx",  // Office
            ".txt", ".csv"                                       // Text
        };

        public FileManagerController(IFileManager fileManager)
        {
            _fileManager = fileManager;
        }

        [HttpPost]
        public async Task<IActionResult> Upload(List<IFormFile> files, string folder)
        {
            try
            {
                if (files == null || !files.Any())
                    return Json(new { success = false, message = "Dosya seçilmedi" });

                var uploadedFiles = new List<object>();

                foreach (var file in files)
                {
                    var extension = System.IO.Path.GetExtension(file.FileName).ToLowerInvariant();

                    if (!_allowedExtensions.Contains(extension))
                    {
                        uploadedFiles.Add(new
                        {
                            fileName = file.FileName,
                            success = false,
                            message = "Desteklenmeyen dosya türü"
                        });
                        continue;
                    }

                    var relativePath = await _fileManager.UploadFileAsync(file, folder ?? "");
                    uploadedFiles.Add(new
                    {
                        fileName = file.FileName,
                        success = true,
                        path = relativePath
                    });
                }

                return Json(new { success = true, files = uploadedFiles });
            }
            catch (System.Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }
        }

        [HttpPost]
        public async Task<IActionResult> Delete(string filePath)
        {
            try
            {
                await _fileManager.DeleteFileAsync(filePath);
                return Json(new { success = true });
            }
            catch (System.Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }
        }

        [HttpPost]
        public async Task<IActionResult> Crop(string filePath, int x, int y, int width, int height)
        {
            try
            {
                var newPath = await _fileManager.CropImageAsync(filePath, x, y, width, height);
                return Json(new { success = true, path = newPath });
            }
            catch (System.Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }
        }

        [HttpPost]
        public async Task<IActionResult> Resize(string filePath, int width, int height)
        {
            try
            {
                var newPath = await _fileManager.ResizeImageAsync(filePath, width, height);
                return Json(new { success = true, path = newPath });
            }
            catch (System.Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateFolder(string folderName, string parentFolder)
        {
            try
            {
                // Alt klasör oluşturma artık izinli
                var folderPath = string.IsNullOrEmpty(parentFolder)
                    ? folderName
                    : System.IO.Path.Combine(parentFolder, folderName);

                await _fileManager.CreateFolderAsync(folderPath);
                return Json(new { success = true });
            }
            catch (System.Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }
        }

        [HttpPost]
        public async Task<IActionResult> DeleteFolder(string folderPath)
        {
            try
            {
                await _fileManager.DeleteFolderAsync(folderPath);
                return Json(new { success = true });
            }
            catch (System.Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }
        }

        [HttpGet]
        public IActionResult GetFolders(string path)
        {
            try
            {
                var folders = _fileManager.GetFolders(path ?? "");
                return Json(new { success = true, folders });
            }
            catch (System.Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }
        }

        [HttpGet]
        public IActionResult GetFiles(string folder)
        {
            try
            {
                var files = _fileManager.GetFiles(folder ?? "");
                return Json(new { success = true, files });
            }
            catch (System.Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }
        }
    }
}
