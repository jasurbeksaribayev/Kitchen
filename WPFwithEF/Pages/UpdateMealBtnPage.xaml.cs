using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPFwithEFApp.Data.GenericRepositories;
using WPFwithEFApp.Data.IGenericRepositories;
using WPFwithEFApp.Domain.Entities;
using static System.Net.Mime.MediaTypeNames;

namespace WPFwithEF.Pages
{
    /// <summary>
    /// Interaction logic for UpdateMealBtnPage.xaml
    /// </summary>
    public partial class UpdateMealBtnPage : Page
    {
        public int Id { get; set; }
        private readonly IGenericRepository<Meals> genericRepository;
        Meals meal;

        public UpdateMealBtnPage()
        {
            InitializeComponent();
            this.genericRepository = new GenericRepository<Meals>();
            meal = new Meals();
        }

        private async void mealUpdatedBtn_Click(object sender, RoutedEventArgs e)
        {
            meal = await genericRepository.GetAsync(Id);

            // string filePath = meal.ImagePath;

            meal.Cost = UpdatedMealCost.Text;
            meal.Name = UpdateMealName.Text;
            meal.UpdatedTime = DateTime.UtcNow;

            await genericRepository.UpdateAsync(meal);

            MessageBox.Show("Successfully updated");

            

            this.NavigationService.Navigate(null);

        }

        private async void UpdateMealImgBtn_Click(object sender, RoutedEventArgs e)
        {
            meal = await genericRepository.GetAsync(Id);

            var fileName = string.Empty;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
                fileName = openFileDialog.FileName;

            string path = $"../../../Data/images/MealImages/{Guid.NewGuid():N}.png";

            string pathh = meal.ImagePath;

            File.WriteAllBytes(path, File.ReadAllBytes(fileName));

            meal.ImagePath = new FileInfo(path).FullName;

            //FileInfo sourceFile = new FileInfo(fileName);
            //FileInfo destinationFile = new FileInfo(meal.ImagePath);

            //byte[] imageBytes = File.ReadAllBytes(sourceFile.FullName);

            //File.WriteAllBytes(destinationFile.FullName, imageBytes);

            ImageMealUpdate.Source = new BitmapImage(new Uri(fileName, UriKind.Absolute));

        }
    }
}
