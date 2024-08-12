using System.Linq;
using System.Threading.Tasks;
using Google.Apis.YouTube.v3;

namespace SpotyYT.YouTube.source
{
    public class Search
    {
        private static readonly Initialize YtService = new Initialize();
        YouTubeService _youTubeService = YtService.InitializeYoutubeApi();

        private async Task<string> SearchInYouTube(string query)
        {
            var searchRequest = _youTubeService.Search.List("snippet");
            searchRequest.Q = query;
            searchRequest.MaxResults = 1;

            var searchResponse = await searchRequest.ExecuteAsync();

            return (from result in searchResponse.Items
                where result.Id.Kind == "youtube#video"
                select result.Id.VideoId).FirstOrDefault();
        }
    }
}