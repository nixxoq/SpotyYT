using Google.Apis.Services;
using Google.Apis.YouTube.v3;

namespace SpotyYT.YouTube.source
{
    public class Initialize
    {
        public YouTubeService InitializeYoutubeApi()
        {
            var youTubeService = new YouTubeService(new BaseClientService.Initializer()
            {
                ApiKey = "API_KEY",
                ApplicationName = "SpotyYT"
            });
            return youTubeService;
        }
    }
}