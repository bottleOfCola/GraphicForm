using System.Text.RegularExpressions;

namespace GraphicForm
{
    public partial class Form1 : Form
    {
        bool _firstLook = true;
        Graphics _graphic;
        int _max;
        int _size = 20;
        int _offset;

        MyPoint[] XandY;
        Point[] gr;

        double _a;
        double _b = 0;
        double _c;
        double _sloj;

        Pen redPen = new Pen(Color.Red, 0.001f);
        Pen _pen = new Pen(Color.Black, 0.1f);

        int _indx;
        public Form1()
        {
            InitializeComponent();

            _max = graphica.Size.Width;
            _offset = _max / _size;
            _graphic = graphica.CreateGraphics();
            XandY = new MyPoint[_max];
            gr = new Point[XandY.Length];

            go.Click += Painter;
            a1.Click += A1;
            a2.Click += A2;
            a3.Click += A3;
            a4.Click += A4;
            a5.Click += A5;
            a6.Click += A6;
            a7.Click += A7;
            a8.Click += A8;


            this.MouseEnter += Morning;

            a.Enabled = false;
            na.Enabled = false;
            a.Visible = false;
            na.Visible = false;

            b.Enabled = false;
            nb.Enabled = false;
            b.Visible = false;
            nb.Visible = false;

            c.Enabled = false;
            nc.Enabled = false;
            c.Visible = false;
            nc.Visible = false;

        }

        private void Morning(object? sender, EventArgs e)
        {
            if(_firstLook==true)
            {
                StartGRFC();
                _firstLook=false;
            }
        }

        private void Enabler(bool la, bool lb, bool lc)
        {
            if (la)
            {
                a.Enabled = true;
                na.Enabled = true;
                na.Visible = true;
                a.Visible = true;
            }
            else
            {
                a.Enabled = false;
                na.Enabled = false;
                a.Visible = false;
                na.Visible = false;
            }
            if (lb)
            {
                b.Enabled = true;
                nb.Enabled = true;
                b.Visible = true;
                nb.Visible = true;
            }
            else
            {
                b.Enabled = false;
                nb.Enabled = false;
                b.Visible = false;
                nb.Visible = false;
                _b = 0;
            }
            if (lc)
            {
                c.Enabled = true;
                nc.Enabled = true;
                c.Visible = true;
                nc.Visible = true;
            }
            else
            {
                c.Enabled = false;
                nc.Enabled = false;
                c.Visible = false;
                nc.Visible = false;
            }
        }

        private void StartGRFC()
        {
            _graphic.Clear(Color.White);

            int XY = _max / 2 + 11;
            int YX = _max / 2 - 10;
            int[] _Xs = new int[_size-1];
            int[] _Ys = new int[_size-1];
            int XtoX = _max - 1;
            _graphic.DrawLine(_pen, new Point(0, _max / 2), new Point(_max, _max / 2));
            _graphic.DrawLine(_pen, new Point(_max / 2, 0), new Point(_max / 2, _max));
            _graphic.DrawLine(_pen, new Point(_max / 2 - 10, XtoX), new Point(XY, XtoX));
            _graphic.DrawLine(_pen, new Point(XtoX, YX), new Point(XtoX, XY));
            for (int i = 0; i < _Xs.Length; i++)
            {
                _Xs[i] = i - _Xs.Length / 2;
                _Ys[i] = (i - _Xs.Length / 2) *-1;
            }
            for (int i = 0; i < _size + 1; i++)
            {
                _graphic.DrawLine(_pen, new Point(i * _offset, YX), new Point(i * _offset, XY));
                _graphic.DrawLine(_pen, new Point(YX, i * _offset), new Point(XY, i * _offset));
            }
            int j = 1;
            foreach (int x in _Xs)
            {
                int ll = 20;
                if (j > 0)
                    ll = 10;
                _graphic.DrawString(
                    x.ToString(),
                    new Font("Arial", 16),
                    new SolidBrush(Color.Black),
                    new PointF(j * _offset - ll, XY)
                    );
                j++;
            }
            j = 1;
            foreach(int y in _Ys)
            {
                int ll = 20;
                if (j > 0)
                    ll = 10;
                _graphic.DrawString(
                        (y+_sloj).ToString(),
                    new Font("Arial", 16),
                    new SolidBrush(Color.Black),
                    new PointF(XY, j * _offset - ll)
                    );
                j++;
            }
        }

        private void Painter(object? sender, EventArgs e)
        {
            try
            {
                if (na.Text != "")
                    _a = double.Parse(na.Text);
                if (nb.Text != "")
                    _b = double.Parse(nb.Text);
                if (nc.Text != "")
                    _c = double.Parse(nc.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Вы неправильно ввели как(ое/ие)-то число.\nЕсли вы хотели ввести дробь - используйте запятую вместо точки");
                return;
            }
            _sloj = 0;
            switch (_indx)
            {
                case 1:
                    B1();
                    break;
                case 2:
                    B2();
                    break;
                case 3:
                    B3();
                    break;
                case 4:
                    B4();
                    break;
                case 5:
                    B5();
                    break;
                case 6:
                    B6();
                    break;
                case 7:
                    B7();
                    break;
                case 8:
                    B8();
                    break;
                default:
                    return;
            }
            Malare();
        }
        private void Malare()
        {
            StartGRFC();
            int up = -200;
            int down = graphica.Size.Height + 200;
            for(int i = 0; i<gr.Length; i++)
            {
                int X = (int)Math.Round(XandY[i].X * _offset) + _max/2;
                int Y = _max/2 - (int)Math.Round(XandY[i].Y * _offset);
                if (Y < 0)
                    Y = up;
                else if (Y > _max)
                    Y = down;
                if (X < 0)
                    X = up;
                else if(X > _max)
                    X = down;
                gr[i] = new Point(X, Y);
            }
            _graphic.DrawLines(redPen, gr);
        }
        private void Zero()
        {
            na.Text = "0";
            nb.Text = "0";
            nc.Text = "0";
        }
        private void B1()
        {
            if (_b >= 10)
            {
                _sloj = _b;
                _b = 0;
            }
            for (int i = 0; i < XandY.Length; i++)
            {
                double X = ((double)i/(double)_offset) - _size / 2;
                double Y = (X * _a + _b);
                XandY[i] = new MyPoint(X,Y);
            }
        }
        private void B2()
        {
            if (_c >= 10)
            {
                _sloj = _c;
                _c = 0;
            }
            for (int i = 0; i < XandY.Length; i++)
            {
                double X = ((double)i/(double)_offset) - _size / 2;
                double Y = _a * Math.Sin(X * _b) + _c;
                XandY[i] = new MyPoint(X, Y);
            }
        }
        private void B3()
        {
            for (int i = 0; i < XandY.Length; i++)
            {
                double X = ((double)i/(double)_offset) - _size / 2;
                double Y = _a * Math.Cos(X * _b + _c);
                XandY[i] = new MyPoint(X, Y);
            }
        }
        private void B4()
        {
            if (_c >= 10)
            {
                _sloj = _c;
                _c = 0;
            }
            for (int i = 0; i < XandY.Length; i++)
            {
                double X = ((double)i/(double)_offset) - _size / 2;
                double Y = _a * Math.Tan(X * _b) + _c;
                XandY[i] = new MyPoint(X, Y);
            }
        }
        private void B5()
        {
            for (int i = 0; i < XandY.Length; i++)
            {
                double X = ((double)i/(double)_offset) - _size / 2;
                double Y = _a * 1 / Math.Tan(X * _b + _c);
                XandY[i] = new MyPoint(X, Y);
            }
        }
        private void B6()
        {
            for (int i = 0; i < XandY.Length; i++)
            {
                double X = ((double)i/(double)_offset) - _size / 2;
                double Y = _b * Math.Pow(X, _a);
                XandY[i] = new MyPoint(X, Y);
            }
        }
        private void B7()
        {
            for (int i = 0; i < XandY.Length; i++)
            {
                double X = ((double)i/(double)_offset) - _size / 2;
                double Y = Math.Pow(_a, X + _b);
                XandY[i] = new MyPoint(X, Y);
            }
        }
        private void B8()
        {
            for (int i = 0; i < XandY.Length; i++)
            {
                double X = ((double)i/(double)_offset) - _size / 2;
                double first = Math.Sin(X) + (_a * X);
                double second = (X - Math.Pow(X, 0.5)) + 1;
                double Y = Math.Pow(first / second, _b / X);
                XandY[i] = new MyPoint(X, Y);
            }
        }

        private void A1(object? sender, EventArgs e)
        {
            _indx = 1;
            Zero();
            Enabler(true, true, false);
        }

        private void A2(object? sender, EventArgs e)
        {
            _indx = 2;
            Zero();
            Enabler(true, true, true);
        }

        private void A3(object? sender, EventArgs e)
        {
            _indx = 3;
            Zero();
            Enabler(true, true, true);
        }

        private void A4(object? sender, EventArgs e)
        {
            _indx = 4;
            Zero();
            Enabler(true, true, true);
        }

        private void A5(object? sender, EventArgs e)
        {
            _indx = 5;
            Zero();
            Enabler(true, true, true);
        }

        private void A6(object? sender, EventArgs e)
        {
            _indx = 6;
            Zero();
            Enabler(true, true, false);
        }

        private void A7(object? sender, EventArgs e)
        {
            _indx = 7;
            Zero();
            Enabler(true, true, false);
        }

        private void A8(object? sender, EventArgs e)
        {
            _indx = 8;
            Zero();
            Enabler(true, true, false);
        }
    }
    public class MyPoint
    {
        private double _x;
        public double X
        {
            get { return _x; }
        }

        private double _y;
        public double Y
        {
            get { return _y; }
        }

        public MyPoint(double x, double y)
        {
            _x = x;
            _y = y;
        }
    }
}