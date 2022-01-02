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
using Academy_Fitness.Model;

namespace Academy_Fitness
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Academy_fitnessEntities context;
        public MainWindow()
        {
            InitializeComponent();
            context = new Academy_fitnessEntities();
            DataGridRegistration.ItemsSource = context.CourseRegistration.ToList();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
 
            var newRegistration = new CourseRegistration();
            context.CourseRegistration.Add(newRegistration);
            var win = new WindowCourseRegistration(context, newRegistration);
            win.ShowDialog();
            DataGridRegistration.ItemsSource = context.CourseRegistration.ToList();
        }

        private void BtnRemove_Click(object sender, RoutedEventArgs e)
        {
            var remove = DataGridRegistration.SelectedItem as CourseRegistration;
            if(remove == null)
            {
                MessageBox.Show("Строка не выбрана!");
                return;
            }
            else
            {
                context.CourseRegistration.Remove(remove);
                context.SaveChanges();
                DataGridRegistration.ItemsSource = context.CourseRegistration.ToList();
                MessageBox.Show("Данные успешно удалены!", "Успешно", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            Button btnEdit = sender as Button;
            var currentRegistration = btnEdit.DataContext as CourseRegistration;
            var win = new WindowCourseRegistration(context,currentRegistration);
            win.ShowDialog();
        }
    }
}
