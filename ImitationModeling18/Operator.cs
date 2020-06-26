using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImitationModeling18
{
    class Operator : Agent
    {
        public bool enabled = false;
        double lambda = 1;
        Random rnd;
        int num;
        Queue q;

        private double exponentialRV(double lambda)
        {
            return -1.0 * Math.Log(rnd.NextDouble()) / lambda;
        }

        public Operator(double lambda, Random rnd, Queue q, int num)
        {
            this.lambda = lambda;
            this.rnd = rnd;
            this.q = q;
            this.num = num;
        }

        public double nextEventTime(double t)
        {
            if (!enabled)
                return Double.PositiveInfinity;

            return t + exponentialRV(lambda);
        }
        public void processEvent()
        {            
            if (q.cnt > 0)            
                q.cnt--;
            else
                enabled = false;
        }
        public override string ToString()
        {
            return "Window #" + num.ToString();
        }
    }
}
