# Test-Last

**Testing Last** (or, better yet, **Near**) should offer the least level of weirdness and mindset shifting to newcomers to testing.

With the Katas proposed, you'll have the chance to put into practice the patterns, heuristics and techniques showcased to you in the [presentation](http://vertica-as.github.io/testing-TDD "slides").

## Dynamics
You are going to be given **1.5 hours** to complete as many Katas as you can.
<br/>A Kata is a small exercise which completion is not obvious (testing never is), so you are left with the task to know (or ask or agree) when you are done and are ready to move onto the next. These Katas are independent from each other and can be done in whichever order one fancies, but they are increasing in complexity.

You can work on your own or you can work in pairs. Lone wolfs are successful but pairs are le-gen-da-ry.

You are very welcome to ask me as many questions as you want, ask for help, cry like a baby or swear like a Geordie Shore cast member.

### Setup
The test subjects are included in a Visual Studio class library project. Familiarity with Visual Studio is expected, otherwise let me know and we will have a short and potentially ugly conversation.

Despite being hosted in _GitHub_ you are not expected to be profficient in _Git_, but it will help you during the setup process.

These are the general instructions, you can follow them using your command line awesomeness, the training wheels of [GitHub for Windows](https://windows.github.com/) or the stick-in-the-wheels of [Visual Studio Git Integration](https://msdn.microsoft.com/en-us/library/hh850437.aspx):
 
1. **[Clone]** (https://help.github.com/articles/which-remote-url-should-i-use/) the repository.
2. **Checkout** the _test-last_ branch.
3. Open the _Test-Last.sln_ file in Visual Studio
4. Add a _Test-Last.Tests_ class library project to the solution
5. Install an automated testing library to the test project. I recommend [NUnit](http://www.nuget.org/packages/NUnit/2.6.4).
<br/>But you are welcome to use whichever framework you are used to/want to experiment with: [Fixie](http://www.nuget.org/packages/Fixie/), [xUnit.net](http://www.nuget.org/packages/xunit). Even the one backed in Visual Studio will do.
6. For some Katas you are likely to be using Interaction-Based Testing, so installing a mocking/substitutes/fakes framework is not out of the question. I recommend [NSubstitute](http://www.nuget.org/packages/NSubstitute/).
<br/>But you are welcome to use whichever framework you are used to/wan to experiment with: [Fake It Easy](http://www.nuget.org/packages/FakeItEasy), [Moq](http://www.nuget.org/packages/Moq/) or even [RhinoMocks](http://www.nuget.org/packages/RhinoMocks) if you are really old-school and think that Keanu Reeves will be the next big thing. 

## Kata #1. MajorAndMinorEquality

Unit test the class <code>MajorAndMinorEquality</code>.

You'll leverage your analytics skills and the use of lists to plan your testing. 

## Kata #2. Left() and LeftFromFirst()
Unit test the extension method <code>.Left()</code> and <code>.LeftFromFirst()</code>.

This Kata is the perfect opportunity to sharpen the data testing capabilities of your testing framework of choice.

## Kata #3. AlphabeticalAggregator
Unit thest the <code>AlphabeticalAggregator</code> class (extra bonus points for testing the other support classes in the kata).

This Kata will let you show off your Interaction-Testing skills. Remember: a unit is a fuzzy term and overdoing hurts.

### Hints
<blockquote> 
Use a more manageable alphabet provider for tests (twenty something is no fun).
</blockquote>
<blockquote >
Interesting scenarios to test:

* there are *alphabet_length* buckets plust an overflow
* all buckets have an initial corresponding to an alphabet letter except the overflow that has none
* aggregables that start with a letter outside the alphabet go to the overflow
* aggregables end up sorted in the buckets
</blockquote >