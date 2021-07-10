using Newtonsoft.Json;
using System;
using System.Drawing;
using ViewerLib;

namespace MappingMap
{
    class MappingMapKerenl : ViewerKernel
    {
        class Config
        {
            public string ImagePath;
            public float Scale;
            public Point RelativeLocation;
        }

        private Point _relativeLocation;
        private string _imagePath;

        public string ImagePath
        {
            get => _imagePath;
            set
            {
                _imagePath = value;
                if (_imagePath != null)
                    Image = Image.FromFile(_imagePath);
            }
        }

        public Point RelativeLocation
        {
            get => _relativeLocation;
            set => _relativeLocation = value;
        }

        public float Scale
        {
            get => ZoomFactor;
            set => ZoomFactor = value;
        }

        public new Image Image
        {
            get => base.Image;
            set => base.Image = value;
        }

        public MappingMapKerenl(Size size) : base(size)
        {
        }

        public Point SetAnchor(Point location)
        {
            _relativeLocation = ToRealLocation(location);
            return _relativeLocation;
        }

        public Image MoveToAnchor(Point location)
        {
            SrcRect.X = _relativeLocation.X - DstRect.Width * 100 / ZoomFactor * location.X / DstRect.Width;
            SrcRect.Y = _relativeLocation.Y - DstRect.Height * 100 / ZoomFactor * location.Y / DstRect.Height;
            return GetImage();
        }

        protected override Image GetImage()
        {
            if (SrcImage == null)
                return null;

            // Update srcRect
            SrcRect.Width = DstRect.Width * 100 / ZoomFactor;
            SrcRect.Height = DstRect.Height * 100 / ZoomFactor;

            // Update dstImage
            if (DstImage == null || PreSrcRect != SrcRect || PreDstRect != DstRect)
            {
                if (DstImage != null)
                    DstImage.Dispose();
                DstImage = Paint.DrawImage(SrcImage, SrcRect, DstRect);
                PreSrcRect = SrcRect;
                PreDstRect = DstRect;
            }

            return DstImage.Clone(new Rectangle(0, 0, DstImage.Width, DstImage.Height), DstImage.PixelFormat);
        }

        public static string ToJson(MappingMapKerenl kernel)
        {
            Config config = new Config();
            config.ImagePath = kernel.ImagePath;
            config.RelativeLocation = kernel.RelativeLocation;
            config.Scale = kernel.Scale;
            return JsonConvert.SerializeObject(config, Formatting.Indented);
        }

        public static MappingMapKerenl FromJson(string json)
        {
            Config config = JsonConvert.DeserializeObject<Config>(json);
            MappingMapKerenl kernel = new MappingMapKerenl(new Size(100, 100));
            kernel.ImagePath = config.ImagePath;
            kernel.Scale = config.Scale;
            kernel.RelativeLocation = config.RelativeLocation;
            return kernel;
        }
    }
}
