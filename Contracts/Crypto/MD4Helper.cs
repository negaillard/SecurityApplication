using Org.BouncyCastle.Crypto.Digests;
using System.Text;

namespace Contracts.Crypto
{
	public static class MD4Helper
	{
		public static string ComputeHashHex(string input)
		{
			var digest = new MD4Digest();
			byte[] inputBytes = Encoding.UTF8.GetBytes(input);
			digest.BlockUpdate(inputBytes, 0, inputBytes.Length);

			byte[] result = new byte[digest.GetDigestSize()];
			digest.DoFinal(result, 0);

			return BitConverter.ToString(result).Replace("-", "").ToLower();
		}
	}
}
