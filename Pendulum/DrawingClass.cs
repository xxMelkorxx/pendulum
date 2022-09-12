using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Pendulum
{
    class DrawingClass
    {
        private PictureBox pictureBox;
        private Graphics graphics;
        private Bitmap bitmap;

        private double wnd_Xmin, wnd_Xmax, wnd_Ymin, wnd_Ymax;
        private int nx, ny;
        private double alpha, beta;
        private double dx, dy;

        public DrawingClass(PictureBox pB, double x1, double y1, double x2, double y2)
        {
            pictureBox = pB;
            bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            graphics = Graphics.FromImage(bitmap);

            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            SetGrades(20, 20);
            wnd_Xmin = x1; wnd_Xmax = x2;
            wnd_Ymin = y1; wnd_Ymax = y2;
            dx = (wnd_Xmax - wnd_Xmin) / nx;
            dy = (wnd_Ymax - wnd_Ymin) / ny;
            alpha = pictureBox.Width / (wnd_Xmax - wnd_Xmin);
            beta = pictureBox.Height / (wnd_Ymax - wnd_Ymin);

            pictureBox.Image = bitmap;
        }

        /// <summary>
        /// Position enumeration for determining legend and text positions.
        /// </summary>
        public enum Position
        {
            TOP_LEFT, TOP_RIGHT, BOTTOM_LEFT, BOTTOM_RIGHT, TOP_CENTER, BOTTOM_CENTER, RIGHT_CENTER
        }

        /// <summary>
        /// Очищает область.
        /// </summary>
        public void Clear()
        {
            graphics.Clear(Color.White);
        }

        /// <summary>
        /// Настраивает выравние сетки.
        /// </summary>
        /// <param name="inx"></param>
        /// <param name="iny"></param>
        public void SetGrades(int inx, int iny)
        {
            nx = inx; ny = iny;
            dx = (wnd_Xmax - wnd_Xmin) / nx;
            dy = (wnd_Ymax - wnd_Ymin) / ny;
        }

        #region COORDINATE_TRANSFORMATIONS
        /// <summary>
        /// Преобразует мировые координаты в координаты окна (пиксели).
        /// </summary>
        /// <param name="x">X в мировых координатах.</param>
        /// <returns>Координата, преобразованная в координаты окна (пиксели).</returns>
        private int OutX(double x)
        {
            return (int)Math.Floor((x - wnd_Xmin) * alpha);
        }

        /// <summary>
        /// Преобразует мировые координаты в координаты окна (пиксели).
        /// </summary>
        /// <param name="y">Y мировых координатах.s</param>
        /// <returns>Координата, преобразованная в координаты окна (пиксели).</returns>
        private int OutY(double y, bool size = false)
        {
            if (size)
                return (int)Math.Floor((y - wnd_Ymin) * beta);
            else
                return (int)Math.Floor(pictureBox.Height - (y - wnd_Ymin) * beta);
        }

        /// <summary>
        /// Преобразует координаты окна (пиксели) в мировые координаты.
        /// </summary>
        /// <param name="x">X-координата в пикселях.</param>
        /// <returns>Координата, преобразованная в мировые координаты.</returns>
        private double InX(int x)
        {
            return (x / alpha) + wnd_Xmin;
        }

        /// <summary>
        /// Преобразует координаты окна (пиксели) в мировые координаты.
        /// </summary>
        /// <param name="y">Y-координата в пикселях.</param>
        /// <returns>Координата, преобразованная в мировые координаты.</returns>
        private double InY(int y)
        {
            return -(y / beta) + wnd_Ymax;
        }
        #endregion

        /// <summary>
        /// Рисует прямую линию между двумя заданными точками.
        /// </summary>
        /// <param name="color">Цвет линии.</param>
        /// <param name="x1">X-положение начальной точки в мировых координатах.</param>
        /// <param name="y1">Y-положение начальной точки в мировых координатах.</param>
        /// <param name="x2">X-положение конечной точки в мировых координатах.</param>
        /// <param name="y2">Y-положение конечной точки в мировых координатах.</param>
        private void DrawLine(Color color, double x1, double y1, double x2, double y2, float width = 1f)
        {
            Pen pen = new Pen(color);
            pen.Width = width;
            pen.DashStyle = DashStyle.Solid;
            graphics.DrawLine(pen, OutX(x1), OutY(y1), OutX(x2), OutY(y2));
        }

        /// <summary>
        /// Рисует прямоугольник.
        /// </summary>
        /// <param name="color">Цвет заливки.</param>
        /// <param name="x">X-положение начальной точки в мировых координатах.</param>
        /// <param name="y">Y-положение начальной точки в мировых координатах.</param>
        /// <param name="width">Ширина прямоугольника в мировых координатах.</param>
        /// <param name="height">Высота прямоугольника в мировых координатах.</param>
        private void DrawColoredRectangle(Color color, double x, double y, double width, double height)
        {
            SolidBrush brush = new SolidBrush(color);
            graphics.FillRectangle(brush, OutX(x) - OutX(width) / 2, OutY(y) - OutY(height, true) / 2, OutX(width) + 1, OutY(height, true) + 1);
        }

        /// <summary>
        /// Рисует эллипс.
        /// </summary>
        /// <param name="x">X-положение начальной точки в мировых координатах.</param>
        /// <param name="y">Y-положение начальной точки в мировых координатах.</param>
        /// <param name="width">Ширина эллипса в мировых координатах.</param>
        /// <param name="height">Высота эллипса в мировых координатах.</param>
        private void DrawEllipse(Color color, double x, double y, double width, double height)
        {
            SolidBrush brush = new SolidBrush(color);
            graphics.FillEllipse(brush, OutX(x) - OutX(width) / 2, OutY(y) - OutY(height) / 2, OutX(width), OutY(height, true));
        }

        /// <summary>
        /// Auxiliary function for finding the longest <see cref="string"/> from a sequence of strings.
        /// </summary>
        /// <param name="labels">The sequence for which the longest element shall be found.</param>
        /// <returns>The longest <see cref="string"/> from <paramref name="labels"/>.</returns>
        private string LongestLabel(string[] labels)
        {
            string longest = "";
            foreach (string str in labels)
                if (str.Length > longest.Length)
                    longest = str;
            return longest;
        }

        /// <summary>
        /// Creates a textbox. The title, if it exists, will be unterlined to the full width of the box.
        /// Multiline text can be entered by using the escape sequence <code>\n</code> to separate lines in the entered string.
        /// Multiline titles are not supported and may lead to unpredictable behaviour.
        /// Providing title and text is optional, so you can create either plain textboxes without a headline or a headline, for example
        /// for documenting your graph and give it a title for usage in documentations and reports.
        /// </summary>
        /// <param name="title">The textbox headline. This must be a single line <see cref="string"/> or <code>null</code>.</param>
        /// <param name="text">The textbox content. This can be a multiline string separated by \n escape sequences or null.</param>
        /// <param name="pos">The <see cref="Position"/> of the textbox.</param>
        /// <param name="color">The <see cref="Color"/> in which title and text will be displayed.</param>
        /// <param name="fontSize">The font size to be used for title and text, 10px by default.</param>
        public void DrawTextBox(string title, string text, Position pos, Color color, float fontSize = 10.0f, byte opacity = 150)
        {
            Brush fontColor = new SolidBrush(color);
            Brush backgroundColor = new SolidBrush(Color.FromArgb(opacity, 255, 255, 255));
            Font font = new Font(FontFamily.GenericMonospace, fontSize, FontStyle.Italic, GraphicsUnit.Pixel);
            Font headlineFont = new Font(font, FontStyle.Underline);
            string[] textAsLines = (text == null) ? null : text.Split('\n');
            Rectangle frame = new Rectangle(0, 0, 
                (int)Math.Max(text == null ? 0 : graphics.MeasureString(LongestLabel(textAsLines), font).Width, title == null ? 0 : graphics.MeasureString(title, font).Width) + 5, 
                (text == null ? 0 : textAsLines.Length * font.Height) + (title == null ? 0 : font.Height) + 5);
            switch (pos)
            {
                case Position.TOP_LEFT:
                    frame.X = 5;
                    frame.Y = 5;
                    break;
                case Position.TOP_RIGHT:
                    frame.X = pictureBox.Width - frame.Width - 8;
                    frame.Y = 5;
                    break;
                case Position.BOTTOM_LEFT:
                    frame.X = 5;
                    frame.Y = pictureBox.Height - frame.Height - 8;
                    break;
                case Position.BOTTOM_RIGHT:
                    frame.X = pictureBox.Width - frame.Width - 8;
                    frame.Y = pictureBox.Height - frame.Height - 8;
                    break;
                case Position.TOP_CENTER:
                    frame.X = pictureBox.Width / 2 - frame.Width / 2;
                    frame.Y = 5;
                    break;
                case Position.BOTTOM_CENTER:
                    frame.X = pictureBox.Width / 2 - frame.Width / 2;
                    frame.Y = pictureBox.Height - frame.Height - 8;
                    break;
            }
            graphics.FillRectangle(backgroundColor, frame);
            graphics.DrawRectangle(Pens.Black, frame);
            if (title != null)
                graphics.DrawString(text == null ? title : title.PadRight(LongestLabel(textAsLines).Length - 1) + (char)127, headlineFont, fontColor, frame.X + 2, frame.Y + 2);
            if (textAsLines != null)
                for (int i = 0; i < textAsLines.Length; i++)
                    graphics.DrawString(textAsLines[i], font, fontColor, frame.X + 2, frame.Y + 2 + (i + (title == null ? 0 : 1)) * font.Height);
        }

        /// <summary>
        /// Отрисовка системы.
        /// </summary>
        /// <param name="pos"></param>
        public void DrawPendulumSystem(double pos, double velocity)
        {
            Random rnd = new Random(DateTime.Now.Millisecond);

            // Стержень.
            DrawLine(Color.Black, 0, 5.5, 11, 5.5, 4f);
            // Пружина.
            DrawLine(Color.SlateGray, 5.5, 11, 5.5 + pos, 5.5, 4f);
            // Грузик.
            DrawEllipse(Color.Red, 5.5 + pos, 1, 1, 1);

            // Левая стенка.
            //Random rnd = new Random(DateTime.Now.Millisecond);
            DrawColoredRectangle(Color.DarkGray, 0, 6, 1, 12);
            // Нижняя стенка.
            DrawColoredRectangle(Color.DarkGray, 6, 0, 12, 1);
            // Верхняя стенка.
            DrawColoredRectangle(Color.DarkGray, 6, 11, 12, 1);
            // Правая стенка.
            DrawColoredRectangle(Color.DarkGray, 11, 6, 1, 12);
            // Подписи скорости и координаты.
            string title = "Положение и скорость тела:";
            string text = string.Format("Х: " + Math.Round(pos, 3) + ";\t V: " + Math.Round(velocity, 3) + "\t");
            DrawTextBox(title, text, Position.BOTTOM_RIGHT, Color.Black);
        }
    }
}