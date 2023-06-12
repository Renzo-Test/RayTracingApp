using Domain.Exceptions;
using System;
using System.Linq;

namespace Domain
{

	public class Client
	{
		private const string NotAlphanumericMessage = "Username must only include letters and numbers with no spaces";
		private const string NotContainsNumberMessage = "Password must contain at least one number";
		private const string NotContainsCapitalMessage = "Password must contain at least one capital letter";
		private const string NotInExpectedRangeUsernameMessage = "Username's length must be greater than 2 and smaller than 21";
		private const string NotInExpectedRangePasswordMessage = "Password's length must be greater than 4 and smaller than 26";

		private const int MinFov = 1;
		private const int MaxFov = 160;

		public int Id { get; set; }

		private string _username;
		public string Username
		{
			get => _username;
			set
			{
				try
				{
					RunUsernameConditions(value);
					_username = value;
				}
				catch (InvalidCredentialsException ex)
				{
					throw new InvalidCredentialsException(ex.Message);
				}
			}
		}

		private string _password;
		public string Password
		{
			get => _password;
			set
			{
				try
				{
					RunPasswordConditions(value);
					_password = value;
				}
				catch (InvalidCredentialsException ex)
				{
					throw new InvalidCredentialsException(ex.Message);
				}
			}
		}

		private int _defaultFov = 30;
		public int DefaultFov
		{
			get => _defaultFov;
			set
			{
				if (!InRangeFov(value))
				{
					throw new NotInExpectedRangeClientException($"Scene's fov must be between {MinFov} and {MaxFov}");
				}
				_defaultFov = value;
			}
		}

		public string RegisterDate { get; } = DateTime.Today.ToString("dd/MM/yyyy");
		
		public Vector DefaultLookFrom { get; set; } = new Vector() { X = 0, Y = 2, Z = 0};
		
		public Vector DefaultLookAt { get; set; } = new Vector() { X = 0, Y = 2, Z = 5};

		public RenderProperties DefaultRenderProperties { get; set; } = new RenderProperties();


		private static void RunUsernameConditions(string username)
		{
			LengthInRangeUsername(username);
			IsAlphanumeric(username);
		}

		private static void RunPasswordConditions(string password)
		{
			LengthInRangePassword(password);
			ContainsNumber(password);
			ContainsCapital(password);
		}

		private static void LengthInRangeUsername(string username)
		{
			if (!(username.Length >= 3 && username.Length <= 20))
			{
				throw new NotInExpectedRangeClientException(NotInExpectedRangeUsernameMessage);
			}
		}

		//alphanumeric includes non special characters and no spaces
		private static void IsAlphanumeric(string username)
		{
			if (!username.All(char.IsLetterOrDigit))
			{
				throw new NotAlphanumericClientException(NotAlphanumericMessage);
			}
		}

		private static void ContainsNumber(string password)
		{
			if (!password.Any(char.IsDigit))
			{
				throw new NotContainsNumberException(NotContainsNumberMessage);
			}
		}

		private static void ContainsCapital(string password)
		{
			if (!password.Any(char.IsUpper))
			{
				throw new NotContainsCapitalException(NotContainsCapitalMessage);
			}
		}

		private static void LengthInRangePassword(string password)
		{
			if (!(password.Length >= 5 && password.Length <= 25))
			{
				throw new NotInExpectedRangeClientException(NotInExpectedRangePasswordMessage);
			}
		}
		private static bool InRangeFov(int fov)
		{
			return Enumerable.Range(MinFov, MaxFov).Contains(fov);
		}
	}
}
