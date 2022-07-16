using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15
{
    public class GeomProgression
    {
        int startValue;
        int step;
        int currentValue;
        public int getNext()
        {
            currentValue *= step;
            return currentValue;
        }

        public void reset()
        {
            currentValue = startValue;
        }

        public void setStart(int startNumber)
        {
            startValue = startNumber;
            currentValue = startValue;
        }

        public void setStep(int step)
        {
            this.step = step;
        }
    }
}
