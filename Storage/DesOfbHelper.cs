using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Storage
{
	public static class DesOfbHelper
	{
		public static void EncryptOFB(byte[] key, byte[] iv, string inputFile, string outputFile)
		{
			byte[] input = File.ReadAllBytes(inputFile);
			byte[] output = ProcessOFB(key, iv, input);
			File.WriteAllBytes(outputFile, output);
		}

		public static void DecryptOFB(byte[] key, byte[] iv, string inputFile, string outputFile)
		{
			// для OFB шифрование и расшифровка одинаковы
			EncryptOFB(key, iv, inputFile, outputFile);
		}

		private static byte[] ProcessOFB(byte[] key, byte[] iv, byte[] input)
		{
			using var des = DES.Create();
			des.Mode = CipherMode.ECB; // используем ECB для генерации потока
			des.Padding = PaddingMode.None;

			using var encryptor = des.CreateEncryptor(key, null);

			byte[] feedback = (byte[])iv.Clone();
			byte[] output = new byte[input.Length];

			for (int i = 0; i < input.Length; i++)
			{
				if (i % 8 == 0)
				{
					// каждый 8 байт обновляем feedback
					encryptor.TransformBlock(feedback, 0, 8, feedback, 0);
				}
				output[i] = (byte)(input[i] ^ feedback[i % 8]);
			}

			return output;
		}
	}
}
