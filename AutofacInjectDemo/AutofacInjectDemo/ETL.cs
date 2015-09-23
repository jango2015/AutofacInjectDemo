using System;
using System.Collections.Generic;
using IMo;

namespace AutofacInjectDemo
{
    public class ETL
    {
        private readonly IEMoudle _e;

        public ETL(IEMoudle e)
        {
            _e = e;
        }

        public void Run()
        {
            if (_e != null)
            {
                _e.SaySomething();
            }
        }
    }
}
