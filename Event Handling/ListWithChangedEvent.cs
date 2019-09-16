using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Handling
{
    public delegate void ChangeEventHandler(object sender, EventArgs e);

    class ListWithChangedEvent : ArrayList
    {
        public ChangeEventHandler Changed;

        public virtual void OnChanged(EventArgs e)
        {
            if (Changed != null)
                Changed(this, e);   
        }
        public override void Add(object value)
        {
            base.Add(value);
            OnChanged(EventArgs.Empty);
        }
        public override void Clear()
        {
            base.Clear();
            OnChanged(EventArgs.Empty);
        }
        public override object this[int index]
        {
            set
            {
                base[index] = value;
                OnChanged(EventArgs.Empty);
            }
        }
    }
}
