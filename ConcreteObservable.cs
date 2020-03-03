using System.Drawing;

namespace Events
{
    class ConcreteObservable : Observable
    {
        private Color parameter;
        public Color Parameter
        {
            get
            {
                return parameter;
            }
            set
            {
                this.parameter = value;
                this.Notify(parameter);
            }
        }
    }
}
