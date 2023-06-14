using Domain;
using Domain.Exceptions;
using System;
using System.Windows.Forms;

namespace GUI
{
	public static class SceneUtils
	{
		private const string FovNumericErrorMessage = "Fov values must be numeric only";
		private const string LensApertureNumericErrorMessage = "Lens aperture values must be numeric only";
		private const string VectorNumericErrorMessage = "Vector values must be numeric only";

		public static (int, Vector, Vector) GetCameraAtributes(TextBox txtFov, TextBox txtLookAt, TextBox txtLookFrom)
		{
			int fov = GetFov(txtFov);

			var (txtLookFromValues, txtLookAtValues) = GetStringVectorValues(txtLookFrom, txtLookAt);

			double[] vectorLookFromValues = ParseDoubleValues(txtLookFromValues);
			double[] vectorLookAtValues = ParseDoubleValues(txtLookAtValues);

			Vector lookFrom = CreateCameraVector(vectorLookFromValues);
			Vector lookAt = CreateCameraVector(vectorLookAtValues);

			return (fov, lookFrom, lookAt);
		}

		public static double GetLensAperture(TextBox txtLensAperture)
		{
			try
			{
				return double.Parse(txtLensAperture.Text);
			}
			catch (FormatException)
			{
				throw new InvalidSceneInputException(LensApertureNumericErrorMessage);
			}
		}

		public static (string[], string[]) GetStringVectorValues(TextBox txtLookFrom, TextBox txtLookAt)
		{
			try
			{
				string[] txtLookFromValues = StringUtils.DestructureVectorFromat(txtLookFrom.Text);
				string[] txtLookAtValues = StringUtils.DestructureVectorFromat(txtLookAt.Text);

				return (txtLookFromValues, txtLookAtValues);
			}
			catch (InvalidSceneInputException ex)
			{
				throw new InvalidSceneInputException(ex.Message);
			}
		}

		private static int GetFov(TextBox txtFov)
		{
			try
			{
				return int.Parse(txtFov.Text);
			}
			catch (FormatException)
			{
				throw new InvalidSceneInputException(FovNumericErrorMessage);
			}
		}

		private static Vector CreateCameraVector(double[] vectorLookFromValues)
		{
			return new Vector()
			{
				X = vectorLookFromValues[0],
				Y = vectorLookFromValues[1],
				Z = vectorLookFromValues[2]
			};
		}

		private static double[] ParseDoubleValues(string[] values)
		{
			double[] result = new double[values.Length];

			for (int i = 0; i < values.Length; i++)
			{
				try
				{
					result[i] = double.Parse(values[i]);
				}
				catch (FormatException)
				{
					throw new InvalidSceneInputException(VectorNumericErrorMessage);
				}
			}

			return result;
		}

	}
}
