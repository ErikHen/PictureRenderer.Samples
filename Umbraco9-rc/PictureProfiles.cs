using PictureRenderer.Profiles;

namespace Umbraco9_rc
{
    public static class PictureProfiles
    {
        public static ImageSharpProfile SampleImage =
            new()
            {
                SrcSetWidths = new[] { 320, 640, 750, 1500 },
                SrcSetSizes = new[] { "(max-width: 640px) 100vw", "(max-width: 1200px) 320px", "750px" },
                DefaultWidth = 640
            };
    }
}
