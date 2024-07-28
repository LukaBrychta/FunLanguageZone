using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using FunLanguageZone.Server.Models;
using System.Runtime.CompilerServices;

namespace FunLanguageZone.Server.Data
{
    public class VideoService
    {
        private List<Video> _videos = new List<Video>();
        public VideoService()
        {
            _videos = new List<Video>
            {
                new Video {Id = 1, Language = "EN", Title = "You Are My Sunshine", Artist = "The Dead South", YoutubeId = "1MevYCdn5S8", Genres = new List<string> { "Bluegrass", "Folk" } },
                new Video {Id = 2, Language = "EN", Title = "You Got Gold", Artist = "John Prine", YoutubeId = "nFzlp8zhWDU", Genres = new List<string> { "Country", "Folk" } },
                new Video {Id = 3, Language = "EN", Title = "The Saga Begins", Artist = "\"Weird Al\" Yankovic", YoutubeId = "hEcjgJSqSRU", Genres = new List<string> { "Pop", "Rock" } },
                new Video {Id = 4, Language = "EN", Title = "Let It Be", Artist = "The Beatles", YoutubeId = "QDYfEBY9NM4", Genres = new List<string> { "Rock", "Pop" } },
                new Video {Id = 5, Language = "EN", Title = "If We Were Vampires", Artist = "Jason Isbell and the 400 Unit", YoutubeId = "ivYkyC8J29M", Genres = new List<string> { "Folk", "Rock" } },
                new Video {Id = 6, Language = "EN", Title = "Don't Worry Be Happy", Artist = "Bobby McFerrin", YoutubeId = "d-diB65scQU", Genres = new List<string> { "Jazz", "Reggae" } },
                new Video {Id = 7, Language = "EN", Title = "I Want to Hold Your Hand", Artist = "The Beatles", YoutubeId = "v1HDt1tknTc", Genres = new List<string> { "Rock", "Pop" } },
                new Video {Id = 8, Language = "EN", Title = "Hammer High", Artist = "Hammerfall", YoutubeId = "sqYzI8vMG_0", Genres = new List<string> { "Metal" } },
                new Video {Id = 9, Language = "EN", Title = "Gives You Hell", Artist = "The All-American Rejects", YoutubeId = "uxUATkpMQ8A", Genres = new List<string> { "Rock", "Pop" } },
                new Video {Id = 10, Language = "EN", Title = "Welcome To My Life", Artist = "Simple Plan", YoutubeId = "r0U0AlLVqpk", Genres = new List<string> { "Pop", "Punk" } },
                new Video {Id = 11, Language = "EN", Title = "Stand By Me", Artist = "Ben E. King", YoutubeId = "pKtLNYNWbBw", Genres = new List<string> { "R&B" } },
                new Video {Id = 12, Language = "EN", Title = "Here Comes The Sun", Artist = "The Beatles", YoutubeId = "xUNqsfFUwhY", Genres = new List<string> { "Rock", "Pop" } },
                new Video {Id = 13, Language = "EN", Title = "Fear of the Dark", Artist = "Iron Maiden", YoutubeId = "bePCRKGUwAY", Genres = new List<string> { "Metal" } },
                new Video {Id = 14, Language = "EN", Title = "Metal is for Everyone", Artist = "Freedom Call", YoutubeId = "Vy4CQOyQ-0k", Genres = new List<string> { "Metal" } },
                new Video {Id = 15, Language = "EN", Title = "Pirate Metal Drinking Crew", Artist = "Alestorm", YoutubeId = "4z2yNxfBRM4", Genres = new List<string> { "Metal" } },
                new Video {Id = 16, Language = "EN", Title = "P.A.R.T.Y", Artist = "Alestorm", YoutubeId = "c967usVxYq0", Genres = new List<string> { "Metal" } },
                new Video {Id = 17, Language = "EN", Title = "Son of Ambrose", Artist = "The Dead South", YoutubeId = "QCoCiHF2RRw", Genres = new List<string> { "Bluegrass", "Folk" } },
                new Video {Id = 18, Language = "EN", Title = "Perfect", Artist = "Ed Sheeran", YoutubeId = "2Vv-BfVoq4g", Genres = new List<string> { "Pop", "Rock" } },
                new Video {Id = 19, Language = "EN", Title = "Fix You", Artist = "Coldplay", YoutubeId = "k4V3Mo61fJM", Genres = new List<string> { "Pop", "Rock" } },
                new Video {Id = 20, Language = "EN", Title = "Why Don't You Get A Job?", Artist = "The Offspring", YoutubeId = "LH-i8IvYIcg", Genres = new List<string> { "Pop", "Rock" } },
                new Video {Id = 21, Language = "EN", Title = "I'm Just A Kid", Artist = "Simple Plan", YoutubeId = "_GOR5gvQwDI", Genres = new List<string> { "Pop", "Rock" } },
                new Video {Id = 22, Language = "EN", Title = "Zombie", Artist = "The Cranberries", YoutubeId = "6Ejga4kJUts", Genres = new List<string> { "Rock" } },
                new Video {Id = 23, Language = "EN", Title = "All Star", Artist = "Smash Mouth", YoutubeId = "L_jWHffIx5E", Genres = new List<string> { "Rock" } },
                new Video {Id = 24, Language = "DE", Title = "Zeit", Artist = "Rammstein", YoutubeId = "EbHGS_bVkXY", Genres = new List<string> { "Metal" } },
                new Video {Id = 25, Language = "DE", Title = "Ohne dich", Artist = "Rammstein", YoutubeId = "LIPc1cfS-oQ", Genres = new List<string> { "Metal" } },
                new Video {Id = 26, Language = "DE", Title = "Bella schau (mit mir in die Sterne)", Artist = "Versengold", YoutubeId = "gM5K1vS-5AQ", Genres = new List<string> { "Folk", "Rock" } },
                new Video {Id = 27, Language = "DE", Title = "Kobold im Kopp", Artist = "Versengold", YoutubeId = "YP2RJFkgvLc", Genres = new List<string> { "Folk", "Rock" } },
                new Video {Id = 28, Language = "DE", Title = "In jener Nacht", Artist = "dArtagnan", YoutubeId = "e5zB05l5wdg", Genres = new List<string> { "Folk", "Rock" } },
                new Video {Id = 29, Language = "DE", Title = "Die wilde Jagd", Artist = "Versengold", YoutubeId = "oSnuV_QmB-A", Genres = new List<string> { "Folk", "Rock" } },
                new Video {Id = 30, Language = "DE", Title = "Wo sind die Clowns?", Artist = "Saltatio Mortis", YoutubeId = "cVizM1m5urA", Genres = new List<string> { "Metal", "Rock" } },
            };
        }
        public List<Video> GetVideos()
        {
            return _videos;
        }

        public Video GetVideoById(int id)
        {
            return _videos.Find(video => video.Id == id);
        }
    }
}