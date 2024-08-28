using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Microsoft.Extensions.Options;
using Rezor_MoviePage.Core;
using Rezor_MoviePage.Services.Interfaces;

namespace Rezor_MoviePage.Services;

public class PhotoService : IPhotoService
{
    private readonly Cloudinary cloudinary;
    public PhotoService(IOptions<CloudinarySettings> options)
    {
        var account = new Account(
            options.Value.CloudName,
            options.Value.ApiKey,
            options.Value.ApiSecret
            );
        cloudinary = new Cloudinary(account);
    }
    public async Task<ImageUploadResult> AddPhotoAsync(IFormFile file)
    {
        var uploadRezult = new ImageUploadResult();
        if (file.Length > 0)
        {
            using var stream = file.OpenReadStream();
            var imageParam = new ImageUploadParams
            {
                File = new FileDescription(file.FileName, stream),
                Transformation = new Transformation().Height(500)
            };

            uploadRezult = await cloudinary.UploadAsync(imageParam);
        }
        return uploadRezult;
    }

    public async Task<DeletionResult> DeletePhotoAsync(string publicUrl)
    {
        var publicId = publicUrl.Split("/").Last().Split(".").First();
        var deletionParams = new DeletionParams(publicId);
        return await cloudinary.DestroyAsync(deletionParams);
    }
}
