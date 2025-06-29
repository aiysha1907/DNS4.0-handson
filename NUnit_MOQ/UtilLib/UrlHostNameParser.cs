namespace UtilLib
{
    public class UrlHostNameParser
    {
        public string ParseHostName(string url)
        {
            if (url.StartsWith("http://"))
            {
                return url.Substring(7).Split('/')[0];
            }
            else if (url.StartsWith("https://"))
            {
                return url.Substring(8).Split('/')[0];
            }
            else
            {
                return "Invalid URL";
            }
        }
    }
}
