using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace drawing
{


    public partial class FormDrawing : Form
    {
        public FormDrawing()
        {
            InitializeComponent();
            pictureBox1.Image = new Bitmap(1, 1);
        }

        private void GenerateB_Click(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            var G = Graphics.FromImage(img);
            int size = Math.Min(pictureBox1.Width, pictureBox1.Height);
            G.Clear(Color.White);

            //Draw All

            double multiple = size * 0.8 / val.all_diameter;
            val.multiple = multiple;

            G.DrawEllipse(new Pen(Color.Black, 4), val.GetRec(size / 2, size / 2, size * 0.8));
            G.DrawLine(new Pen(Color.Gray, 1.5f), size / 2, size / 2,
                size / 2 + (float)val.all_diameter * (float)multiple / 2 * (float)Math.Cos(0.75f * val.pi),
                size / 2 - (float)val.all_diameter * (float)multiple / 2 * (float)Math.Sin(0.75f * val.pi));
            G.DrawString("r = " + Math.Round((val.all_diameter / 2), 2).ToString(),
                new Font("宋体", 10), new SolidBrush(Color.Black),
                size / 2 + (float)val.all_diameter * (float)multiple / 2 * (float)Math.Cos(0.75f * val.pi) * 0.75f,
                (float)(size / 2 - (float)val.all_diameter * (float)multiple / 2 * (float)Math.Sin(0.75f * val.pi) * 0.75f - size * 0.01));

            //Draw bottom

            G.DrawEllipse(new Pen(Color.FromArgb(255, 192, 0), 3), val.GetRec(size / 2, size / 2 - val.bottom_radius, val.normal_hole_diameter));
            G.DrawEllipse(new Pen(Color.FromArgb(255, 192, 0), 3), val.GetRec(size / 2, size / 2 + val.bottom_radius, val.normal_hole_diameter));

            G.DrawLine(new Pen(Color.Gray, 1.5f), size / 2, size / 2, size / 2, (float)(size / 2 - val.bottom_radius));
            G.DrawString("r = " + Math.Round((val.bottom_radius / multiple), 2).ToString(),
                new Font("宋体", 10), new SolidBrush(Color.Black),
                size / 2, (float)(size / 2 - val.bottom_radius / 2 - size * 0.007));

            //Draw connect

            for (int i = -1; i <= 1; i += 2)
                for (int j = -1; j <= 1; j += 2)
                {
                    G.DrawEllipse(new Pen(Color.Red, 3), val.GetRec(size / 2 + i * val.connect_radius, size / 2 + j * val.connect_radius, val.normal_hole_diameter));
                }

            G.DrawLine(new Pen(Color.Gray, 1.5f), size / 2, size / 2, size / 2 + 1 * (float)val.connect_radius, size / 2 + 1 * (float)val.connect_radius);
            G.DrawString("r = " + Math.Round((val.connect_radius / multiple), 2).ToString(),
                new Font("宋体", 10), new SolidBrush(Color.Black),
                size / 2 + 0.5f * (float)val.connect_radius, (float)(size / 2 + 0.5f * (float)val.connect_radius - size * 0.01));

            //Draw wire

            for (int i = 0; i < 4; i++)
            {
                G.DrawEllipse(new Pen(Color.Green, 3),
                    val.GetRec(size / 2 + val.wire_radius * Math.Cos(val.pi / 2 * i),
                    size / 2 + val.wire_radius * Math.Sin(val.pi / 2 * i),
                    val.wire_hole_diameter));
            }

            G.DrawLine(new Pen(Color.Gray, 1.5f), size / 2, size / 2, size / 2 + (float)val.wire_radius, size / 2);
            G.DrawString("r = " + Math.Round((val.wire_radius / multiple), 2).ToString(),
                new Font("宋体", 10), new SolidBrush(Color.Black),
                (float)(size / 2 + 0.5f * val.wire_radius), (float)(size / 2 - size * 0.02));

            //Draw Camera

            for (int i = 0; i < val.hole_count; i++)
            {
                G.DrawEllipse(new Pen(Color.Blue, 3),
                    val.GetRec(size / 2 + val.camera_radius * Math.Cos(val.pi * 2 / val.hole_count * i),
                    size / 2 + val.camera_radius * Math.Sin(val.pi * 2 / val.hole_count * i),
                    val.normal_hole_diameter));
            }

            G.DrawLine(new Pen(Color.Gray, 1.5f), size / 2, size / 2,
                (float)(size / 2 + val.camera_radius * Math.Cos(val.pi * 2 / val.hole_count * 1)),
                (float)(size / 2 + val.camera_radius * Math.Sin(val.pi * 2 / val.hole_count * 1)));
            G.DrawString("r = " + Math.Round((val.camera_radius / multiple), 2).ToString(),
                new Font("宋体", 10), new SolidBrush(Color.Black),
                (float)(size / 2 + 0.5f * val.camera_radius * Math.Cos(val.pi * 2 / val.hole_count * 1)),
                (float)(size / 2 + 0.5f * val.camera_radius * Math.Sin(val.pi * 2 / val.hole_count * 1) - size * 0.01));


            //2 extra dia
            //wire
            G.DrawLine(new Pen(Color.Gray, 1.5f),
                (float)(size / 2 - val.wire_radius - val.wire_hole_diameter / 2),
                size / 2,
                (float)(size / 2 - val.wire_radius + val.wire_hole_diameter / 2),
                size / 2);
            G.DrawString("d = " + Math.Round((val.wire_hole_diameter / multiple), 2).ToString(),
                new Font("宋体", 10), new SolidBrush(Color.Black),
                (float)(size / 2 - val.wire_radius - size * 0.02),
                (float)(size / 2 - size * 0.02));

            //normal_hole
            G.DrawLine(new Pen(Color.Gray, 1.5f),
                (float)(size / 2 + val.camera_radius * Math.Cos(val.pi * 2 / val.hole_count * 2) - val.normal_hole_diameter / 2),
                (float)(size / 2 + val.camera_radius * Math.Sin(val.pi * 2 / val.hole_count * 2)),
                (float)(size / 2 + val.camera_radius * Math.Cos(val.pi * 2 / val.hole_count * 2) + val.normal_hole_diameter / 2),
                (float)(size / 2 + val.camera_radius * Math.Sin(val.pi * 2 / val.hole_count * 2)));
            G.DrawString("d = " + Math.Round((val.normal_hole_diameter / multiple), 2).ToString(),
                new Font("宋体", 10), new SolidBrush(Color.Black),
                (float)(size / 2 + val.camera_radius * Math.Cos(val.pi * 2 / val.hole_count * 2) - size * 0.02),
                (float)(size / 2 + val.camera_radius * Math.Sin(val.pi * 2 / val.hole_count * 2) - size * 0.03));


            pictureBox1.Image = img;
        }

        private void SaveB_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.Save(DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString().Replace(':', '-') + ".bmp");
        }
    }

    public class val
    {
        public static double pi = Math.PI;
        public static double multiple = 1.0;

        public static double all_diameter = 280;
        public static double normal_hole_diameter
        {
            get
            {
                return 6.35 * multiple;
            }
        }
        public static double wire_hole_diameter
        {
            get
            {
                return 40 * multiple;
            }
        }

        public static double connect_radius
        {
            get
            {
                return 70 * Math.Sqrt(2) / 2 * multiple;
            }
        }
        public static double wire_radius
        {
            get
            {
                return 70 * multiple;
            }
        }
        public static double bottom_radius
        {
            get
            {
                return 10 * multiple;
            }
        }
        public static double camera_radius
        {
            get
            {
                return 130 * multiple;
            }
        }

        public const int hole_count = 5;

        public static RectangleF GetRec(double cx, double cy, double d)
        {
            return new RectangleF((float)(cx - d / 2), (float)(cy - d / 2), (float)d, (float)d);
        }
    }
}
