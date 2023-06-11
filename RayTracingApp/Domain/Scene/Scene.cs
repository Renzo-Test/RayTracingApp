using Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Test")]

namespace Domain
{
    public class Scene
    {
        private const string EmptyNameMessage = "Scene's name must not be empty";
        private const string SpaceCharacterConstant = " ";
        private const string StartOrEndWithSpaceMessage = "Scene's name must not start or end with blank space";

        private const int MinFov = 1;
        private const int MaxFov = 160;

        private const double MinLensAperture = 0.1;
        private const double MaxLensAperture = 1.0;

        public int Id { get; set; }
        public Vector LookFrom { get; set; } = new Vector();
        public Vector LookAt { get; set; } = new Vector();
        public List<PosisionatedModel> PosisionatedModels { get; set; }
        public byte[] Preview { get; set; }

        private string _registerTime = DateTime.Now.ToString("HH.mm.ss - dd-MM-yyyy");
        private string _owner;
        private string _name;
        private string _lastModificationDate = "unmodified";
        private string _lastRenderDate = "unrendered";
        private int _fov;
        private double _lensAperture = 0.5;

        public Scene()
        {
            PosisionatedModels = new List<PosisionatedModel>();
        }

        public Scene(string owner, int fov, Vector lookFrom, Vector lookAt)
        {
            SetSceneParameters(owner);
            SetRenderingParameters(fov, lookFrom, lookAt);
        }

        private void SetRenderingParameters(int fov, Vector lookFrom, Vector lookAt)
        {
            _fov = fov;
			LookFrom = lookFrom;
			LookAt = lookAt;
            PosisionatedModels = new List<PosisionatedModel>();
        }

        private void SetSceneParameters(string owner)
        {
            _name = $"{_registerTime}";
            _owner = owner;
        }

        public string Owner
        {
            get => _owner;
            set => _owner = value;
        }

        public string Name
        {
            get => _name;
            set
            {
                try
                {
                    RunNameIsEmptyChecker(value);
                    RunNameIsSpacedChecker(value);
                    _name = value;
                }
                catch (InvalidSceneInputException ex)
                {
                    throw new InvalidSceneInputException(ex.Message);
                }
            }
        }

        public string RegisterTime
        {
            get => _registerTime;
            set => _registerTime = DateTime.Now.ToString("hh:mm:ss - dd/MM/yyyy");
        }

        public string LastModificationDate
        {
            get => _lastModificationDate;
            set => _lastModificationDate = value;
        }

        public string LastRenderDate
        {
            get => _lastRenderDate;
            set => _lastRenderDate = value;
        }

        public int Fov
        {
            get => _fov;
            set
            {
                try
                {
                    RunFovIsValidChecker(value);
                    _fov = value;
                }
                catch (InvalidSceneInputException ex)
                {
                    throw new InvalidSceneInputException(ex.Message);
                }
            }
        }

        public double LensAperture
        {
            get => _lensAperture;
            set
            {
				try
                {
					RunLensApertureIsValidChecker(value);
					_lensAperture = value;
				}
				catch (InvalidSceneInputException ex)
                {
					throw new InvalidSceneInputException(ex.Message);
				}
			}
        }

		public Image GetPreview()
        {
            using (var stream = new MemoryStream(Preview))
            {
                return Image.FromStream(stream);
            }
        }

        public void SetPreview(Image img)
        {
            Preview = ImageToByteArray(img);
        }

        public byte[] ImageToByteArray(Image img)
        {
            using (var stream = new MemoryStream())
            {
                img.Save(stream, ImageFormat.Bmp);
                return stream.ToArray();
            }
        }

        private static void RunNameIsEmptyChecker(string value)
        {
            if (value.Equals(string.Empty))
            {
                throw new EmptyNameSceneException(EmptyNameMessage);
            }
        }

        private static void RunNameIsSpacedChecker(string value)
        {
            if (value.StartsWith(SpaceCharacterConstant) || value.EndsWith(SpaceCharacterConstant))
            {
                throw new InvalidSpacePositionException(StartOrEndWithSpaceMessage);
            }
        }

        private static void RunFovIsValidChecker(int value)
        {
            if (!Enumerable.Range(MinFov, MaxFov).Contains(value))
            {
                throw new InvalidFovException($"Scene's fov must be between {MinFov} and {MaxFov}");
            }
        }

		private void RunLensApertureIsValidChecker(double value)
		{
			if (MinLensAperture > value || value > MaxLensAperture)
			{
				throw new InvalidFovException($"Lens aperture must be between {MinLensAperture} and {MaxLensAperture}");
			}

            double roundedValue = Math.Round(value, 1);
            if (roundedValue != value)
            {
				throw new InvalidFovException($"Lens aperture must have only one decimal");
			}
		}
	}
}
