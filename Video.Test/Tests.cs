using VideoCollageVlc;

namespace Video.Test
{
    public class Tests
    {
        [Test]
        public async Task BugReproVlc()
        {
            await BugRepro.GenerateCollage(new Uri(@"http://commondatastorage.googleapis.com/gtv-videos-bucket/sample/ElephantsDream.mp4"));
        }
    }
}