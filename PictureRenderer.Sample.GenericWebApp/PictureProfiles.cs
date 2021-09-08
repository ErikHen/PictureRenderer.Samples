using PictureRenderer.Profiles;

namespace GenericWebApp
{
    public static class PictureProfiles
    {
        public static ImageSharpProfile SampleImage =
            new()
            {
                SrcSetWidths = new[] { 375, 750, 980, 1500 },
                SrcSetSizes = new[] { "(max-width: 980px) calc((100vw - 40px))", "(max-width: 1200px) 368px", "750px" },
                AspectRatio = 1.777
            };
    }
}
