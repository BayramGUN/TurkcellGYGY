using Movies.Application;
using Movies.Application.DTOs.Requests;
using Movies.Application.DTOs.Responses;
using Movies.Data.Data;
using Movies.Data.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movies.Forms
{
    public partial class FormDirectors : Form
    {
        public FormDirectors()
        {
            InitializeComponent();
        }
        DirectorService directorService = null!;
        private async void FormDirectors_Load(object sender, EventArgs e)
        {

            var context = new MoviesDbContext();
            var repository = new EFDirectorRepository(context);
            directorService = new DirectorService(repository);
            await fillGrid();

        }
        private async Task fillGrid()
        {
            var directors = await directorService.GetDirectorsAsync();
            directorsGridView.DataSource = directors.ToList();
        }
        private void goMovies_Click(object sender, EventArgs e)
        {
            FormMovies moviesForm = new FormMovies();
            moviesForm.Show();
        }

        private async void addDirectorButton_Click(object sender, EventArgs e)
        {
            var request = new CreateDirectorRequest
            {
                Name = directorName.Text,
                Lastname = directorLastname.Text,
                Info = directorInfo.Text,
            };
            var directorId = await directorService.CreateNewDirectorAsync(request);
            var message = directorId != 0 ? "Ok" : "Failed";
            MessageBox.Show(message);
            await fillGrid();
        }
    }
}
