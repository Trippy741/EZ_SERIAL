using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Threading;

namespace CommunicateWithArduino
{
    public class ControlNode
    {
        public enum nodeType
        {
            COM_PORT,
            IF,
            FUNCTION,
            VALUE,
            EMPTY
        }
        protected int node_id;

        protected Point Location;
        protected string node_label_string { get; set; }
        protected Panel node_panel;
        protected Panel node_header_panel;
        protected Label node_header_label;

        private Control Context;

        protected Size size;
        public ControlNode(Control Context,int node_id, string node_label_string)
        {
            this.Context = Context;
            this.node_id = node_id;
            this.node_label_string = node_label_string;

            //The Node panel itself
            node_panel = new Panel();
            node_panel.Size = new Size(210,100);
            node_panel.Location = new Point(100,100);
            node_panel.BackColor = Color.Gray;
            node_panel.SendToBack();

            //Node Header Panel
            node_header_panel = new Panel();
            node_header_panel.Parent = node_panel;
            node_header_panel.Dock = DockStyle.Top;
            node_header_panel.Size = new Size(0, 20);
            node_header_panel.BackColor = Color.Black;

            //Node Header Text
            node_header_label = new Label();
            node_header_label.Text = node_label_string;
            node_header_label.Parent = node_header_panel;
            node_header_label.ForeColor = Color.White;
            node_header_label.Text = "THIS IS A NEW NODE";
            node_header_label.AutoSize = true;
            node_header_label.BringToFront();

            ControlExtension.Draggable(node_panel,true);

            Context.Controls.Add(node_panel);//Adding the panel to the Form controls
            node_panel.Controls.Add(node_header_panel);//Adding the panel header panel to the node panel Controls
            node_header_panel.Controls.Add(node_header_label);//Adding the label to the panel controls
        }
        public void AddNodeControls(Control nodeControl)
        {
            node_panel.Controls.Add(nodeControl);
        }
        public void AddNodeLabels(Label label)
        {
            node_panel.Controls.Add(label);
        }
        public void DrawBezier(Point StartLocation, Point EndLocation)
        {
            Bitmap drawingArea = new Bitmap(Context.Width,Context.Height);
            Graphics g = Graphics.FromImage(drawingArea);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            Pen red = new Pen(Color.Red);

            System.Drawing.Point p1 = new System.Drawing.Point(0,0);
            System.Drawing.Point p2 = new System.Drawing.Point(Context.Width,0);
            System.Drawing.Point p3 = new System.Drawing.Point(0,Context.Height);
            System.Drawing.Point p4 = new System.Drawing.Point(Context.Width,Context.Height);

            List<System.Drawing.Point> points = new List<System.Drawing.Point>() { p1,p2,p3,p4};
            g.DrawBezier(red, p1,p2,p3,p4);

        }
    }
}
