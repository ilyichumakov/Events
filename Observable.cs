using System.Drawing;
using System.ComponentModel;

namespace Events
{
    public class Observable
    {
        protected EventHandlerList listEventDelegates = new EventHandlerList();

        private event Observer observers;
        public event Observer Observers
        {
            add
            {
                observers += value;
            }
            remove
            {
                observers -= value;
            }
        }        

        private event CntObserver _cntObservers;
        public event CntObserver CntObservers
        {
            add
            {
                _cntObservers += value;
            }
            remove
            {
                _cntObservers -= value;
            }
        }
        

        public void Notify(Color parameter)
        {
            if (observers != null)
                observers(parameter);
        }

        public void Notify(int cnt)
        {
            if (_cntObservers != null)
                _cntObservers(cnt);
        }
    }
}
