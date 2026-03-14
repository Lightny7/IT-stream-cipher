using System;
using System.Text;
using System.Windows.Forms;

namespace Lab2
{
    internal static class Utils
    {
        internal static UInt64 ToUInt64(string s)
        {
            UInt64 res = 0;
            int i = 0, j = 0;
            while (i < 40 && j < s.Length)
            {
                if (s[j] == '0' || s[j] == '1')
                {
                    res <<= 1;
                    res += (byte)(s[j] - '0');
                    i++;
                }
                j++;
            }
            if (i < 40) return UInt64.MaxValue;
            return res;
        }

        internal static string ToByteString(byte[] bytes, int count)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                if (i == bytes.Length) return sb.ToString();
                byte b = bytes[i];
                for (int j = 0; j < 8; j++)
                {
                    sb.Append(((b & 0b1000_0000) == 0) ? '0' : '1');
                    b <<= 1;
                }
            }
            return sb.ToString();
        }
        internal static string ToByteString(UInt64 bytes)
        {
            StringBuilder sb = new StringBuilder();
            for (int j = 0; j < 64; j++)    
            {
                    sb.Append(((bytes & 0x8000_0000_0000_0000) == 0) ? '0' : '1');
                    bytes <<= 1;
            }
            return sb.ToString();
        }
    }
}
