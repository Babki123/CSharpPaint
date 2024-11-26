using System.ComponentModel;

namespace MatchingSymbol
{
    public partial class Form1 : Form
    {

        Color BrushColor;
        Point BrushArea;
        Bitmap Picture;
        bool MouseDown;
        // Pen ColoredPen;
        System.Drawing.Drawing2D.GraphicsPath mousePath;
        SolidBrush Brush;
        Rectangle Rect;
        bool RectOn;
        int BrushSize;
        int prevX, prevY;
        double pointDiff;



        public Form1()
        {
            InitializeComponent();
            Picture = new Bitmap(DrawingArea.Width, DrawingArea.Height);
            mousePath = new System.Drawing.Drawing2D.GraphicsPath();
            Brush = new SolidBrush(Color.White);
            Rect = new Rectangle();
            RectOn = true;
            BrushSize = 1;

        }

        private void OnClickColor(object sender, EventArgs e)
        {
           /* Console.WriteLine(string.Format("X: {0} , Y: {1}", MousePosition.X, MousePosition.Y));
            Console.WriteLine(string.Format(" Height {0} , width {1}", Picture.Width, Picture.Height));
            Console.WriteLine(string.Format(" Height {0} , width {1}", MousePosition.X - DrawingArea.Right, MousePosition.Y - DrawingArea.Bottom));*/
            // Console.WriteLine(DrawingArea.PointToClient(Cursor.Position));
            //BrushArea = DrawingArea.PointToClient(Cursor.Position);
            MouseDown = true;
            //DrawingArea.BackColor = BrushColor;
            BrushArea = DrawingArea.PointToClient(Cursor.Position);
            Console.WriteLine(BrushArea);
            Picture.SetPixel(BrushArea.X, BrushArea.Y, BrushColor);
            Console.WriteLine(Picture.GetPixel(BrushArea.X, BrushArea.Y));
            DrawingArea.Image = Picture;
        }
        private void OnMouseMove(object sender, EventArgs e)
        {
            prevX = BrushArea.X;
            prevY = BrushArea.Y;
            if (MouseDown && !RectOn)
            {
               
                
             
                
                BrushArea = DrawingArea.PointToClient(Cursor.Position);
                Console.WriteLine(BrushArea);
                try
                {
                    //calc de la difference absolue entre les deux point (b-a)/2
                    pointDiff = Math.Sqrt((BrushArea.X - prevX)^2 + (BrushArea.Y - prevY)^2);
                    //dessin de tous les points entre les deux element
                    BrushArea = DrawingArea.PointToClient(Cursor.Position);
                    Rect.Height = BrushSize;
                    Rect.Width = BrushSize;
                    Rect.X = BrushArea.X - (Rect.Width / 2);
                    Rect.Y = BrushArea.Y - (Rect.Height / 2);
                    Brush.Color = BrushColor;
                    Graphics.FromImage(Picture).FillRectangle(Brush, Rect);
                    Console.WriteLine(Picture.GetPixel(BrushArea.X, BrushArea.Y));
                }
                catch (Exception Exception)
                {
                    Console.WriteLine(Exception);
                }

                DrawingArea.Image = Picture;

            }
            if (MouseDown && RectOn) {

                //calc de la difference absolue entre les deux point (b-a)/2
                pointDiff = Math.Sqrt((BrushArea.X - prevX) ^ 2 + (BrushArea.Y - prevY) ^ 2);
                //dessin de tous les points entre les deux element
              
                    
                        BrushArea = DrawingArea.PointToClient(Cursor.Position);
                        Rect.Height = BrushSize;
                        Rect.Width = BrushSize;
                        Rect.X = BrushArea.X - (Rect.Width / 2);
                        Rect.Y = BrushArea.Y - (Rect.Height / 2);
                        Brush.Color = BrushColor;
                        Graphics.FromImage(Picture).FillRectangle(Brush, Rect);

                /*for (int i = prevX, y=prevY; i <= BrushArea.X && y<= BrushArea.Y; i++)
                {
                    Rect.X = i - (Rect.Width / 2);
                    Rect.Y = y - (Rect.Height / 2);


                    Graphics.FromImage(Picture).FillRectangle(Brush, Rect);
                }*/
                DrawInBetween();
                DrawingArea.Image = Picture;
                                    
            
            }

        }
        
        private void DrawInBetween()
        {
            int a;
            // Dessine les point entre deux lorsque la souris se deplace plus viteq que le rendu 
            //PRemier essai K.O , X et Y doivent être changer en même temps 
            /*  if(prevX < BrushArea.X && prevY <= BrushArea.Y)
              {
                  for (int i = prevX, y = prevY; i <= BrushArea.X && y <= BrushArea.Y; i++;)
                  {
                      Console.WriteLine(String.Format(" bigger X and i={0} ,BAX = {1} , y={2}, BAY = {3} ",i,BrushArea.X,y,BrushArea.Y));

                      Rect.X = i - (Rect.Width / 2);
                      Rect.Y = y - (Rect.Height / 2);


                      Graphics.FromImage(Picture).FillRectangle(Brush, Rect);
                  }
              }*/

            if (prevX < BrushArea.X && prevY <= BrushArea.Y )
            {
                // Determiner la droite crée entre les deux points
                // determiner la pente: 
                if(BrushArea.X - prevX == 0)
                {
                    a = 0;
                }
                else
                {
                    a = (int)(BrushArea.Y - prevY) / (BrushArea.X - prevX);
                }
                 
                int b = prevY - prevX * a;
                for (int i = prevX;  i <= BrushArea.X ; i++)
                {
                    for (int y = prevY; y <= BrushArea.Y; y++)
                    {


                        //Console.WriteLine(String.Format(" bigger X and i={0} ,BAX = {1} , y={2}, BAY = {3} ", i, BrushArea.X, y, BrushArea.Y));
                        if(y == a * i + b)
                        {
                            if(a == 0 || b == 0)
                            {
                                Console.WriteLine("TRUE");
                                Console.WriteLine(String.Format(" bigger X and i={0} ,BAX = {1} , y={2}, BAY = {3} ", i, BrushArea.X, y, BrushArea.Y));
                            }

                            Rect.X = i - (Rect.Width / 2);
                            Rect.Y = y - (Rect.Height / 2);

                            Graphics.FromImage(Picture).FillRectangle(Brush, Rect);
                        }
                      
                    }
                    
                }
            }
       

            
        }
        private void OnMouseUp(object sender, EventArgs e)
        {
            MouseDown = false;
        }
        private void OnClickCross(object sender, EventArgs e)
        {
            int PixX = Picture.Width / 2, PixY = Picture.Height / 2;

            while (Picture.GetPixel(PixY, PixY) == BrushColor)
            {
                PixX++;
                PixY++;
            }

            for (int x = PixX; x < Picture.Width; x++)
            {
                for (int y = PixY; y < Picture.Height; y++)
                {
                    Picture.SetPixel(x, PixY, BrushColor);
                    Picture.SetPixel(Picture.Width - x, PixY, BrushColor);
                    Picture.SetPixel(PixX, y, BrushColor);
                    Picture.SetPixel(PixX, Picture.Height - y, BrushColor);

                    Console.WriteLine(BrushColor);
                }


            }
            DrawingArea.Image = Picture;
        }


        private void SetBrushColor(object sender, EventArgs e)
        {
            BrushColor = (sender as Button).BackColor;
            Console.WriteLine(BrushColor.ToString());
            Brush.Color = BrushColor;
        }

        private void DrawSizeUp_Click(object sender, EventArgs e)
        {
            int tempVal = Int32.Parse(BrushSizeDisplay.Text);
            if(tempVal < 99)
            {
                tempVal++;
                BrushSize = tempVal;
            }
            
            BrushSizeDisplay.Text = String.Format("{0}", tempVal);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int tempVal = Int32.Parse(BrushSizeDisplay.Text);
            if(tempVal > 0)
            {
                tempVal--;
                BrushSize = tempVal;
            }
            
            BrushSizeDisplay.Text = String.Format("{0}", tempVal);
        }
    }
}
