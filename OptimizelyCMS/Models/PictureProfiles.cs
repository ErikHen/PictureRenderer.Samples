using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PictureRenderer.Optimizely;
using PictureRenderer.Profiles;

namespace OptimizelyCMS.Models
{
    public static class PictureProfiles
    {
        public static PictureProfile SampleImage = new()
            {
                SrcSetWidths = new[] { 375, 750, 980, 1500 },
                SrcSetSizes = new[] { "(max-width: 980px) calc((100vw - 40px))", "(max-width: 1200px) 368px", "750px" },
                AspectRatio = 1.777
            };

        public static PictureProfile TopHeroImage = new()
        {
            SrcSetWidths = new[] { 1024, 1366, 1536, 1920 },
            SrcSetSizes = new[] { "100vw" }, //Top hero image is always 100% of the viewport width.
            AspectRatio = 2
        };
    }
}
