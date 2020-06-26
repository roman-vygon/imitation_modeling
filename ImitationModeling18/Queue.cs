using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImitationModeling18
{
    class Queue : Agent
    {
        double lambda = 1;
        public double t = 0;
        public int cnt_all = 0;
        public int cnt = 0;
        public double nextEvent;
        Random rnd;
        public List<Operator> ops = new List<Operator>();

        private double exponentialRV(double lambda)
        {
            return -1.0 * Math.Log(rnd.NextDouble()) / lambda;
        }

        public Queue(double lambda, Random rnd)
        {
            this.lambda = lambda;
            this.rnd = rnd;
        }
        public void addOperator(Operator op)
        {
            ops.Add(op);
        }
        
        public double NextEventTime(double t)
        {
            return nextEvent;
            //return t + exponentialRV(lambda);
        }
        public void giveCustomers(double t)
        {
            if (cnt > 0)
            {
                foreach (Operator op in ops)
                {
                    if (!op.enabled)
                    {                        
                        cnt--;
                        op.processCustomer(t);                        
                        if (cnt == 0)
                            break;
                    }
                }
            }
        }
        public void processEvent(double t)
        {
            ++cnt;
            ++cnt_all;
            giveCustomers(t);
            nextEvent = t + exponentialRV(lambda);
        }
        public override string ToString()
        {
            return "Queue";
        }
    }
}
