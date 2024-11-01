using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_9
{
    public interface Beverage
    {
        string GetDescription();
        double Cost();
    }
    public class Espresso : Beverage
    {
        public string GetDescription()
        {
            return "Espresso";
        }
        public double Cost()
        {
            return 500;
        }
    }
    public class Tea : Beverage
    {
        public string GetDescription()
        {
            return "Tea";
        }
        public double Cost()
        {
            return 350;
        }
    }

    public class Latte : Beverage
    {
        public string GetDescription()
        {
            return "Latte";
        }
        public double Cost()
        {
            return 550;
        }
    }

    public abstract class BeverageDecorator : Beverage
    {
        protected Beverage _beverage;

        public BeverageDecorator(Beverage beverage)
        {
            _beverage = beverage;
        }

        public virtual string GetDescription()
        {
            return _beverage.GetDescription();
        }

        public virtual double Cost()
        {
            return _beverage.Cost();
        }
    }
    public class MilkDecorator : BeverageDecorator
    {
        protected Beverage _beverage;

        public MilkDecorator(Beverage beverage) : base(beverage)
        {
        }

        public virtual string GetDescription()
        {
            return _beverage.GetDescription() + ", Milk";
        }

        public virtual double Cost()
        {
            return _beverage.Cost() + 100;
        }
    }
    public class SugarDecorator : BeverageDecorator
    {
        protected Beverage _beverage;

        public SugarDecorator(Beverage beverage): base(beverage)
        {
        }

        public virtual string GetDescription()
        {
            return _beverage.GetDescription() + ", Sugar";
        }

        public virtual double Cost()
        {
            return _beverage.Cost() + 50;
        }
    }
    public class WhippedCreamDecorator : BeverageDecorator
    {
        public WhippedCreamDecorator(Beverage beverage) : base(beverage)
        {
        }

        public override string GetDescription()
        {
            return _beverage.GetDescription() + ", Whipped Cream";
        }

        public override double Cost()
        {
            return _beverage.Cost() + 200;
        }
    }
    public class Caramel : BeverageDecorator
    {
        public Caramel(Beverage beverage) : base(beverage)
        {
        }

        public override string GetDescription()
        {
            return _beverage.GetDescription() + ", Caramel";
        }

        public override double Cost()
        {
            return _beverage.Cost() + 150;
        }
    }
    internal class Decorator
    {
    }
}
