namespace Zaabee.Cryptography;

public static partial class HashAlgorithmExtensions
{
    public static string ToHashString(
        this HashAlgorithm hashAlgorithm,
        string str,
        Encoding? encoding = null) =>
        BitConverter
            .ToString(hashAlgorithm.ToHash((encoding ?? HashAlgorithmHelper.DefaultEncoding).GetBytes(str)))
            .Replace("-", string.Empty);
}