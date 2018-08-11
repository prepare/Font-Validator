using System;
namespace OTFontFileVal
{
    public interface IResProvider
    {
        string GetString(string text);
    }
    public static class ResMan
    {
        static IResProvider s_provider;
        public static void SetResProvider(IResProvider provider)
        {
            s_provider = provider;
        }
        public static string GetString(string s)
        {
            return s_provider.GetString(s);
        } 
    }
}
