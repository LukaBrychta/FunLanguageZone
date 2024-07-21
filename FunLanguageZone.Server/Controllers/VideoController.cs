using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FunLanguageZone.Server.Data;
using FunLanguageZone.Server.Models;

namespace FunLanguageZone.Server.Controllers
{
    [ApiController]
    [Route("api/")]
    public class VideoController : ControllerBase
    {
        private readonly VideoService _videoService;

        public VideoController()
        {
            _videoService = new VideoService();
        }

        [HttpGet("videos")]
        public ActionResult<List<Video>> GetVideos()
        {
            var videos = _videoService.GetVideos();
            if (videos == null || videos.Count == 0)
            {
                return NotFound();
            }
            return Ok(videos);
        }

        [HttpGet("video/{id}")]
        public ActionResult<Video> GetVideoById(int id)
        {
            var searchVideo = _videoService.GetVideoById(id);
            if (searchVideo == null)
            {
                return NotFound();
            }
            return Ok(searchVideo);
        }
    }
}
