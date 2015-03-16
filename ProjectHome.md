## User Acceptance Testing Automation with a DSL for Web Applications ##
In short, Tuluat aims its users to be able to write English-like statements to test a website.

Project will be using mainly .NET Framework technologies.

### How It's Done? ###
Nothings done yet.

But it will be done like this:

Users enter to a Windows application (Tuluat), their english-like statements (Tuluat DSL - TuDSL) which is in fact describes a user acceptance test for a website. Then again by using Tuluat they execute their tests and see results.

### Which Technology and How? ###
Project will have a Windows Presentation Framework (WPF) based user interface for administering and running TuDSL tests.

TuDSL tests will be parsed and transform into Abstract Syntax Tree (AST) using [Irony](http://www.codeplex.com/irony). Irony is choosen for simplicity and despite lack of documentation its ease to use. We want to focus on our DSL's evolution and functionality, more than how we describe it. At later stages of development if we would think our TuDSL is mature enough and we didn't satisfy with Irony, we can consider changing it with another tool.

By using AST we will generate a C# code utilizing Watin API. Generated C# code will be an in memory string. We will feed this string to our runner libraries and create an in memory assembly for each test (or for a scenario composed of more than one test), and run on the fly.

To store users' TuDSL scripts we plan to use SQLite with NHibernate.

### Been There, Done That? ###
After putting this idea out, we found out that its not an original idea, and already thought and implemented by others like [Torkel Ödegaard](http://www.codinginstinct.com/2008/11/creating-watin-dsl-using-mgrammar.html). As much as we respect to implementers, we dont care either.

This is a learning project for us, and we hope to develop our external DSL creation skills.