using LibVLCSharp;

namespace VideoCollageVlc
{
    public static class BugRepro
    {
        public static async Task GenerateCollage(Uri filePath)
        {
            var libVLC = new LibVLC(enableDebugLogs: true);
            using var media = new Media(filePath);

            int thumbnails = 8; // Works if set to 1.
            var step = 1.0 / thumbnails;

            for (int i = 0; i < thumbnails; i++)
            {
                using (var thumbnail = await media.GenerateThumbnailAsync(libVLC, step * i, ThumbnailerSeekSpeed.Fast, 200, 0, false, PictureType.Png))
                {
                    thumbnail.Save($"frame{i}.png");
                }
            }
        }
    }
}