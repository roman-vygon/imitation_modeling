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
        double nextEvent = Double.PositiveInfinity;

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

        public double NextEventTime(double t)
        {
            return nextEvent;
            if (!enabled)
                return Double.PositiveInfinity;
            else
                return t + exponentialRV(lambda);
        }
        
        public void processCustomer(double t)
        {
            nextEvent = t + exponentialRV(lambda);
            enabled = true;            
        }
        public void processEvent(double t)
        {
            --q.cnt_all;
            enabled = false;
            nextEvent = Double.PositiveInfinity;
            q.giveCustomers(t);
        }
        public override string ToString()
        {
            return "Window #" + num.ToString();
        }
    }
}
