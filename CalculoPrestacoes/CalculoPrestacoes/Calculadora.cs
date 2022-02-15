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
        public double precision;
        public int min, max;

        public Calculadora(double p, double t, double v, double n, Variavel em_ordem, double precision, int min, int max)
        {
            this.p = p;
            this.t = t;
            this.v = v;
            this.n = n;
            this.em_ordem = em_ordem;
            this.precision = precision;
            this.min = min;
            this.max = max;
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
                        for (double x = min; x < max; x++)
                        {
                            var calculadora = new Calculadora(p, x * precision, v, n, Variavel.P, precision, min, max);
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
                                    if (y > p && searching_below.Value)
                                    {
                                        resultado = x * precision;
                                        searching_below = !searching_below;
                                    }
                                    if (y < p && !searching_below.Value)
                                    {
                                        resultado = x * precision;
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
                        for (double x = min; x < max; x++)
                        {
                            var calculadora = new Calculadora(p, t, v, x * precision, Variavel.P, precision, min, max);
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
                                        resultado = x * precision;
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

        public void DesenharGrafico(PictureBox pictureBox1, PointF scale, Point center, Variavel x_target, Variavel y_target, int div)
        {
            Func<double, double> funcao = (x) =>
            {
                Calculadora calculadora = null;
                switch (x_target)
                {
                    case Variavel.P:
                        calculadora = new Calculadora(x, t, v, n, y_target, precision, min, max);
                        break;
                    case Variavel.T:
                        calculadora = new Calculadora(p, x, v, n, y_target, precision, min, max);
                        break;
                    case Variavel.V:
                        calculadora = new Calculadora(p, t, x, n, y_target, precision, min, max);
                        break;
                    case Variavel.N:
                        calculadora = new Calculadora(p, t, v, x, y_target, precision, min, max);
                        break;
                }

                if (calculadora == null) return 0;
                return calculadora.Calcular();
            };

            Func<double, double> funcao2 = (x) =>
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
            var thickness = 2;

            var x_ref = center.X;
            var y_ref = center.Y;

            // Desenhar divs
            if (div > 0)
            {
                for (int i = 0; i < (canvas_height - y_ref) * scale.Y / div; i++)
                {
                    var y = div / scale.Y * i;
                    canvas.FillRectangle(sub_ref_brush, 0, y + y_ref, canvas_width, 1);
                }
                for (int i = 0; i < y_ref * scale.Y / div; i++)
                {
                    var y = div / scale.Y * i;
                    canvas.FillRectangle(sub_ref_brush, 0, y_ref - y, canvas_width, 1);
                }

                for (int i = 0; i < (canvas_width - x_ref) * scale.X / div; i++)
                {
                    var x = div / scale.X * i;
                    canvas.FillRectangle(sub_ref_brush, x + x_ref, 0, 1, canvas_height);
                }
                for (int i = 0; i < x_ref * scale.X / div; i++)
                {
                    var x = div / scale.X * i;
                    canvas.FillRectangle(sub_ref_brush, x_ref - x, 0, 1, canvas_height);
                }
            }

            canvas.FillRectangle(ref_brush, 0, y_ref, canvas_width, thickness);
            canvas.FillRectangle(ref_brush, x_ref, 0, thickness, canvas_height);

            var fun_brush = new SolidBrush(Color.Red);
            var fun2_brush = new SolidBrush(Color.Green);
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
            fun_brush.Dispose();
            fun2_brush.Dispose();

            if (x_eq != null)
            {
                var eq_brush = new SolidBrush(Color.BlueViolet);
                canvas.FillRectangle(eq_brush, x_eq.Value, 0, thickness, canvas_height);
                eq_brush.Dispose();
            }

            canvas.Dispose();
            ref_brush.Dispose();
            sub_ref_brush.Dispose();
            pictureBox1.Image = imagem;
        }
    }
}
