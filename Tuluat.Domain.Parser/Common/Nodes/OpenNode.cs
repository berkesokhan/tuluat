﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Irony.Compiler;
using Tuluat.Domain.Generator;

namespace Tuluat.Domain.Parser.Common.Nodes
{
    public class OpenNode : AstNode, IWatinCodeGenerator
    {
        public OpenNode(NodeArgs args) : base(args) { }

        public string GetCode()
        {
            return "";
        }
    }
}
