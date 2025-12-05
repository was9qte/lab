using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labwork
{
    public partial class Calculate : Form
    {
        public Calculate()
        {
            InitializeComponent();
            ResultLabel.AutoSize = true;
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(XTextBox.Text);
                int z = int.Parse(ZTextBox.Text);
                int a = int.Parse(ATextBox.Text);
                int b = int.Parse(BTextBox.Text);

                double result = ExpressionSolver.Calculate(x, z, a, b);

                ResultLabel.Text = $"Результат: y = {result:F4}";
            }
            catch (FormatException)
            {
                ShowError("Некорректный формат числа. Введите целые числа.");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                ShowError($"Ошибка ввода: {ex.Message}");
            }
            catch (ArgumentException ex)
            {
                ShowError($"Ошибка: {ex.Message}");
            }
            catch (DivideByZeroException ex)
            {
                ShowError(ex.Message);
            }
            catch (OverflowException)
            {
                ShowError("Число слишком большое. Введите меньшее значение.");
            }
            catch (Exception ex)
            {
                ShowError($"Неожиданная ошибка: {ex.Message}");
            }
        }
        private void ShowError(string message)
        {
            ResultLabel.Text = "Результат: ошибка";
            MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
public static class ExpressionSolver
{
    public static double Calculate(int x, int z, int a, int b)
    {
        if (x < -3)
            throw new ArgumentOutOfRangeException(nameof(x),
                "x должно быть ≥ -3, иначе подкоренное выражение отрицательно");
        if (z == 0)
            throw new DivideByZeroException("z не может быть равно 0 (деление на ноль)");
        if (a <= 0)
            throw new ArgumentOutOfRangeException(nameof(a),
                "Основание логарифма a должно быть > 0");
        if (a == 1)
            throw new ArgumentException(
                "Основание логарифма не может быть равно 1", nameof(a));
        if (b <= 0)
            throw new ArgumentOutOfRangeException(nameof(b),
                "Аргумент логарифма b должен быть > 0");
        double sqrtPart = Math.Sqrt(x + 3);
        double fraction = sqrtPart / z;
        double logPart = Math.Log(b, a);
        return fraction + logPart;
    }
}