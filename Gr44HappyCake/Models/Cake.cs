using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gr44HappyCake.Models
{
    public class Cake
    {
        string filling;
        string topping;
        bool bakedAndDone;
        TimeSpan bakeTime;// How long time it takes for the cake to bake
        double tempReq;// How hot/ temperature required.

        public bool BakedAndDone { get { return bakedAndDone; } }// Manual version of the and this is how you link a property and a feld
        public Cake(string filling,string topping,TimeSpan bakeTime,double tempReq )
        {
            this.tempReq = tempReq;
            this.bakeTime = bakeTime;
            this.filling = filling;
            this.topping = topping;

        }

        public bool BakeTheCake(double temperature,TimeSpan bakeTime)
        {
            if (temperature >= tempReq && this.bakeTime >= bakeTime)
            {
                bakedAndDone = true; 
                return true;
            }
            else { return false; }
        }
    }

}
