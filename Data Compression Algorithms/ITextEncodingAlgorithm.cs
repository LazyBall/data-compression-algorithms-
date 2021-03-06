﻿
namespace DataCompressionAlgorithms
{
    public interface ITextEncodingAlgorithm
    {
        string Encode(string sourceText, out double compressionRatio);
        string Decode(string codedText);
    }
}