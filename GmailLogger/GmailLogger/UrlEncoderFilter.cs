using MimeKit;
using MimeKit.IO;
using MimeKit.IO.Filters;
using System;

class UrlEncodeFilter : IMimeFilter
{
    byte[] output = new byte[8192];

    #region IMimeFilter implementation
    public byte[] Filter(byte[] input, int startIndex, int length, out int outputIndex, out int outputLength)
    {
        if (output.Length < input.Length)
            Array.Resize(ref output, input.Length);

        int endIndex = startIndex + length;

        outputLength = 0;
        outputIndex = 0;

        for (int index = startIndex; index < endIndex; index++)
        {
            switch ((char)input[index])
            {
                case '\r': case '\n': case '=': break;
                case '+': output[outputLength++] = (byte)'-'; break;
                case '/': output[outputLength++] = (byte)'_'; break;
                default: output[outputLength++] = input[index]; break;
            }
        }

        return output;
    }

    public byte[] Flush(byte[] input, int startIndex, int length, out int outputIndex, out int outputLength)
    {
        return Filter(input, startIndex, length, out outputIndex, out outputLength);
    }

    public void Reset()
    {

    }
    #endregion
}