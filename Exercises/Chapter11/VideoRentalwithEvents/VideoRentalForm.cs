using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Exercises.Chapter11.VideoRentalwithEvents.Classes;

namespace Exercises.Chapter11.VideoRentalwithEvents
{
    public partial class VideoRentalForm : Form
    {
        VideoRental rental = new VideoRental();
        public VideoRentalForm()
        {
            rental.AddVideoToList(new Video { FilmId = 1, Title = "alien" });
            rental.AddVideoToList(new Video { FilmId = 1, Title = "alien" });
            rental.AddVideoToList(new Video { FilmId = 2, Title = "aliens2" });
            rental.AddVideoToList(new Video { FilmId = 2, Title = "aliens2" });
            rental.AddVideoToList(new Video { FilmId = 2, Title = "aliens2" });

            InitializeComponent();

            cboVideos.DataSource = rental.GetVideos();
            cboVideos.DisplayMember = "Title";
        }

        private void VideoRental_Load(object sender, EventArgs e)
        {

        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            // Subscribe to events
            rental.AllCopiesRentedOut += Rental_AllCopiesRentedOut;
            rental.VideoInfo += Rental_VideoInfo;

            // try to rent a video
            lblResult.Text = String.Empty;
            var video = (Video)cboVideos.SelectedItem;
            rental.RentVideo(video.FilmId);

            // Unsubscribe to the event
            rental.AllCopiesRentedOut -= Rental_AllCopiesRentedOut;
            rental.VideoInfo -= Rental_VideoInfo;
        }// end btnRent click event.

        private void Rental_VideoInfo(string title, int count)
        {
            lblResult.Text = String.Format(
                "A copy of '{0}' has been rented.\nAvailable Copies: {1}.",
                title, count);
        }

        private void Rental_AllCopiesRentedOut(Video video)
        {
            lblResult.Text = String.Format(
                "All copies of '{0}' are rented out.", video.Title);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            rental.VideoReturned += Rental_VideoReturned;

            // Try to return a vido
            lblResult.Text = String.Empty;
            var video = (Video)cboVideos.SelectedItem;
            rental.ReturnVideo(video.FilmId);
            // unsubscribe from the event.
            rental.VideoReturned -= Rental_VideoReturned;
        }

        private void Rental_VideoReturned(string title, int count)
        {
            lblResult.Text = String.Format(
                "A copy of '{0}'has been returned.\nAvailable Copies: {1}.",
                title, count);
        }
    }
}
