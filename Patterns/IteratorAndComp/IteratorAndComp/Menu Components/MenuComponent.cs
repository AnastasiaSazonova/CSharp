using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorAndComp
{
    public abstract class MenuComponent
    {
        public virtual void Add(MenuComponent menuComponent) 
        {
            throw new OperationCanceledException();
        }

        public virtual void Remove(MenuComponent menuComponent)
        {
            throw new OperationCanceledException();
        }

        public virtual MenuComponent GetChild(int i)
        {
            throw new OperationCanceledException();
        }

        public virtual string GetName()
        {
            throw new OperationCanceledException();
        }

        public virtual string GetDescription()
        {
            throw new OperationCanceledException();
        }

        public virtual double GetPrice()
        {
            throw new OperationCanceledException();
        }

        public virtual bool IsVegetarian()
        {
            throw new OperationCanceledException();
        }

        public virtual void Print()
        {
            throw new OperationCanceledException();
        }
    }
}
