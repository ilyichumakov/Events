using System;
using System.Drawing;
using System.Windows.Forms;

namespace Events
{
    public class Lamp : Observable
    {
        private bool _state;
        public bool State
        {
            get { return _state; }
        }
        private Label _label;
        private Color color;        
        private Random r;
        private int _counter;
        public int Counter
        {
            get { return _counter; }
        }
        
        private readonly Color defaultColor = Color.Snow;
        private readonly Color[] activeColors = { Color.Gold, Color.BlueViolet, Color.Green, Color.Tomato, Color.SaddleBrown };       
        
        public Lamp(Label lbl)
        {           
            this._label = lbl;
            r = new Random(lbl.GetHashCode());
            _state = false;
            _counter = 0;
        }

        public Lamp()
        {
            r = new Random();
            _state = false;
            _counter = 0;
        }

        public void turnOn()
        {
            if (this.State) return;
            int index = r.Next(0, activeColors.Length);
            setColor(activeColors[index]);
            _state = true;
            _counter++;
            this.Notify(_counter);
        }

        public void turnOff()
        {
            if (!this.State) return;
            setColor(defaultColor);
            _state = false;
        }

        public void setColor(Color c)
        {
            this.color = c;
            if(_label != null) this._label.BackColor = c;
            this.Notify(c);
        }

        public Color CurrentColor
        {
            get
            {
                return this.color;
            }
        }
    }
}
