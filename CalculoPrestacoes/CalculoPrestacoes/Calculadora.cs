using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;

namespace CalculoPrestacoes
{
    internal class Calculadora
    {
        public enum Variavel { 
            P, T, V, N
        }

        private Variavel em_ordem;
        private double p, t, v, n;

        public Calculadora(double p, double t, double v, double n, Variavel em_ordem)
        {
            this.p = p;
            this.t = t;
            this.v = v;
            this.n = n;
            this.em_ordem = em_ordem;
        }

        public static int Clamp(int value, int min, int max)
        {
            return (value < min) ? min : (value > max) ? max : value;
        }

        private bool IsSafe(double y)
        {
            return !double.IsNaN(y) && !double.IsInfinity(y) && y >= -1e5 && y <= 1e5;
        }

        public double Calcular()
        {
            double resultado = 0;
            switch (em_ordem)
            {
                case Calculadora.Variavel.P:
                    p = v * t * (Math.Pow(1 + t, n) / (Math.Pow(1 + t, n) - 1));
                    resultado = p;
                    break;
                case Calculadora.Variavel.V:
                    v = p / ((Math.Pow(1 + t, n) / (Math.Pow(1 + t, n) - 1)) * t);
                    resultado = v;
                    break;
                case Calculadora.Variavel.T:
                    {
                        bool? searching_below = null;
                        var function_window = (Math.Abs(function_min) + Math.Abs(function_max));
                        var function_cache_size = function_window * function_precision;
                        for (int i = 0; i < function_cache_size; i++)
                        {
                            var x = (i / (double)function_precision + function_min);
                            var calculadora = new Calculadora(p, x, v, n, Variavel.P);
                            var y = calculadora.Calcular();

                            if (IsSafe(y))
                            {
                                // find intersection f1 and f2
                                if (searching_below == null)
                                {
                                    searching_below = y < p;
                                }
                                else
                                {
                                    if (y > p && searching_below.Value || y < p && !searching_below.Value)
                                    {
                                        resultado = x;
                                        searching_below = !searching_below;
                                    }
                                }
                            }
                        }
                    }
                    break;
                case Calculadora.Variavel.N:
                    { 
                        bool? searching_below = null;
                        var function_window = (Math.Abs(function_min) + Math.Abs(function_max));
                        var function_cache_size = function_window * function_precision;
                        for (int i = 0; i < function_cache_size; i++)
                        {
                            var x = (i / (double)function_precision + function_min);
                            var calculadora = new Calculadora(p, t, v, x, Variavel.P);
                            var y = calculadora.Calcular();

                            if (IsSafe(y))
                            {
                                // find intersection f1 and f2
                                if (searching_below == null)
                                {
                                    searching_below = y < p;
                                }
                                else
                                {
                                    if (y > p && searching_below.Value || y < p && !searching_below.Value)
                                    {
                                        resultado = x;
                                        searching_below = !searching_below;
                                    }
                                }
                            }
                        }
                    }
                    break;
            }
            return resultado;
        }

        private int function_min = -1000;
        private int function_max = 1000;
        private int function_precision = 20;
        public double[] function_cache;

        public void DesenharGrafico(PictureBox pictureBox1, PointF scale, Point center, Variavel x_target, Variavel y_target, double div)
        {
            Func<double, double> funcao = (x) =>
            {
                Calculadora calculadora = null;
                switch (x_target)
                {
                    case Variavel.P:
                        calculadora = new Calculadora(x, t, v, n, y_target);
                        break;
                    case Variavel.T:
                        calculadora = new Calculadora(p, x, v, n, y_target);
                        break;
                    case Variavel.V:
                        calculadora = new Calculadora(p, t, x, n, y_target);
                        break;
                    case Variavel.N:
                        calculadora = new Calculadora(p, t, v, x, y_target);
                        break;
                }

                if (calculadora == null) return 0;
                return calculadora.Calcular();
            };

            Func<double> funcao2 = () =>
            {
                switch (y_target)
                {
                    case Variavel.P:
                        return p;
                    case Variavel.T:
                        return t;
                    case Variavel.V:
                        return v;
                    case Variavel.N:
                        return n;
                }
                return 0;
            };

            var canvas_width = pictureBox1.Size.Width;
            var canvas_height = pictureBox1.Size.Height;
            var ref_brush = new SolidBrush(Color.Black);
            var sub_ref_brush = new SolidBrush(Color.Gray);
            var imagem = new Bitmap(canvas_width, canvas_height);
            var canvas = Graphics.FromImage(imagem);
            canvas.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            var antialias_canvas = Graphics.FromImage(imagem);
            antialias_canvas.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            var thickness = 2;
            var margin = 2;

            // Desenhar divs
            if (div > 0)
            {
                var y_font_size = Clamp((int)((2 / scale.Y) * div / 5), 5, 12);
                var y_font = new Font("Arial", y_font_size);
                var y_bot_div_count = (int)((canvas_height - center.Y) * scale.Y / div);
                for (int i = 1; i <= y_bot_div_count; i++)
                {
                    var text = $"{-i * div}";
                    var y_bot_font_rect = canvas.MeasureString(text, y_font);
                    var y = (int)(div / scale.Y * i);
                    canvas.FillRectangle(sub_ref_brush, 0, y + center.Y, canvas_width, 1);
                    if (y_font_size > 5)
                        canvas.DrawString(text, y_font, ref_brush, Clamp(center.X, 0, canvas_width - (int)y_bot_font_rect.Width), y + center.Y);
                }
                var y_top_div_count = (int)(center.Y * scale.Y / div);
                for (int i = 1; i <= y_top_div_count; i++)
                {
                    var text = $"{i * div}";
                    var y_top_font_rect = canvas.MeasureString(text, y_font);
                    var y = (int)(div / scale.Y * i);
                    canvas.FillRectangle(sub_ref_brush, 0, center.Y - y, canvas_width, 1);
                    if (y_font_size > 5)
                        canvas.DrawString(text, y_font, ref_brush, Clamp(center.X, 0, canvas_width - (int)y_top_font_rect.Width), center.Y - y - y_top_font_rect.Height);
                }

                var x_font_size = Clamp((int)((2 / scale.X) * div / 5), 5, 12);
                var x_font = new Font("Arial", x_font_size);
                var x_right_div_count = (int)((canvas_width - center.X) * scale.X / div);
                var x_right_font_rect = canvas.MeasureString($"{x_right_div_count * div}", x_font);
                for (int i = 0; i <= x_right_div_count; i++)
                {
                    var x = (int)(div / scale.X * i);
                    canvas.FillRectangle(sub_ref_brush, x + center.X, 0, 1, canvas_height);
                    if (x_font_size > 5)
                        canvas.DrawString($"{i * div}", x_font, ref_brush, x + center.X, Clamp(center.Y + margin, 0, canvas_height - (int)x_right_font_rect.Height));
                }
                var x_left_div_count = (int)(center.X * scale.X / div);
                for (int i = 1; i <= x_left_div_count; i++)
                {
                    var text = $"{-i * div}";
                    var x_left_font_rect = canvas.MeasureString(text, x_font);
                    var x = (int)(div / scale.X * i);
                    canvas.FillRectangle(sub_ref_brush, center.X - x, 0, 1, canvas_height);
                    if (x_font_size > 5)
                        canvas.DrawString(text, x_font, ref_brush, center.X - x - x_left_font_rect.Width, Clamp(center.Y + margin, 0, canvas_height - (int)x_left_font_rect.Height));
                }
            }

            canvas.FillRectangle(ref_brush, 0, center.Y, canvas_width, thickness);
            canvas.FillRectangle(ref_brush, center.X, 0, thickness, canvas_height);

            var function_window = (Math.Abs(function_min) + Math.Abs(function_max));
            var function_cache_size = function_window * function_precision;
            if (function_cache == null)
            {
                function_cache = new double[function_cache_size];
                for (int i = 0; i < function_cache_size; i++)
                {
                    var x = (i / (double)function_precision + function_min);
                    function_cache[i] = funcao(x);
                }
            }

            var fun_pen = new Pen(Color.Red, thickness);

            var startI = Math.Max((int)((-function_min - (center.X * scale.X)) * function_precision), 0);
            var endI = Math.Min((int)((-function_min + ((canvas_width - center.X) * scale.X)) * function_precision), function_cache_size - 1);
            bool? searching_below = null;
            int? x_eq = null;
            var jump = 1; // Math.Max((int)(function_precision * scale.X * scale.X), 1);
            for (int i = startI; i < endI; i+=jump)
            {
                var y = function_cache[i];
                var y2 = function_cache[i+jump];
                if (IsSafe(y) && IsSafe(y2)) 
                {
                    var x_a_desenhar = (i - startI) * canvas_width / (endI - startI);
                    var x2_a_desenhar = (i + jump - startI) * canvas_width / (endI - startI);

                    // find intersection f1 and f2
                    if (searching_below == null)
                    {
                        searching_below = y < funcao2();
                    }
                    else
                    {
                        if (y > funcao2() && searching_below.Value || y < funcao2() && !searching_below.Value)
                        {
                            x_eq = x_a_desenhar;
                            searching_below = !searching_below;
                        }
                    }

                    var y_a_desenhar = (int)(center.Y - y / scale.Y);
                    var y2_a_desenhar = (int)(center.Y - y2 / scale.Y);
                    if (y_a_desenhar > 0 && y_a_desenhar < canvas_height || y2_a_desenhar > 0 && y2_a_desenhar < canvas_height)
                    {
                        antialias_canvas.DrawLine(fun_pen, x_a_desenhar, y_a_desenhar, x2_a_desenhar, y2_a_desenhar);
                    }
                }
            }

            // Funcao 2
            canvas.FillRectangle(Brushes.Green, 0, center.Y - (int)funcao2() / scale.Y, canvas_width, thickness);

            if (x_eq != null)
                canvas.FillRectangle(Brushes.BlueViolet, x_eq.Value, 0, thickness, canvas_height);

            fun_pen.Dispose();

            canvas.Dispose();
            ref_brush.Dispose();
            sub_ref_brush.Dispose();
            pictureBox1.Image = imagem;
        }
    }
}

            /*
                int? x_eq = null;
                bool? searching_below = null;
                double? prev_y = null;
                for (int x_a_desenhar = -1; x_a_desenhar < canvas_width; x_a_desenhar++)
                {
                    var x = (x_a_desenhar - x_ref) * scale.X;
                    // Funcao 1
                    {
                        var y = funcao(x);

                        if (!IsSafe(y))
                        { 
                            prev_y = null;
                        }
                        else
                        {
                            // find intersection f1 and f2
                            if (searching_below == null)
                            {
                                searching_below = y < funcao2(x);
                            }
                            else
                            {
                                if (y > funcao2(x) && searching_below.Value || y < funcao2(x) && !searching_below.Value)
                                {
                                    x_eq = x_a_desenhar;
                                    searching_below = !searching_below;
                                }
                            }

                            if (prev_y != null)
                            {
                                var y_a_desenhar = (int)(y_ref - y / scale.Y);
                                var prev_y_a_desenhar = (int)(y_ref - prev_y / scale.Y);

                                int? top = null;
                                int? height = null;
                                if (prev_y_a_desenhar < y_a_desenhar && y_a_desenhar > 0)
                                {
                                    top = prev_y_a_desenhar;
                                    height = Math.Max(y_a_desenhar - prev_y_a_desenhar, thickness);
                                }
                                else if (y_a_desenhar < prev_y_a_desenhar && prev_y_a_desenhar > -thickness)
                                {
                                    height = Math.Max(prev_y_a_desenhar - y_a_desenhar, thickness);
                                    top = prev_y_a_desenhar - height + thickness;
                                }
                                else if (y_a_desenhar == prev_y_a_desenhar && prev_y_a_desenhar < canvas_height)
                                {
                                    top = prev_y_a_desenhar;
                                    height = thickness;
                                }

                                if (height != null && (top > 0 || top + height.Value < canvas_height))
                                    canvas.FillRectangle(fun_brush, x_a_desenhar, top.Value, thickness, height.Value);
                            }

                            prev_y = y;
                        }
                    }

                    // Funcao 2
                    {
                        var y = funcao2(x);
                        var y_a_desenhar = (y_ref - y / scale.Y);
                        if (y_a_desenhar >= 0 && y_a_desenhar < canvas_height)
                            canvas.FillRectangle(fun2_brush, x_a_desenhar, (int)y_a_desenhar, thickness, thickness);
                    }
                }

                if (x_eq != null)
                {
                    var eq_brush = new SolidBrush(Color.BlueViolet);
                    canvas.FillRectangle(eq_brush, x_eq.Value, 0, thickness, canvas_height);
                    eq_brush.Dispose();
                }
            */
