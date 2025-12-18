using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace labwork36
{
    public partial class Form1 : Form
    {
        private Rectangle ball;
        private Rectangle paddle;
        private List<Brick> bricks;

        // Скорость мяча
        private int ballSpeedX = 4;
        private int ballSpeedY = -4;

        // Флаги состояния
        private bool gameStarted = false;
        private bool gamePaused = false;
        private bool victory = false;

        // Таймер
        private Timer gameTimer;

        // Шрифт для сообщений
        private Font messageFont;



        public Form1()
        {
            InitializeComponent();
            InitializeGame();

            this.MouseMove += Form1_MouseMove;
        }

        private void InitializeGame()
        {

            this.Text = "Арканоид";
            this.ClientSize = new Size(800, 600);
            this.DoubleBuffered = true;
            this.KeyPreview = true;


            gameTimer = new Timer();
            gameTimer.Interval = 16; 
            gameTimer.Tick += GameTimer_Tick;
            gameTimer.Start();


            messageFont = new Font("Arial", 24, FontStyle.Bold);


            ball = new Rectangle(ClientSize.Width / 2 - 10, 200, 20, 20);


            paddle = new Rectangle(ClientSize.Width / 2 - 50, ClientSize.Height - 40, 100, 15);


            bricks = new List<Brick>();
            int rows = 4, cols = 10;
            int spacing = 6;
            int brickWidth = (ClientSize.Width - (cols + 1) * spacing) / cols;
            int brickHeight = 30;
            int topOffset = 50;

            Color[] rowColors = { Color.White, Color.Blue, Color.Red, Color.Gray };

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    int x = col * (brickWidth + spacing) + spacing;
                    int y = row * (brickHeight + spacing) + topOffset;
                    bricks.Add(new Brick(new Rectangle(x, y, brickWidth, brickHeight), rowColors[row]));
                }
                stars = new List<Star>();
                Random rand = new Random();
                for (int i = 0; i < 100; i++)
                {
                    stars.Add(new Star
                    {
                        X = rand.Next(ClientSize.Width),
                        Y = rand.Next(ClientSize.Height),
                        Size = rand.Next(1, 3),
                        Brightness = (byte)rand.Next(100, 255)
                    });
                }
            }
        }


        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
          
            // Двигаем ракетку
            int newX = e.X - paddle.Width / 2;
            paddle.X = Math.Max(0, Math.Min(ClientSize.Width - paddle.Width, newX));
            this.Invalidate();
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            if (!gameStarted || gamePaused)
                return;

            // Двигаем мяч
            ball.X += ballSpeedX;
            ball.Y += ballSpeedY;

            // Отскок от левой и правой стен
            if (ball.X <= 0 || ball.X + ball.Width >= ClientSize.Width)
                ballSpeedX = -ballSpeedX;

            // Отскок от верхней стены
            if (ball.Y <= 0)
                ballSpeedY = -ballSpeedY;

            // Отскок от ракетки
            if (ball.IntersectsWith(paddle))
                ballSpeedY = -Math.Abs(ballSpeedY); // строго вверх

            // Потеря мяча (нижняя граница)
            if (ball.Y > ClientSize.Height)
            {
                // Сброс мяча над ракеткой
                ball.X = paddle.X + paddle.Width / 2 - ball.Width / 2;
                ball.Y = paddle.Y - ball.Height;
                ballSpeedX = 0;
                ballSpeedY = 0;
                gameStarted = false; // ждём пробел
            }

            // Проверка столкновений с кирпичами
            CheckBrickCollisions();

            // Проверка победы
            CheckVictory();

            // Перерисовка
            this.Invalidate();


            Random rand = new Random();
            foreach (var star in stars)
            {
                star.Brightness = (byte)(150 + rand.Next(0, 100)); // мерцание
            }
            this.Invalidate();
        }
        private void CheckBrickCollisions()
        {
            for (int i = bricks.Count - 1; i >= 0; i--)
            {
                Brick brick = bricks[i];
                if (brick.IsActive && ball.IntersectsWith(brick.Rect))
                {
                    brick.IsActive = false;
                    ballSpeedY = -ballSpeedY; // отскок
                    break; // только один кирпич за раз
                }
            }
        }
        private void CheckVictory()
        {
            if (bricks.All(b => !b.IsActive))
            {
                victory = true;
                gameStarted = false;
                gameTimer.Stop();
                this.Invalidate(); // перерисовать с сообщением
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                if (!gameStarted)
                {
                    // Запуск игры
                    ballSpeedX = 4;
                    ballSpeedY = -4;
                    gameStarted = true;
                    victory = false;
                }
                else
                {
                    // Пауза/продолжение
                    gamePaused = !gamePaused;
                }

                // Обновляем таймер
                if (gamePaused)
                    gameTimer.Stop();
                else
                    gameTimer.Start();

                this.Invalidate();
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            
            using (LinearGradientBrush brush = new LinearGradientBrush(
       this.ClientRectangle,
       Color.FromArgb(10, 5, 30),
       Color.FromArgb(20, 10, 60),
       90F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }

            // Звёзды
            foreach (var star in stars)
            {
                using (SolidBrush brush = new SolidBrush(Color.FromArgb(star.Brightness, Color.White)))
                {
                    e.Graphics.FillEllipse(brush, star.X, star.Y, star.Size, star.Size);
                }
            }

            
            base.OnPaint(e);

            // Заливка фона
            e.Graphics.FillRectangle(Brushes.Black, this.ClientRectangle);

            // Мяч
            e.Graphics.FillEllipse(Brushes.White, ball);

            // Ракетка
            e.Graphics.FillRectangle(Brushes.Cyan, paddle);

            // Кирпичи
            foreach (var brick in bricks)
            {
                if (brick.IsActive)
                {
                    e.Graphics.FillRectangle(new SolidBrush(brick.Color), brick.Rect);
                }
        
    }

            // Сообщение о победе
            if (victory)
            {
                string text = "ПОБЕДА!";
                SizeF textSize = e.Graphics.MeasureString(text, messageFont);
                PointF textPos = new PointF(
                    (ClientSize.Width - textSize.Width) / 2,
                    (ClientSize.Height - textSize.Height) / 2
                );
                e.Graphics.DrawString(text, messageFont, Brushes.Gold, textPos);
            }

            // Сообщение о паузе
            if (gamePaused && !victory)
            {
                string text = "ПАУЗА";
                SizeF textSize = e.Graphics.MeasureString(text, messageFont);
                PointF textPos = new PointF(
                    (ClientSize.Width - textSize.Width) / 2,
                    (ClientSize.Height - textSize.Height) / 2
                );
                e.Graphics.DrawString(text, messageFont, Brushes.Gray, textPos);
            }
        }
            private List<Star> stars;

        public class Star
        {
            public int X { get; set; }
            public int Y { get; set; }
            public int Size { get; set; }
            public byte Brightness { get; set; }
        }
        
       
        }
    }
         
    
    









    


 