using PictureRenderer;
using PictureRenderer.Profiles;
using System;
using System.Collections.Generic;
using System.Text;
using Umbraco.Cms.Core.PropertyEditors.ValueConverters;
using Microsoft.AspNetCore.Html;

namespace PictureRenderer.Umbraco
{
    public static class UmbracoPicture
    {
        public static HtmlString Render(ImageCropperValue imageCropper, PictureProfileBase profile, LazyLoading lazyLoading)
        {
            
            return Render(imageCropper, profile, string.Empty, lazyLoading);
        }

        public static HtmlString Render(ImageCropperValue imageCropper, PictureProfileBase profile, string altText = "", LazyLoading lazyLoading = LazyLoading.Browser)
        {
            (double x, double y) focalPoint = default;
            if (imageCropper.HasFocalPoint())
            {
                focalPoint.x = decimal.ToDouble(imageCropper.FocalPoint.Left);
                focalPoint.y = decimal.ToDouble(imageCropper.FocalPoint.Top);
            }
            return new HtmlString(Picture.Render(imageCropper.ToString(), profile, altText, lazyLoading, focalPoint));
        }

    }
}
