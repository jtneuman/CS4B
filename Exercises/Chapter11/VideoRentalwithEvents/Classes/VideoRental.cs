using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Chapter11.VideoRentalwithEvents.Classes
{
    class VideoRental
    {
        public delegate void AllCopiesRentedOutHandler(Video video);
        public event AllCopiesRentedOutHandler AllCopiesRentedOut;

        public delegate void VideoHandler(string title, int count);
        public event VideoHandler VideoReturned;
        public event VideoHandler VideoInfo;

        List<Video> videos = new List<Video>();

        public List<Video> GetVideos()
        {
            return videos.Distinct(new VideoComparer()).ToList();
        }

        public void AddVideoToList(Video video)
        {
            videos.Add(video);
        }

        public void RentVideo(int filmdId)
        {
            var video = videos.FirstOrDefault(v => v.FilmId.Equals(filmdId) && !v.IsRented);
            // Rent out video if available
            if (video != null)
            {
                video.IsRented = true;

                // Check if there still are videos available
                video = videos.FirstOrDefault(v =>
                    v.FilmId.Equals(filmdId) && !v.IsRented);
            }
            // check if event should be triggered
            if (video == null && AllCopiesRentedOut != null)
            {
                video = videos.FirstOrDefault(v =>
                    v.FilmId.Equals(filmdId));
                AllCopiesRentedOut(video);
            }
            else
            {
                var count = videos.Count(v =>
                    v.FilmId.Equals(filmdId) && !v.IsRented);
                VideoInfo(video.Title, count);
            }
        }// End rent video method

        public void ReturnVideo(int filmId)
        {
            var video = videos.FirstOrDefault(v =>
                v.FilmId.Equals(filmId) && v.IsRented);

            // Return video
            if (video != null)
            {
                video.IsRented = false;
                var count = videos.Count(v =>
                    v.FilmId.Equals(filmId) && !v.IsRented);
                VideoReturned(video.Title, count);
            }
        }

    }
}
