using System;
using System.Collections.Generic;
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
using WPFwithEF.Controllers;
using WPFwithEF.Pages;
using WPFwithEFApp.Data.GenericRepositories;
using WPFwithEFApp.Data.IGenericRepositories;
using WPFwithEFApp.Domain.Entities;

namespace WPFwithEF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IGenericRepository<Meals> genericRepositoryOfMeal;
        private readonly AddMealPage addMealPage;
        private readonly MealUpdatePage mealUpdatePage;
        public MainWindow()
        {
            InitializeComponent();
            genericRepositoryOfMeal = new GenericRepository<Meals>();
            addMealPage = new AddMealPage();
            mealUpdatePage = new MealUpdatePage();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //ControllerOfMeals.Items.Refresh();

            var meals = genericRepositoryOfMeal.
                                       GetAll().
                                       Where(e => e.Name.Contains(SearchTxtBox.Text)
                                       || e.Cost.Contains(SearchTxtBox.Text));

            ControllerOfMeals.Items.Clear();

            foreach (var meal in meals)
            {
                MealController mealController = new MealController();

                mealController.Id = meal.Id;
                mealController.MealNameTxt.Text = meal.Name;
                mealController.MealCostTxt.Text = meal.Cost;
                mealController.MealImage.Source = new BitmapImage(new Uri(meal.ImagePath, UriKind.Absolute));

                Button button = new Button()
                {
                    Height = 120,
                    Width = 210,
                    Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FDFBFD")),
                    Padding = new Thickness(-3, -1, 2, 2),
                    BorderBrush = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF5800")),
                    BorderThickness = new Thickness(2),
                    Margin = new Thickness(2)
                };

                button.Content = mealController;

                button.Click += MealControllerBtn_Click;

                ControllerOfMeals.Items.Add(button);

            }
        }

        private async void MealControllerBtn_Click(object sender, RoutedEventArgs e)
        {
            var mealInfo = (sender as Button).Content as MealController;

            var meal = await genericRepositoryOfMeal.GetAsync(mealInfo.Id);
            if (meal != null) 
            { 
            mealUpdatePage.MealName.Text = meal.Name;
            mealUpdatePage.MealCost.Text = meal.Cost;
            mealUpdatePage.MealId.Text = meal.Id.ToString();
            mealUpdatePage.MealCreationTime.Text = meal.CreationTime.ToString();
            mealUpdatePage.ImageMealAdd.Source = new BitmapImage(new Uri(meal.ImagePath, UriKind.Absolute));
                
            if (meal.UpdatedTime != null)
                mealUpdatePage.MealUpdatedTime.Text = meal.UpdatedTime.ToString();
            else
                    
                mealUpdatePage.MealUpdatedTime.Text = "not updated yet";

            mealPageFrame.Content = mealUpdatePage;
        }
            else
            {
                mealPageFrame.NavigationService.Navigate(null);

                MessageBox.Show("Nothing found. Please, Press 'Refresh' button");
            }
    }


        private void openMealPageBtn_Click(object sender, RoutedEventArgs e)
        {
            mealPageFrame.Content = new AddMealPage();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
                if (e.LeftButton == MouseButtonState.Pressed)
                    DragMove();
        }
    }
}
