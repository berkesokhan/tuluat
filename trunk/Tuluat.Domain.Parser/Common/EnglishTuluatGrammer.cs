using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Irony.Compiler;
using Tuluat.Domain.Parser.Common.Nodes;
using Irony.Compiler.AST;

namespace Tuluat.Domain.Parser.Common
{
    public class EnglishTuluatGrammer : Grammar
    {
        public EnglishTuluatGrammer()
        {
            #region Grammer Elements

            // turn off case sensitivity
            this.CaseSensitive = false;

            // define all the non-terminals
            NonTerminal program = new NonTerminal("", typeof(ProgramNode));
            NonTerminal statementList = new NonTerminal("", typeof(StatementListNode));

            NonTerminal open = new NonTerminal("open", typeof(OpenNode));
            NonTerminal check = new NonTerminal("check", typeof(CheckNode));
            NonTerminal enter = new NonTerminal("enter", typeof(CheckNode));
            NonTerminal click = new NonTerminal("click", typeof(ClickNode));
            NonTerminal select = new NonTerminal("select", typeof(SelectNode));

            //var statementList = new NonTerminal("statementList", typeof(StatementListNode));
            //var freightDeclaration = new NonTerminal("freightDeclaration", typeof(FreightDeclarationNode));
            //var statement = new NonTerminal("statement", typeof(StatementNode));
            //var setVariable = new NonTerminal("setVariable", typeof(SetVariableNode));
            //var ifStatement = new NonTerminal("ifStatement", typeof(IfStatementNode));
            //var orderLoop = new NonTerminal("orderLoop", typeof(OrderLoopNode));
            //var expression = new NonTerminal("expression", typeof(ExpressionNode));
            //var binaryOperator = new NonTerminal("binaryOperator", typeof(BinaryOperatorNode));

            //// define all the terminals
            //var variable = new IdentifierTerminal("variable");
            //variable.AddKeywords("set", "to", "if", "freight", "cost", "is", "loop", "through", "order");
            //var number = new NumberLiteral("number");
            //var stringLiteral = new StringLiteral("string", "\"", ScanFlags.None);

            //// remove uninteresting nodes from the AST (note: in current version of Irony,
            //// keywords added to the variable cannot be registered as punctuation).
            //this.RegisterPunctuation(";", "[", "]", "(", ")");

            //// specify the non-terminal which is the root of the AST
            //this.Root = program;

            #endregion
        }
    }
}
