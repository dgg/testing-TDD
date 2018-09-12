# Test-First

Test-First (or TDD for short) is a software low level design technique that puts the common developer in disconfort. And that is good.
<br/>Once mastered this technique, the disconfort turns into self-confidence that the software written in such fashion posses a better design, is more reliable and better understandable. 

## Dynamics
You are going to be given 1.5 hours to go as far as you can on the assignment.
The assignment is a simple program with an informal specification that has to be implemented test-first.
<br/>Do **not** cheat.
<br/>Follow the rules by the book (Red-Green-Refactor) you'll know when to shortcut when you master TDD. And then you'll regret.

You can work on your own or you can work in pairs. Lone wolfs are successful but pairs are le-gen-da-ry and ping-pong is just fun.

You are very welcome to ask me as many questions as you want, ask for help, cry like a baby or swear like a _{insert_embarrasing_reality_show}_ cast member.

## Setup

The test is written in plain English. Tests and production code can be written in whichever language or platform the developer/s feel/s capable of.
<br/>I do recommend **C#** because that is what we use the most and because I believe is a pretty good language. However, I have also included library recommendations for our strong-willed **javascript** developers.

These are the general instructions, you can follow them using your command line awesomeness or your middle-of-the-mall IDE voodoo:

1. Create a console application
1. Add a test container (another library or a subfolder will do)
1. Install an automated testing library to the test project. I recommend [NUnit](http://www.nuget.org/packages/NUnit) or [Mocha](https://mochajs.org/).
<br/>But you are welcome to use whichever framework you are used to/want to experiment with.
1. You might reach a point in which you feel the need for  Interaction-Based Testing, so installing a mocking/substitutes/fakes framework is not out of the question. I recommend [NSubstitute](http://www.nuget.org/packages/NSubstitute/) or [Sinon](https://sinonjs.org/).
<br/>But you are welcome to use whichever framework you are used to/want to experiment with.

## The Assignment

Create a console application that processes a list of addresses in a file and validates against a web service.

Here is a list of the requirements:

1. The program retrieves the file name as mandatory argument with the `–f` (or `–F`) switch.
1. Files processed must have `.add` extension; otherwise they should not be processed.
1. If the arguments are not correct, error messages should be returned.
1. The user of the program must be informed which error happened:
   1. Wrong number of arguments
   1. Wrong switch
   1. Missing argument with correct switch
   1. Wrong file extension
1. Those errors need to be written to the standard error output
1. Messages must be localizable
1. The file to be processed contains, in each line, the address to be validated.
1. The user needs to be able to see the result of the validation of each address.
1. The result should be displayed in the standard output.
1. Error cases in which the file is not found or any other case must be differentiated.
1. The result format is as follows: `{address} | {true/false}`
