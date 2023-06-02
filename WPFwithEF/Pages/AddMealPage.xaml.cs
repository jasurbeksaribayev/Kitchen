using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPFwithEFApp.Data.GenericRepositories;
using WPFwithEFApp.Data.IGenericRepositories;
using WPFwithEFApp.Domain.Entities;

namespace WPFwithEF.Pages
{
    /// <summary>
    /// Interaction logic for AddMealPage.xaml
    /// </summary>
    public partial class AddMealPage : Page
    {
        private readonly IGenericRepository<Meals> genericRepository;
        Meals meals;
        public AddMealPage()
        {
            meals = new Meals();
            this.genericRepository = new GenericRepository<Meals>();
            InitializeComponent();
        }
        private async void mealAddBtn_Click(object sender, RoutedEventArgs e)
        {
            meals.Name = MealName.Text;
            meals.Cost = MealCost.Text;

            await genericRepository.AddAsync(meals);

            MessageBox.Show("Successfully added");

            this.NavigationService.Navigate(null);

        }

        private void ChooseMealImgBtn_Click(object sender, RoutedEventArgs e)
        {
            var fileName = string.Empty;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
                fileName = openFileDialog.FileName;

            string path = $"../../../Data/images/MealImages/{Guid.NewGuid():N}.png";

            File.WriteAllBytes(path, File.ReadAllBytes(fileName));

            meals.ImagePath = new FileInfo(path).FullName;
           
            ImageMealAdd.Source = new BitmapImage(new Uri(meals.ImagePath,UriKind.Absolute));
        }

        
    }
}
