using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTanslator
{
    public partial class MyMessageDialog : Form
    {
        public MyMessageDialog()
        {
            InitializeComponent();
        }

        enum WinStyle
        {

        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams createParams = base.CreateParams;
                createParams.Style |= 0x00020000; // WS_GROUP;
                if (!DesignMode)
                {
                    createParams.ExStyle |= 0x00080000; // WS_EX_LAYERED
                }
                return createParams;
            }
        }

        public void SetBits(Bitmap bitmap)
        {
            if (!Image.IsCanonicalPixelFormat(bitmap.PixelFormat) || !Image.IsAlphaPixelFormat(bitmap.PixelFormat))
            {
                throw new ApplicationException("图片必须是32位带Alhpa通道的图片。");
            }
            var hObj = IntPtr.Zero;
            var dc = utils.Win32Utils.GetDC(IntPtr.Zero);
            var intPtr = IntPtr.Zero;
            var intPtr2 = utils.Win32Utils.CreateCompatibleDC(dc);
            try
            {
                var point = new utils.Win32Utils.Point(Left, Top);
                var size = new utils.Win32Utils.Size(bitmap.Width, bitmap.Height);
                var blendfunction = default(utils.Win32Utils.BLENDFUNCTION);
                var point2 = new utils.Win32Utils.Point(0, 0);
                intPtr = bitmap.GetHbitmap(Color.FromArgb(0));
                hObj = utils.Win32Utils.SelectObject(intPtr2, intPtr);
                blendfunction.BlendOp = 0;
                blendfunction.SourceConstantAlpha = byte.MaxValue;
                blendfunction.AlphaFormat = 1;
                blendfunction.BlendFlags = 0;
                utils.Win32Utils.UpdateLayeredWindow(Handle, dc, ref point, ref size, intPtr2, ref point2, 0, ref blendfunction, 2);
            }
            finally
            {
                if (intPtr != IntPtr.Zero)
                {
                    utils.Win32Utils.SelectObject(intPtr2, hObj);
                    utils.Win32Utils.DeleteObject(intPtr);
                }
                utils.Win32Utils.ReleaseDC(IntPtr.Zero, dc);
                utils.Win32Utils.DeleteDC(intPtr2);
            }
        }

        private Graphics g;
        public void DrawStr(string str)
        {
            Font font = new Font("微软雅黑", 24f);
            
            
            SizeF stringSize = CreateGraphics().MeasureString(str, font);

            ClientSize = new Size((int)(stringSize.Width * 1.2),(int)(stringSize.Height * 1.2 + 4));
            Location = new Point((Screen.PrimaryScreen.Bounds.Width - Width) / 2,
                        (Screen.PrimaryScreen.WorkingArea.Height - Height) / 2 / 3 * 5);
            var bmp = new Bitmap(ClientSize.Width, ClientSize.Height);
            g = Graphics.FromImage(bmp);

            g.InterpolationMode = InterpolationMode.Bilinear;
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.TextRenderingHint = TextRenderingHint.AntiAlias;
            g.Clear(Color.Transparent);
            g.FillRectangle(new SolidBrush(Color.FromArgb(120, Color.Black)), ClientRectangle);
            g.DrawRectangle(new Pen(Color.FromArgb(224, 224, 224)), 1,1, ClientSize.Width -2, ClientSize.Height -2);

            var stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;

            g.DrawString(s: str,
                        font: font,
                        brush: new SolidBrush(Color.FromArgb(255, Color.White)),
                        layoutRectangle: new Rectangle(0, 0, ClientSize.Width, ClientSize.Height),
                        format: stringFormat);
            SetBits(bmp);
            g.Dispose();
            bmp.Dispose();
        }

        private void Delay(uint ms)
        {
            int nowTick = Environment.TickCount;
            while (Math.Abs(Environment.TickCount - nowTick) < ms)
            {
                Thread.Sleep(1);
                Application.DoEvents();
            }
        }


        async public static void ShowMessage(string message)
        {
            var myMessageDialog  = new MyMessageDialog();
            myMessageDialog.DrawStr(message);
            myMessageDialog.Show();
            await Task.Delay(new TimeSpan(0,0,0,0,milliseconds:2000));
            myMessageDialog.Hide();
            myMessageDialog.Dispose();
        }
    }
}
