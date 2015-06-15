# Test-First

Test-First (or TDD for short) is a software low level design technique that puts the common developer in disconfort. And that is good.
<br/>Once mastered this technique, the disconfort turns into self-confidence that the software written in such fashion posses a better design, is more reliable and better understandable. 

## Dynamics
You are going to be given 1.5 hours to go as far as you can on the assignment.
The assignment is a simple program with an informal specification that has to be implemented test-first.
<br/>Do **not** cheat.
<br/>Follow the rules by the book (Red-Green-Refactor) you'll know when to shortcut when you master TDD. And then you'll regret.

You can work on your own or you can work in pairs. Lone wolfs are successful but pairs are le-gen-da-ry and ping-pong is just fun.

You are very welcome to ask me as many questions as you want, ask for help, cry like a baby or swear like a Geordie Shore cast member.

## Setup

The test is written in plain English. Tests and production code can be written in whichever language or platform the developer/s feel/s capable of.
<br/>I do recommend C# because that is what we use the most and because I believe is a pretty good language.

Despite being hosted in GitHub you are not expected to be profficient in Git, but it will help you during the setup process.

These are the general instructions, you can follow them using your command line awesomeness, the training wheels of GitHub for Windows or the stick-in-the-wheels of Visual Studio Git Integration:

1. [Clone] (https://help.github.com/articles/which-remote-url-should-i-use/) the repository.
2. Checkout the test-first branch.
3. Create a Test.First console application
4. Add a Test.First.Tests class library project to the solution.
5. Install an automated testing library to the test project. I recommend [NUnit](http://www.nuget.org/packages/NUnit/2.6.4).
<br/>But you are welcome to use whichever framework you are used to/want to experiment with: [Fixie](http://www.nuget.org/packages/Fixie/), [xUnit.net](http://www.nuget.org/packages/xunit). Even the one backed in Visual Studio will do.
6. You might reach a point in which you feel the need for  Interaction-Based Testing, so installing a mocking/substitutes/fakes framework is not out of the question. I recommend [NSubstitute](http://www.nuget.org/packages/NSubstitute/).
<br/>But you are welcome to use whichever framework you are used to/wan to experiment with: [Fake It Easy](http://www.nuget.org/packages/FakeItEasy), [Moq](http://www.nuget.org/packages/Moq/) or even [RhinoMocks](http://www.nuget.org/packages/RhinoMocks) if you are really old-school and think that Keanu Reeves will be the next big thing.

## The Assignment

Create a console application that processes a list of addresses in a file and validates against a web service.

Here is a list of the requirements:

1. The program retrieves the file name as mandatory argument with the –f (or –F) switch.
2. Files processed must have .add extension; otherwise they should not be processed.
3. If the arguments are not correct, error messages should be returned.
4. The user of the program must be informed which error happened:
  1. Wrong number of arguments
  2. Wrong switch
  3. Missing argument with correct switch
  4. Wrong file extension
5. Those errors need to be written to the standard error output
6. Messages must be localizable
7. The file to be processed contains, in each line, the address to be validated.
8. The user needs to be able to see the result of the validation of each address.
9. The result should be displayed in the standard output.
10. Error cases in which the file is not found or any other case must be differentiated.
11. The result format is as follows: {address} | {true/false}
