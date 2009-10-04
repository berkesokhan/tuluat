using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Irony.Compiler;
using Tuluat.Domain.Generator;

namespace Tuluat.Domain.Parser.Common.Nodes
{
    public class ClickNode : AstNode, IWatinCodeGenerator
    {
        public ClickNode(NodeArgs args) : base(args) { }

        public string GetCode()
        {
            throw new NotImplementedException();
        }
    }
}
