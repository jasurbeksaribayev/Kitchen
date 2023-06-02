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

namespace WPFwithEF.Controllers
{
    /// <summary>
    /// Interaction logic for MealController.xaml
    /// </summary>
    public partial class MealController : UserControl
    {
        public int Id { get; set; }
        public MealController()
        {
            InitializeComponent();
        }
    }
}
