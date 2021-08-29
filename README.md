# **Spoke Tag Checker**
<br>

## **My Solution Contains The Following:**
<br>

### <u>A TagChecker_Class containig the TagChecker function, which takes a string input.</u>
The function loops through the given input tot determine if it is correctly tagged or not.<br>
If it is correct, the program will output "Correctly tagged paragraph" in the console.<br>
If the tags are incorrectly nested, it will output "Expected `</C>` found `</B>`".<br>
if the paragraph has an extra closing tag, the output will be "Expected # found `</C>`".<br>
And lastly, if the paragraph has a missing closing tag, the output will be "Expected `</B>` found #". <br>
<br>

### <u>A unitTests class containig the following five tests for the various test cases</u>
1. CorrectlyTaggedParagraphWithNestedTags()&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&nbsp;&nbsp;- Testing a correctly tagged paragraph with nested tags
2. CorrectlyTaggedParagraphWithMultiplePairs()&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;- Testing a correctly tagged paragraph with multiple pairs of unnested tags
3. TagsAreNotNestedCorrectly()&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;- Testing a paragraph that contains tags are nested incorrectly
4. ExtraClosingTag()&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&nbsp;&nbsp;&nbsp;&nbsp;- Testing a paragraph that contains an extra closing tag
5. MissingClosingTag()&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;- Testing a paragraph that has a missing closing tag
<br>
<br>

## **Instructions on building and running the code:**
- Make sure you have NUnit installed using NuGet Package Manager.
- To build, make sure you are in the top level /Spoke_TagChecker and run 'dotnet build'.
- To run the code cd down into /Spoke_TagChecker/Spoke_TagChecker and run 'dotnet run'.
- To run the tests, make sure you are at the top level /Spoke_TagChecker and run <br>
    'dotnet test Spoke_TagChecker_Tests/Spoke_TagChecker_Tests.csproj'.  