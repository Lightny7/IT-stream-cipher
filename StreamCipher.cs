using System;
using System.IO;

namespace Lab2
{
    internal static class StreamCipher
    {
        static internal int Cipher(UInt64 key, string inFilename, string outFilename, byte[] genArr, byte[] outArr)
        {
            byte[] input = new byte[4096], output = new byte[4096];
            int count, i = 0;
            bool resolved = false;
            FileStream inF = File.OpenRead(inFilename);
            FileStream outF = File.Create(outFilename);
            try
            {
                count = inF.Read(input, 0, 4096);
                while (count != 0)
                {
                    for (i = 0; i < count; i++)
                    {
                        byte genKey = 0;
                        for (int j = 0; j < 8; j++)
                        {
                            genKey <<= 1;
                            key <<= 1;
                            key += ((key >> 40) & 1) ^ ((key >> 21) & 1) ^ ((key >> 19) & 1) ^ ((key >> 2) & 1);
                            genKey += (byte)((key >> 40) & 1);
                        }
                        output[i] = (byte)(input[i] ^ genKey);
                        if (!resolved)
                        {
                            if (i < 8)
                            {
                                genArr[i] = genKey;
                                outArr[i] = output[i];
                            }
                            else resolved = true;
                        }
                    }
                    outF.Write(output, 0, count);
                    count = inF.Read(input, 0, 4096);
                }
            }
            finally
            {
                inF.Close();
                outF.Close();
            }
            return i > 8 ? 8 : i;
        }
    }
}
