using System;

namespace Pendulum
{
    class RungeKutta
    {
        /// <summary>
        /// Решение диффернциального уравнения методом Рунге-Кутты 4-ого порядка.
        /// </summary>
        /// <param name="system">Система</param>
        /// <param name="x0"></param>
        /// <param name="Vx0"></param>
        /// <param name="dt"></param>
        /// <param name="x"></param>
        /// <param name="Vx"></param>
        public static void DSolve(PendulumSystem system, double x0, double Vx0, double dt, out double x, out double Vx)
        {
            // Подсчёт коэффициентов.
            double kv1 = system.FirstDiffEquation(x0, Vx0) * dt;
            double kx1 = system.SecondDiffEquation(x0, Vx0) * dt;

            double kv2 = system.FirstDiffEquation(x0 + kx1 * 0.5, Vx0 + kv1 * 0.5) * dt;
            double kx2 = system.SecondDiffEquation(x0 + kx1 * 0.5, Vx0 + kv1 * 0.5) * dt;

            double kv3 = system.FirstDiffEquation(x0 + kx2 * 0.5, Vx0 + kv2 * 0.5) * dt;
            double kx3 = system.SecondDiffEquation(x0 + kx2 * 0.5, Vx0 + kv2 * 0.5) * dt;

            double kv4 = system.FirstDiffEquation(x0 + kx3, Vx0 + kv3) * dt;
            double kx4 = system.SecondDiffEquation(x0 + kx3, Vx0 + kv3) * dt;

            x = x0 + (kx1 + 2 * kx2 + 2 * kx3 + kx4) / 6;
            Vx = Vx0 + (kv1 + 2 * kv2 + 2 * kv3 + kv4) / 6;
        }
    }
}
