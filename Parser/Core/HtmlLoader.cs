using System.Threading.Tasks;
using System.Net;
using System.Net.Http;

namespace Parser.Core
{
    class HtmlLoader
    {
        readonly HttpClient client;
        readonly string url;

        public HtmlLoader(IParserSettings settings)
        {
            client = new HttpClient();
            client.DefaultRequestHeaders.Add("User-Agent", "C# App"); //Это для индентификации на сайте-жертве.
            url = $"{settings.BaseUrl}/{settings.Postfix}/"; //Здесь собирается адресная строка
        }

        public async Task<string> GetSourceByPage(int id) /// id странички
        {
            string currentUrl = url.Replace("{CurrentId}", id.ToString()); // подмена урла
            HttpResponseMessage response = await client.GetAsync(currentUrl);
            string sourse = default;
             if (response!=null && response.StatusCode == HttpStatusCode.OK)
            {
                sourse = await response.Content.ReadAsStringAsync();
            }
            return sourse;
        }


    }
}
