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
using YrFit.Utilities;

namespace YrFit.View
{
    /// <summary>
    /// Логика взаимодействия для PersonPage.xaml
    /// </summary>
    public partial class PersonPage : UserControl
    {
        public PersonPage()
        {
            InitializeComponent();
        }

        private void CalculateCalories_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string gender = MaleRadioButton.IsChecked == true ? "male" : "female";
                double weight = double.Parse(WeightTextBox.Text);
                double height = double.Parse(HeightTextBox.Text);
                int age = int.Parse(AgeTextBox.Text);
                double activityLevel = 1.55;

                if (1000 < weight || weight < 3 || height < 50 || height >250 || age < 10|| age > 120)
                {
                    MessageBox.Show("Ввод значений недопустим.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                string goal = ((ComboBoxItem)GoalComboBox.SelectedItem).Content.ToString();

           
                CalorieCalculator calculator = new CalorieCalculator();
                double calorieNeeds = calculator.CalculateCalories(gender, weight, height, age, activityLevel, goal);

   
                ResultTextBlock.Text = $"{calorieNeeds:F2} ккал/день";
            }
            catch (FormatException)
            {
                MessageBox.Show("Проверьте правильность ввода данных.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

    }
}
