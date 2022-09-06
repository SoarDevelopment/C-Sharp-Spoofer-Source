using System;
using System.Security.Cryptography;
using System.Text;

namespace Null_Obfuscator.Outline
{
	public class SecureRandoms
	{
		public static string GenerateRandomString(int size)
		{
			byte[] array = new byte[4 * size];
			using (RNGCryptoServiceProvider rngcryptoServiceProvider = new RNGCryptoServiceProvider())
			{
				rngcryptoServiceProvider.GetBytes(array);
			}
			StringBuilder stringBuilder = new StringBuilder(size);
			for (int i = 0; i < size; i++)
			{
				long num = (long)((ulong)BitConverter.ToUInt32(array, i * 4) % (ulong)((long)SecureRandoms.chars.Length));
				stringBuilder.Append(SecureRandoms.chars[(int)(checked((IntPtr)num))]);
			}
			return stringBuilder.ToString();
		}
		private static readonly RNGCryptoServiceProvider csp = new RNGCryptoServiceProvider();
		internal static readonly char[] chars = "艾屁弗吉伊艾勒伊弗吉艾勒吾伊吉弗勒吉弗尺艾杰迪弗吉勒艾伊艾吉屁弗哦屁弗吉开-娜诶迪艾-吾迪艾艾娜艾-吾娜迪-伊艾艾艾尺艾艾-艾迪艾尺艾屁吾伊屁迪娜马迪迪迪迪迪迪迪迪迪迪迪迪诶迪迪迪迪-吾迪伊艾艾娜伊艾吾艾艾-伊艾吾马娜-=艾艾勒伊艾吾-=艾艾勒杰伊艾吾-=[艾尺艾杰勒艾艾 -艾西迪马娜艾艾诶吾-=[',艾迪西艾艾吉儿艾诶娜艾艾马吾=-['/;吉弗,开艾尺迪诶娜艾艾马吾[-;'/=西迪艾吉弗娜艾诶马,娜艾迪艾吾艾西吉-=[;'/".ToCharArray();





		public static string GenerateRandomAddress(int size)
		{
			byte[] array = new byte[4 * size];
			using (RNGCryptoServiceProvider rngcryptoServiceProvider = new RNGCryptoServiceProvider())
			{
				rngcryptoServiceProvider.GetBytes(array);
			}
			StringBuilder stringBuilder = new StringBuilder(size);
			for (int i = 0; i < size; i++)
			{
				long num = (long)((ulong)BitConverter.ToUInt32(array, i * 4) % (ulong)((long)SecureRandoms.chars2.Length));
				stringBuilder.Append(SecureRandoms.chars2[(int)(checked((IntPtr)num))]);
			}
			return "0x" + stringBuilder.ToString();
		}
		private static readonly RNGCryptoServiceProvider csp2 = new RNGCryptoServiceProvider();
		internal static readonly char[] chars2 = "ABCDEF1234567890".ToCharArray();
	}
}
