using System;
namespace Win32APIs
{
    public class MultiByte
    {
        public static uint GetCodePageMaxCharSize(uint CodePage)
        {
            throw new NotImplementedException("UnImplemented CodePage:" + CodePage + " MaxChar");
        }

        public static bool IsCodePageInstalled(uint CodePage)
        {
            //Lie about having every CodePage?
            throw new NotImplementedException("UnImplemented CodePage:" + CodePage);
        }

        public static bool IsCodePageLeadByte(uint CodePage, byte c)
        {
            throw new NotImplementedException("UnImplemented Win32API.MultiByte/IsCodePageLeadByte: "
                                              + CodePage + ", byte " + c);
        }
        public static int MultiByteCharToUnicodeChar(uint CodePage, ushort c)
        {
            throw new NotImplementedException("UnImplemented Win32API.MultiByte/MultiByteCharToUnicodeChar: "
                                              + CodePage + ", char " + c);
        }
    }
}