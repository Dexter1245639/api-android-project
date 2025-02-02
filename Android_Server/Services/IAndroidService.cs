﻿using Android_Server.Models;

namespace Android_Server.Services
{
    public interface IAndroidService
    {
        Task UploadPhoto(string photo);
        string GenerateDocument();
        List<FileDetail> GetFiles();
        Task<PdfFileModel> SendPDF(string fileName);
        Task<string> GetPhotoDescription(string bytes);
        Task<string> GetMultiplePhotosDescription(string[] bytes);
    }
}
