using System;
using System.Windows.Forms;

namespace Pendulum
{
    public partial class MainForm : Form
    {
        private DrawingClass systemVisualization;
        private PendulumSystem pendulumSystem;
        private double x0, V0, x, V, dt;
        private double time;

        public MainForm()
        {
            InitializeComponent();
        }

        private void OnLoadMainForm(object sender, EventArgs e)
        {
            // Отрисовка системы.
            Drawing();
            systemVisualization.DrawPendulumSystem(0, 0);

            OnClickGenPhasePortrets(null, null);
        }

        private void OnClickButtonStartSolve(object sender, EventArgs e)
        {
            // Инициализация системы.
            pendulumSystem = new PendulumSystem(
                (double)numUpDown_Weight.Value,
                1,
                (double)numUpDown_CoefElasticity.Value,     // Коэф. жёсткости.
                (double)numUpDown_CoefFriction.Value,       // Коэф. сухого трения.
                (double)numUpDown_CoefViscosity.Value       // Коэф. вязкого трения.
                );
            x0 = (double)numUpDown_Position.Value;
            V0 = (double)numUpDown_Velocity.Value;
            dt = (double)numUpDown_stepTime.Value;
            time = 0;

            chart_PhasePortrait.Series[10].Points.Clear();

            //Исследование зависимости периода колебания тела от амплитуды.
            chart_PeriodAmpl.Series[0].Points.Clear();
            for (double ampl = 1; ampl <= 5; ampl += 0.1)
            {
                time = 0;
                double xx0 = ampl, VV0 = V0, xx, VV;
                while (true)
                {
                    time += dt;
                    // Решение системы методом Рунге-Кутты 4-ого порядка.
                    RungeKutta.DSolve(pendulumSystem, xx0, VV0, dt, out xx, out VV);
                    if (VV0 > 0 && VV < 0)
                    {
                        chart_PeriodAmpl.Series[0].Points.AddXY(ampl, time);
                        break;
                    }
                    // Обновление данных.
                    xx0 = xx;
                    VV0 = VV;
                }
            }

            // Запуск таймера.
            timer.Interval = (int)(dt * 1000);
            timer.Start();

            buttonStopSolve.Text = "Остановить";
            buttonStopSolve.Enabled = true;
        }

        private void OnClickButtonStopSolve(object sender, EventArgs e)
        {
            if (timer.Enabled)
            {
                timer.Stop();
                buttonStopSolve.Text = "Продолжить";
            }
            else
            {
                timer.Start();
                buttonStopSolve.Text = "Остановить";
            }
        }

        private void OnTickTimer(object sender, EventArgs e)
        {
            // Решение системы методом Рунге-Кутты 4-ого порядка.
            RungeKutta.DSolve(pendulumSystem, x0, V0, dt, out x, out V);
            // Отрисовка фазовой траектории.
            chart_PhasePortrait.Series[10].Points.AddXY(x0, V0);
            // Отрисовка системы.
            Drawing();
            systemVisualization.Clear();
            systemVisualization.DrawPendulumSystem(x0, V0);

            // Обновление данных.
            x0 = x;
            V0 = V;
        }

        private void Drawing()
        {
            systemVisualization = new DrawingClass(pictureBox_SystemVisualization, 0, 0, 11, 11);
            systemVisualization.SetGrades(10, 10);
        }

        private void OnClickGenPhasePortrets(object sender, EventArgs e)
        {
            pendulumSystem = new PendulumSystem(
                (double)numUpDown_Weight.Value,
                1,
                (double)numUpDown_CoefElasticity.Value,
                (double)numUpDown_CoefFriction.Value,
                (double)numUpDown_CoefViscosity.Value);

            var posArray = new double[(int)numUpDown_countPortrets.Value];
            var velArray = new double[(int)numUpDown_countPortrets.Value];

            for (int i = 0; i < chart_PhasePortrait.Series.Count - 1; i++)
                chart_PhasePortrait.Series[i].Points.Clear();

            for (int i = 0; i < posArray.Length; i++)
                posArray[i] = 1 + i * (double)numUpDown_step.Value;

            for (int i = 0; i < 200; i++)
            {
                for (int j = 0; j < posArray.Length; j++)
                {
                    RungeKutta.DSolve(pendulumSystem, posArray[j], velArray[j], dt, out x, out V);
                    // Отрисовка фазовых портретов.
                    chart_PhasePortrait.Series[j].Points.AddXY(posArray[j], velArray[j]);
                    posArray[j] = x;
                    velArray[j] = V;
                }
            }
        }
    }
}