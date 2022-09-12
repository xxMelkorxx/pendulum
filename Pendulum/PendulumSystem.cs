using System;

namespace Pendulum
{
    class PendulumSystem
    {
        /// <summary>
        /// Ускорение свободного падения.
        /// </summary>
        public const double g = 9.80665;
        /// <summary>
        /// Масса груза.
        /// </summary>
        public double Weight;
        /// <summary>
        /// Начальная длина пружины.
        /// </summary>
        public double Length;
        /// <summary>
        /// Коэффициент трения о стержень.
        /// </summary>
        public double CoefFriction;
        /// <summary>
        /// Коэффициент вязкости.
        /// </summary>
        public double CoefViscosity;
        /// <summary>
        /// Коэффициент вязкости.
        /// </summary>
        public double CoefElasticity;

        /// <summary>
        /// Физическая система пружинного маятника.
        /// </summary>
        /// <param name="weight">Масса грузика.</param>
        /// <param name="length">Длина пружины.</param>
        /// <param name="coefElasticity">Коэффициент упругости пружины.</param>
        /// <param name="coefFriction">Коэффициент трения о стержень.</param>
        /// <param name="coefViscosity">Коэффициент вязкости среды.</param>
        public PendulumSystem(
            double weight,
            double length,
            double coefElasticity,
            double coefFriction,
            double coefViscosity)
        {
            Weight = weight;
            Length = length;
            CoefFriction = coefFriction;
            CoefViscosity = coefViscosity;
            CoefElasticity = coefElasticity;
        }

        public double FirstDiffEquation(double x, double Vx)
        {
            double F1 = CoefViscosity / Weight * Vx;
            double F2 = CoefElasticity / Weight * (x - (/*(Vx < 0) ? 1 : -1 **/ CoefFriction * Length)) * (1 - Length / Math.Sqrt(Length * Length + x * x));
            double F3 = (Vx < 0) ? 1 : -1 * CoefFriction * g;
            return -F1 - F2 + F3;
        }

        public double SecondDiffEquation(double x, double Vx)
        {
            return Vx;
        }
    }
}
