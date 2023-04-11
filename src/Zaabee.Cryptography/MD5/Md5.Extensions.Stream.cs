namespace Zaabee.Cryptography.MD5;

public static partial class Md5Extensions
{
    public static byte[] ToMd5(this Stream inputStream) =>
        Md5Helper.ComputeMd5(inputStream);
}