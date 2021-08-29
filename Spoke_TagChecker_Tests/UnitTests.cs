using NUnit.Framework;
using System;
using System.Collections.Generic;


namespace Spoke_TagChecker_Tests
{
    public class UnitTests
    {
        [Test]
        public void CorrectlyTaggedParagraphWithNestedTags()
        {
            // arrange
            string paragraph = @"The following text<C><B>is centred and in boldface</B></C>";

            // act
            var output = Spoke_TagChecker.TagChecker_Class.TagChecker(paragraph);                           

            // assert
            Assert.IsTrue(output == "Correctly tagged paragraph");
        }

        [Test]
        public void CorrectlyTaggedParagraphWithMultiplePairs()
        {
            // arrange
            string paragraph = @"<A></A><B></B>";

            // act
            var output = Spoke_TagChecker.TagChecker_Class.TagChecker(paragraph);                           

            // assert
            Assert.IsTrue(output == "Correctly tagged paragraph");
        }

        [Test]
        public void TagsAreNotNestedCorrectly()
        {
            // arrange
            string paragraph = @"<B><C> This should be centred and in boldface, but the tags are wrongly nested </B></C>";

            // act
            var output = Spoke_TagChecker.TagChecker_Class.TagChecker(paragraph);                           

            // assert
            Assert.IsTrue(output == "Expected </C> found </B>");
        }

        [Test]
        public void ExtraClosingTag()
        {
            // arrange
            string paragraph = @"<B>This should be in boldface, but there is an extra closing tag</B></C>";

            // act
            var output = Spoke_TagChecker.TagChecker_Class.TagChecker(paragraph);                           

            // assert
            Assert.IsTrue(output == "Expected # found </C>");
        }

        [Test]
        public void MissingClosingTag()
        {
            // arrange
            string paragraph = @"<B><C>This should be centred and in boldface, but there is a missing closing tag</C>";

            // act
            var output = Spoke_TagChecker.TagChecker_Class.TagChecker(paragraph);                           

            // assert
            Assert.IsTrue(output == "Expected </B> found #");
        }
    }
}