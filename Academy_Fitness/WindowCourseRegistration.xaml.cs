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
using System.Windows.Shapes;
using Academy_Fitness.Model;

namespace Academy_Fitness
{
    /// <summary>
    /// Логика взаимодействия для WindowCourseRegistration.xaml
    /// </summary>
    public partial class WindowCourseRegistration : Window
    {

        Academy_fitnessEntities context;
        public WindowCourseRegistration(Academy_fitnessEntities context, CourseRegistration currentRegistartion)
        {
            InitializeComponent();
            this.context = context;
            CmbCourse.ItemsSource = context.Course.ToList();
            CmbTrainer.ItemsSource = context.Trainer.ToList();

            this.DataContext = currentRegistartion;
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            if(CheckRegistration())
            {
                context.SaveChanges();
                this.Close();
                MessageBox.Show("Данные успешно добавлены!", "Успешно", MessageBoxButton.OK, MessageBoxImage.Information);
            }
          
        }

        private bool CheckRegistration()
        {
            var reg = this.DataContext as CourseRegistration;
            if (reg.Trainer == null)
            {
                MessageBox.Show("Тренер не выбран!");
                return false;
            }
            if (reg.Course == null)
            {
                MessageBox.Show("Курсы не выбраны!");
                return false;
            }
            if (reg.CreatedDate == null)
            {
                MessageBox.Show("Дата не выбрана!");
                return false;
            }

            if (!int.TryParse(TxtTotalPoint.Text, out int result))
            {
                MessageBox.Show("Неверные данные!");
                return false;
            }
            return true;
        }





    }
}
