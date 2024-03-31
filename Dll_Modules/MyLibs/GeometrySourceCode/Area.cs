namespace GeometrySourceCode
{
    public static class Area
    {
        /// <summary>
        /// Обчислює площу квадрата.
        /// </summary>
        /// <param name="a">Довжина сторони квадрата.</param>
        /// <returns>Площа квадрата.</returns>
        public static double Square(double a)
        {
            return a * a;
        }

        /// <summary>
        /// Обчислює площу прямокутника.
        /// </summary>
        /// <param name="a">Довжина прямокутника.</param>
        /// <param name="b">Ширина прямокутника.</param>
        /// <returns>Площа прямокутника.</returns>
        public static double Rectangle(double a, double b)
        {
            return a * b;
        }

        /// <summary>
        /// Обчислює площу трикутника.
        /// </summary>
        /// <param name="a">Довжина основи трикутника.</param>
        /// <param name="h">Висота трикутника.</param>
        /// <returns>Площа трикутника.</returns>
        public static double Triangle(double a, double h)
        {
            return 0.5 * a * h;
        }

        /// <summary>
        /// Обчислює площу трикутника за формулою Герона.
        /// </summary>
        /// <param name="a">Перша сторона трикутника.</param>
        /// <param name="b">Друга сторона трикутника.</param>
        /// <param name="c">Третя сторона трикутника.</param>
        /// <returns>Площа трикутника.</returns>
        public static double Triangle(double a, double b, double c)
        {
            double s = (a + b + c) / 2.0;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }

        /// <summary>
        /// Обчислює площу кола.
        /// </summary>
        /// <param name="r">Радіус кола.</param>
        /// <returns>Площа кола.</returns>
        public static double Circle(double r)
        {
            return Math.PI * Math.Pow(r, 2);
        }

        /// <summary>
        /// Обчислює площу паралелограма.
        /// </summary>
        /// <param name="a">Довжина основи паралелограма.</param>
        /// <param name="h">Висота паралелограма.</param>
        /// <returns>Площа паралелограма.</returns>
        public static double Parallelogram(double a, double h)
        {
            return a * h;
        }

        /// <summary>
        /// Обчислює площу трапеції.
        /// </summary>
        /// <param name="a">Довжина першої основи трапеції.</param>
        /// <param name="b">Довжина другої основи трапеції.</param>
        /// <param name="h">Висота трапеції.</param>
        /// <returns>Площа трапеції.</returns>
        public static double Trapezoid(double a, double b, double h)
        {
            return 0.5 * (a + b) * h;
        }
    }
}
