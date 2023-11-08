using VideoCollageVlc;

namespace Video.Test
{
    public class Tests
    {
        [Test]
        public async Task BugReproVlc()
        {
            await BugRepro.GenerateCollage(new Uri(@"D:\Test\video\movies\Scarface.mp4"));
        }
    }
}