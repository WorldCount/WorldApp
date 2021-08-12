using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WorldStat.Core.Libs.Models;

namespace WorldStat.Core.Libs
{
    public class YaDiskClient
    {
        private string _cloudUrl = "https://cloud-api.yandex.net/";
        private string _resourceUrl = "v1/disk/resources";

        public string ReportDir { get; set; } = "disk:/Почта/Отчеты/";

        private readonly HttpClient _client;

        public YaDiskClient(string token)
        {
            WebRequest.DefaultWebProxy = null;

            _client = new HttpClient();
            _client.DefaultRequestHeaders.Add("Authorization", $"OAuth {token}");

        }

        private async Task<UploadLinkResponse> GetLoadUrl(string path, bool overwrite = true)
        {
            string req = $"{_cloudUrl}{_resourceUrl}/upload?path={path}&overwrite={overwrite}";
            var res = await _client.GetAsync(req).ConfigureAwait(false);

            if (res.IsSuccessStatusCode)
                return JsonConvert.DeserializeObject<UploadLinkResponse>(await res.Content.ReadAsStringAsync().ConfigureAwait(false));

            return null;
        }

        public async Task<string> CreateReportDir(string dateDir, string reportDir = null)
        {
            string req = $"{_cloudUrl}{_resourceUrl}?path={ReportDir}";
            await _client.PutAsync($"{req}{dateDir}", null).ConfigureAwait(false);

            if (reportDir == null)
                return $"{ReportDir}{dateDir}";

            await _client.PutAsync($"{req}{dateDir}/{reportDir}", null).ConfigureAwait(false);
            return $"{ReportDir}{dateDir}/{reportDir}";
        }

        public async void CreateDirs(string path)
        {
            string[] paths = path.Split('/');
            if (paths.Length > 0)
            {
                string rootPath = "";

                foreach (string s in paths)
                {
                    rootPath += $"/{s}";

                    string res = $"{_cloudUrl}{_resourceUrl}?path={rootPath}";
                    await _client.PutAsync(res, null).ConfigureAwait(false);
                }
            }
        }

        public async Task<bool> UploadFile(string source, string path)
        {

            UploadLinkResponse link = await GetLoadUrl(path);

            if (link != null && link.IsData())
            {
                using (var content = new MultipartFormDataContent())
                {
                    using (FileStream fs = File.OpenRead(source))
                    {
                        content.Add(new StreamContent(fs), "file", Path.GetFileName(source));

                        var response = await _client.PostAsync(link.Href, content).ConfigureAwait(false);

                        return response.IsSuccessStatusCode;
                    }
                }
            }

            return false;
        }
    }
}
