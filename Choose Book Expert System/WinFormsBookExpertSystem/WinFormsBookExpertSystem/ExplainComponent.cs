﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsBookExpertSystem
{
    public class ExplainComponent : IExplainComponent
    {
        private ILogicOutput myLogicOutput;
        public ExplainComponent(ILogicOutput logicOutput)
        {
            myLogicOutput = logicOutput;
        }
    }
}