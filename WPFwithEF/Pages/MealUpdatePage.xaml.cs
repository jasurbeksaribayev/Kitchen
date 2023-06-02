using System;
using System.Collections.Generic;
using System.Globalization;
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
    /// Interaction logic for MealUpdatePage.xaml
    /// </summary>
    public partial class MealUpdatePage : Page
    {
        private readonly IGenericRepository<Meals> genericRepository;
        private readonly UpdateMealBtnPage updateMealBtnPage;
        public MealUpdatePage()
        {
            this.genericRepository = new GenericRepository<Meals>();
            InitializeComponent();
            this.updateMealBtnPage = new UpdateMealBtnPage();
        }
        private async void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {

            int mealId = int.Parse(MealId.Text);
            
            MessageBoxResult messageBoxResult = MessageBox.Show("Do you want to delete?", "Confirmation", MessageBoxButton.YesNoCancel);

            //var filePath = await genericRepository.GetAsync(mealId);

            //string f = filePath.ImagePath.ToString();
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                

               await genericRepository.DeleteAsync(mealId);
                
                MessageBox.Show("Successfully deleted");

                

                this.NavigationService.Navigate(null);

                //if (File.Exists (f))
                //{
                //    File.Delete(f);
                //}
            }
            
        }

        private void UpdateBtn_Click(object sender, RoutedEventArgs e)
        {
            updateMealBtnPage.Id = int.Parse(MealId.Text);
            updateMealBtnPage.UpdateMealName.Text = MealName.Text;
            updateMealBtnPage.UpdatedMealCost.Text = MealCost.Text;
            updateMealBtnPage.ImageMealUpdate.Source = ImageMealAdd.Source;

            NavigationService.Navigate(updateMealBtnPage);
        }
    }
}
