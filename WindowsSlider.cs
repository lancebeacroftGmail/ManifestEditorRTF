using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlSizeSlider
{
    class WindowsSlider
    {
        public enum WindowsSliderType { vertical, horizontal}
        public Control eventSource { get; set; }
        public WindowsSliderType Type { get; set; }

        Color EventSourceOriginalColor;

        public List<Control> LeftControls =new List<Control>();
        public List<Control> RightControls = new List<Control>();
        public List<Control> TopControls = new List<Control>();
        public List<Control> BottomControls = new List<Control>();

        private Point currentControlLocation;
        private Point currentMouseLocation;
        private bool isMouseDown = false;

        public void Start()
        {
            eventSource.BackColor = eventSource.Parent.BackColor;
            EventSourceOriginalColor = eventSource.BackColor;

            eventSource.MouseDown += new MouseEventHandler(eventSource_MouseDown);
            eventSource.MouseMove += new MouseEventHandler(eventSource_MouseMove);
            eventSource.MouseUp += new MouseEventHandler(eventSource_MouseUp);
            eventSource.MouseHover += new System.EventHandler(eventSource_MouseHover);
            eventSource.MouseLeave += new System.EventHandler(eventSource_MouseLeave);



        }

        private void eventSource_MouseLeave(object sender, EventArgs e)
        {
            eventSource.BackColor = this.EventSourceOriginalColor;
        }

        private void eventSource_MouseHover(object sender, EventArgs e)
        {
            Color currentColor = eventSource.BackColor;

            // Reduce each RGB component by 20, ensuring they don't go below 0
            int newRed = Math.Max(0, currentColor.R - 40);
            int newGreen = Math.Max(0, currentColor.G - 40);
            int newBlue = Math.Max(0, currentColor.B - 40);

            Color newColor = Color.FromArgb(newRed, newGreen, newBlue);
            eventSource.BackColor = newColor;
        }

        private void eventSource_MouseUp(object sender, MouseEventArgs e)
        {
            
            isMouseDown = false;
        }

        private void DoVertical()
        {
            //eventSource.Text = "MouseMOVEV";
            if (isMouseDown)
            {
                //Has x changed for this?
                int yShift = Cursor.Position.Y - currentMouseLocation.Y;

                eventSource.Top = eventSource.Top + yShift;

                foreach (var item in this.TopControls)
                {
                    item.Height = item.Height + yShift;
                }

                foreach (var item in this.BottomControls)
                {
                    item.Height = item.Height - yShift;
                    item.Top = item.Top + yShift;

                }
                currentMouseLocation = Cursor.Position;
            }
        }

        private void DoHorizontal()
        {
            //eventSource.Text = "MouseMOVEH";



            if (isMouseDown)
            {
                //Has x changed for this?
                int xShift = Cursor.Position.X - currentMouseLocation.X;

                eventSource.Left = eventSource.Left + xShift;

                foreach (var item in this.LeftControls)
                {
                    item.Width = item.Width + xShift;
                }

                foreach (var item in this.RightControls)
                {
                    item.Width = item.Width - xShift;
                    item.Left = item.Left + xShift;

                }
                currentMouseLocation = Cursor.Position;
            }
        }

        private void eventSource_MouseMove(object sender, EventArgs e)
        {

            
            if (Type==WindowsSliderType.vertical)
            {
                DoVertical();
            }

            if (Type == WindowsSliderType.horizontal)
            {
                DoHorizontal();
            }
        }

        private void eventSource_MouseDown(object sender, EventArgs e)
        {
           // eventSource.Text = "MouseDown";
            currentControlLocation = eventSource.Location;
            currentMouseLocation = Cursor.Position;
            isMouseDown = true;
        }

        public void Stop()
        {
            eventSource.MouseDown -= new MouseEventHandler(eventSource_MouseDown);
            eventSource.MouseMove -= new MouseEventHandler(eventSource_MouseMove);
        }

    }
}

