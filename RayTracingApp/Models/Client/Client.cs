using Models.ClientExceptions;
using System;
using System.Linq;

namespace Models
{

	public class Client
	{
		private const string NotAlphanumericMessage = "Username must only include letters and numbers with no spaces";
		private const string NotContainsNumberMessage = "Password must contain at least one number";
		private const string NotContainsCapitalMessage = "Password must contain at least one capital letter";
		private const string NotInExpectedRangeUsernameMessage = "Username's length must be greater than 2 and smaller than 21";
		private const string NotInExpectedRangePasswordMessage = "Password's length must be greater than 4 and smaller than 26";
		private string _username;
		private string _password;
		public String Username
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
		public String Password
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
		public String RegisterDate { get; } = DateTime.Today.ToString("dd/MM/yyyy");

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
				throw new NotInExpectedRangeException(NotInExpectedRangeUsernameMessage);
			}
		}

		//alphanumeric includes non special characters and no spaces
		private static void IsAlphanumeric(string username)
		{
			if (!username.All(char.IsLetterOrDigit))
			{
				throw new NotAlphanumericException(NotAlphanumericMessage);
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
				throw new NotInExpectedRangeException(NotInExpectedRangePasswordMessage);
			}
		}
	}
}
