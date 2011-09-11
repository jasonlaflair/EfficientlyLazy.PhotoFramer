using EfficientlyLazy.PhotoFramer.Entities;

namespace EfficientlyLazy.PhotoFramer.Services
{
    public interface IPhotoService
    {
        Photo AddPhoto(string filename, bool deleteOriginal);
        int AddPhotos(string directory, bool deleteOriginals);
        void Cleanup();
    }
}