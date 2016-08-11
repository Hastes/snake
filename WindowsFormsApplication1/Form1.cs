using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    { 
        public int sz = 30;    // Размер клетки
        public int y;
        public static int razm = 15; // размер сетки
        //public int n = 30, nn = 30;
        public int x;
        public int speed = 1;
        public int[] mas = new int[razm];
        public int[] walls = new int[razm * razm]; // массив для стены с длинной 15х15 элементов
        public Direction btn = Direction.Down;  // направление
        private Eat eat;
        //  public List<Label> Snake = new List<Label>();
        // private LinkedList<Label> Snake = new LinkedList<Label>;
        private List<Segment> Snake = new List<Segment>();
        public Form1()
        {
            InitializeComponent(); 
            timer1.Interval = 1000 / speed;
            timer1.Tick += Tick;
            timer1.Start();
            FormClosing += new FormClosingEventHandler(Form1_FormClosing);

        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int n = 0;
            for (int i = 0; i < razm; i++)
            {
                mas[i] = n;
                n += 30;
            }
            Segment head = new Segment { X = 0, Y = sz};
            Snake.Add(head);
            Segment seg = new Segment { X = Snake[Snake.Count -1].X, Y = Snake[Snake.Count - 1].Y-30};
            Snake.Add(seg);
            Segment segg = new Segment { X = Snake[Snake.Count - 1].X, Y = Snake[Snake.Count - 1].Y-60 };
            Snake.Add(segg);
            ClientSize = new Size(sz * 16, sz * 16);
            pictureBox1.Size = new Size { Height = sz * razm, Width = sz *razm };
            pictureBox1.Margin = new Padding { All = 3 };
            eat = new Eat { X = Rnd(), Y = Rnd() } ;
            Draw();
        }
        public int Rnd()
        {
            Random r = new Random();
            int count = r.Next(0, mas.Length);
            return mas[count];
        }
        private void Tick(object sender, EventArgs e)
        {

            Clear();
            if ((Input.KeyPressed(Keys.Right) || Input.KeyPressed(Keys.D)) && btn != Direction.Left)
                    btn = Direction.Right;
            else if ((Input.KeyPressed(Keys.Left) || Input.KeyPressed(Keys.A)) && btn != Direction.Right)
                    btn = Direction.Left;
              else  if ((Input.KeyPressed(Keys.Up) || Input.KeyPressed(Keys.W)) && btn != Direction.Down)
                    btn = Direction.Up;
               else if ((Input.KeyPressed(Keys.Down) || Input.KeyPressed(Keys.S)) && btn != Direction.Up)
                    btn = Direction.Down;
                if (Input.KeyPressed(Keys.Space))
                {
                        Clear();    
                        MoveSnake();
                         MoveSnake();
                    Snake.Remove(Snake[0]);
                }
                
            MoveSnake();
           
        }
        public void MoveSnake() {
            Draw_eat(); 
            bool b = true;
            for (int i = Snake.Count - 1; i >= 0; i--)
            {
                
                if (i == 0)
                {
                    switch (btn)
                    {
                        case Direction.Up:
                            Snake[i].Y = Snake[i].Y - sz;
                            break;
                        case Direction.Down:
                            Snake[i].Y = Snake[i].Y + sz;
                            break;
                        case Direction.Left:
                            Snake[i].X = Snake[i].X - sz;
                            break;
                        case Direction.Right:
                            Snake[i].X = Snake[i].X + sz;
                            break;
                        default:
                            break;
                    }
                    Draw();
                }
               
                else
                {
                   
                    if (Snake[0].X == eat.X && Snake[0].Y == eat.Y)
                    {
                        Snake.Add(new Segment { X = Snake[i - 1].X, Y = Snake[i - 1].Y });
                        eat.X = Rnd();
                        eat.Y = Rnd();
                        Draw();
                    }
                    if (Snake[0].X == Snake[i].X && Snake[0].Y == Snake[i].Y && b == true)
                    {
                        for (int j = i; j < Snake.Count-1; j++)
                        {
                            Snake.RemoveAt(j-1);
                            Clear();
                            Draw();
                        }
                        b = false;
                        
                    }
                    else
                    {
                        Snake[i].X = Snake[i - 1].X;
                        Snake[i].Y = Snake[i - 1].Y;
                    }
                    //int xx = Snake[i].X;
                    //  int yy = Snake[i].Y;
                }
                

            }
            if (Snake[0].X < 0) Snake[0].X = sz * 14;
            if (Snake[0].X > sz * 14) Snake[0].X = 0;
            if (Snake[0].Y < 0) Snake[0].Y = sz * 14;
            if (Snake[0].Y > sz * 14) Snake[0].Y = 0;
            Draw();
        }
        
        public void Draw()
        {
            var g = pictureBox1.CreateGraphics();
            //g.Clear(Color.White);
            for (int i = 0; i < Snake.Count; i++)
            {

                g.FillRectangle(new SolidBrush(Color.DeepSkyBlue), Snake[i].X, Snake[i].Y, sz, sz);
                g.DrawRectangle(new Pen(Color.Black), Snake[i].X, Snake[i].Y, sz, sz);
                if (i == 0)
                {
                    g.FillRectangle(new SolidBrush(Color.Black), Snake[i].X, Snake[i].Y, sz, sz);
                    g.FillRectangle(new SolidBrush(Color.White), Snake[i].X+5, Snake[i].Y+20, sz-25, sz-25);
                    g.FillRectangle(new SolidBrush(Color.White), Snake[i].X + 20, Snake[i].Y + 20, sz - 25, sz - 25);
                    g.DrawRectangle(new Pen(Color.Black), Snake[i].X, Snake[i].Y, sz, sz);
                    
                }
                

            }
            
        }
        public void Draw_eat()
        {
            var g = pictureBox1.CreateGraphics();
            g.FillEllipse(new SolidBrush(Color.DeepSkyBlue), eat.X, eat.Y, sz, sz);
            
           // g.DrawEllipse(new Pen(Color.Black), 0, 0, sz, sz);
        }
        public void Clear()
        {
            var g = pictureBox1.CreateGraphics();
            g.Clear(Color.WhiteSmoke);
        }
        class Segment
        {
            public int X { get; set; }
            public int Y { get; set; }
            public Segment()
            {
                X = 0;
                Y = 0;
            }
        }
        class Eat
        {
            public int X { get; set; }
            public int Y { get; set; }
            public Eat()
            {
                X = 0;
                Y = 0;
            }
        }


        public enum Direction
        {
            Up,
            Down,
            Left,
            Right
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, true);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, false);
        }
    }
}
