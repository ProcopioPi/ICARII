using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace MasterHound
{
    public class LoadAnimation
    {
        public static bool IsRunning;
        static Bitmap bmp;
        static int flag;
        static Brush stringBrush;
        static Font font;
        static PointF pf;
        static Size size;                   /// 
        static Pen pen, mainPen;            /// pen colors used in the animation
        static int offset, offsetSize;      /// the inner markers to create the animation
        static LoadAnimation instance;      /// the class instance to create a singleton        
                                            /// 
        public static LoadAnimation Instance
        {
            get
            {
                if (instance == null)
                    instance = new LoadAnimation(K.ANIMATION_SIZE, K.ANIMATION_SIZE);

                return LoadAnimation.instance;
            }
            set { LoadAnimation.instance = value; }
        }

        public LoadAnimation(int width, int height)
        {
            Init(width, height);
        }

        private static void Init(int width, int height)
        {
            IsRunning   = true;
            size        = new Size(width, height);

            pen         = new Pen(new SolidBrush(Color.LightGray), 10);
            mainPen     = new Pen(new SolidBrush(Color.DimGray), 1);

            pen.DashCap     = System.Drawing.Drawing2D.DashCap.Round;
            pen.StartCap    = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap      = System.Drawing.Drawing2D.LineCap.Round;

            offset      = 5;
            offsetSize  = 13;

            pf          = new PointF(16, 17);
            font        = new Font("Times New Roman", 11f, FontStyle.Italic);
            bmp         = new Bitmap(width, height);
            stringBrush = new SolidBrush(Color.DimGray);//WhiteSmoke
        }

        public Bitmap AnimateLoadingIndexes()
        {
            Graphics.FromImage(bmp).Clear(Color.Transparent);

            Graphics.FromImage(bmp).FillEllipse(Brushes.LightGray, 0, 0, size.Width, size.Height);

            Graphics.FromImage(bmp).DrawArc(pen, offset, offset, size.Width - offsetSize, size.Height - offsetSize, 0, 360);
            Graphics.FromImage(bmp).DrawArc(pen, offset, offset, size.Width - offsetSize, size.Height - offsetSize, 0, 360);

            Graphics.FromImage(bmp).DrawArc(pen, offset, offset, size.Width - offsetSize, size.Height - offsetSize, (flag++), -280);
            Graphics.FromImage(bmp).DrawArc(pen, offset, offset, size.Width - offsetSize, size.Height - offsetSize, (flag++), -250);
            Graphics.FromImage(bmp).DrawArc(pen, offset, offset, size.Width - offsetSize, size.Height - offsetSize, (flag++), -220);
            Graphics.FromImage(bmp).DrawArc(pen, offset, offset, size.Width - offsetSize, size.Height - offsetSize, (flag++), -190);
            Graphics.FromImage(bmp).DrawArc(pen, offset, offset, size.Width - offsetSize, size.Height - offsetSize, (flag++), -160);

            Graphics.FromImage(bmp).DrawArc(mainPen, offset - 5, offset - 5, size.Width - offsetSize + 9, size.Height - offsetSize + 9, 0, 360);
            Graphics.FromImage(bmp).DrawArc(mainPen, offset + 5, offset + 5, size.Width - offsetSize - 9, size.Height - offsetSize - 9, 0, 360);
      
            pf.X = 12;

            Graphics.FromImage(bmp).DrawString("IDx", font, stringBrush, 15, 17);

            return new Bitmap(bmp);
        }

        /// <summary>
        /// Updates the donwloading articles
        /// </summary>
        /// <param name="frame">the article number to display in the frame</param>
        /// <returns>the next image frame of the animation</returns>
        public Bitmap AnimateLoadingNextFrame(int frame)
        {
            Graphics.FromImage(bmp).Clear(Color.Transparent);

            Graphics.FromImage(bmp).DrawArc(pen, offset, offset, size.Width - offsetSize, size.Height - offsetSize, 0, 360);
            Graphics.FromImage(bmp).DrawArc(pen, offset, offset, size.Width - offsetSize, size.Height - offsetSize, 0, 360);

            Graphics.FromImage(bmp).DrawArc(pen, offset, offset, size.Width - offsetSize, size.Height - offsetSize, (flag++), -280);
            Graphics.FromImage(bmp).DrawArc(pen, offset, offset, size.Width - offsetSize, size.Height - offsetSize, (flag++), -250);
            Graphics.FromImage(bmp).DrawArc(pen, offset, offset, size.Width - offsetSize, size.Height - offsetSize, (flag++), -220);
            Graphics.FromImage(bmp).DrawArc(pen, offset, offset, size.Width - offsetSize, size.Height - offsetSize, (flag++), -190);
            Graphics.FromImage(bmp).DrawArc(pen, offset, offset, size.Width - offsetSize, size.Height - offsetSize, (flag++), -160);

            Graphics.FromImage(bmp).DrawArc(mainPen, offset - 5, offset - 5, size.Width - offsetSize + 9, size.Height - offsetSize + 9, 0, 360);
            Graphics.FromImage(bmp).DrawArc(mainPen, offset + 5, offset + 5, size.Width - offsetSize - 9, size.Height - offsetSize - 9, 0, 360);
            frame++;

            if (frame < 10)
            {
                pf.X = 19;
                Graphics.FromImage(bmp).DrawString(frame.ToString(), font, stringBrush, pf);
            }
            else
            {
                if (frame < 100)
                {
                    pf.X = 15;
                    Graphics.FromImage(bmp).DrawString(frame.ToString(), font, stringBrush, pf);
                }
                else
                {
                    pf.X = 12;
                    Graphics.FromImage(bmp).DrawString(frame.ToString(), font, stringBrush, pf);
                }
            }
            flag += 5;
            return new Bitmap(bmp);
        }

        /// <summary>
        /// Resets the animation frames and parameters
        /// </summary>
        /// <returns>the last frame of the animation to clean the picturebox</returns>
        public Bitmap FinishAnimation()
        {
            flag = 0;
            IsRunning = true;
            Graphics.FromImage(bmp).Clear(Color.Transparent);
            return new Bitmap(bmp);
        }

    }
}
