using System.Threading.Tasks;
using Google.Apis.YouTube.v3;
using Google.Apis.YouTube.v3.Data;

namespace SpotyYT.YouTube.source
{
    public class PlayListYouTube
    {
        private readonly YouTubeService _youTubeService;
        private Playlist _playList;

        public PlayListYouTube()
        {
            var ytServiceInitializer = new Initialize();
            _youTubeService = ytServiceInitializer.InitializeYoutubeApi();
        }

        public async Task<string> CreatePlaylist(string name, string description = null)
        {
            var newPlaylist = new Playlist
            {
                Snippet = new PlaylistSnippet
                {
                    Title = name,
                    Description = !string.IsNullOrEmpty(description)
                        ? description
                        : "Playlist converted from Spotify using SpotyYT"
                },
                Status = new PlaylistStatus
                {
                    PrivacyStatus = "public"
                }
            };

            _playList = await _youTubeService.Playlists.Insert(newPlaylist, "snippet,status").ExecuteAsync();

            return $"https://www.youtube.com/playlist?list={_playList.Id}";
        }


        public Playlist GetPlayList()
        {
            return _playList;
        }
    }
}