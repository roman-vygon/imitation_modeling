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
        public int cnt = 0;
        public double nextEventTime(double t)
        {
            return t + exponentialRV(lambda);
        }
        public void processEvent()
        {
            cnt += 1;
            foreach (Operator op in ops)
            {
                if (!op.enabled)
                {
                    op.enabled = true;
                    cnt--;
                }
            }
        }
        public override string ToString()
        {
            return "Queue";
        }
    }
}
