using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Chapter11.VideoRentalwithEvents.Classes
{
    class VideoComparer : IEqualityComparer<Video>
    {
        public bool Equals(Video video1, Video video2)
        {
            return video1.FilmId.Equals(video2.FilmId);
        }

        public int GetHashCode(Video video)
        {
            return video.FilmId;
        }
    }
}
