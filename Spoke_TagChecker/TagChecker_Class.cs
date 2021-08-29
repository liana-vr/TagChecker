using System;
using System.Collections.Generic;

namespace Spoke_TagChecker
{
    public class TagChecker_Class
    {
        public static string TagChecker(string paragraph)
        {
            Stack<char> tagsStack = new Stack<char>();                                              // Create an empty stack for the opening tags
            var isPaired = false;                                                                   // Boolean is set to true if a correct pair of tags is found
            var closingTagNum = 0;                                                                  // closingTagNum keeping track of the number of closing tags
            var openTag = '\0';                                                                     // Open tag variable initialised

            for (var i = 0; i < paragraph.Length; i++)                                              // Loop through the paragraph
            {                
                if(paragraph[i] == '<' && paragraph[i+1] != '/'                                     // Identify an opening tag and add it to the stack
                    && char.IsUpper(paragraph[i+1])
                    && char.IsLetter(paragraph[i+1]))
                {
                    tagsStack.Push(paragraph[i+1]);
                }

                if(paragraph[i] == '<' && paragraph[i+1] == '/'
                    && char.IsUpper(paragraph[i+2])
                    && char.IsLetter(paragraph[i+2]))                                               // If there is a closing tag 
                { 
                    var closingTag = (char)paragraph[i+2];                                          // create closingTag variable
                    closingTagNum++;                                                                // increase the number of closing tags by one

                    if (tagsStack.Count != 0)                                                       // if the stack of opening tags is not empty
                    {
                        openTag = tagsStack.Peek();                                                 // get the top tag and update the openTag variable
                        if (openTag.Equals(closingTag))                                             // if the openTag matches the closingTag
                        {
                            tagsStack.Pop();                                                        // pop it from the stack
                            closingTagNum--;                                                        // decrease the number of closing tags by one
                            isPaired = true;                                                        // isPaired Boolean is updated to true                                                        
                            if (tagsStack.Count != 0)                                               // if the stack is still not empty
                            {
                                openTag = tagsStack.Peek();                                         // openTag is updated to the next tag in the stack 
                                continue;                                                           // continue with the loop
                            }
                            continue;
                        }

                        if (!openTag.Equals(closingTag))                                            // if the openTag does not match the closingTag
                        {                                                                           // this means it is not correctly nested 
                            Console.Write($"Expected </{openTag}> found </{closingTag}>\n");        // output "Expected </C> found </B>" for example
                            isPaired = false;                                                       // isPaired is set to false 
                            return $"Expected </{openTag}> found </{closingTag}>";                  // return the string
                        }
                    }

                    if (tagsStack.Count == 0 && closingTagNum != 0)                                 // if the stack is empty but there are still closing tags
                    {                                                                               // This means there is an extra closing tag  
                        Console.Write($"Expected # found </{closingTag}>\n");                       // output "Expected # found </C>" for example
                        isPaired = false;                                                           // isPaired is set to false 
                        return $"Expected # found </{closingTag}>";                                 // return the string
                    }
                }
            }

            if (tagsStack.Count != 0 && closingTagNum == 0)                                         // if the stack is not empty but closingTagNum is equal to zero
            {                                                                                       // This means there is a missing closing tag  
                Console.Write($"Expected </{openTag}> found #\n");                                  // output "Expected </B> found #" for example
                isPaired = false;                                                                   // isPaired is set to false 
                return $"Expected </{openTag}> found #";                                            // return the string
            }

            if(isPaired == true)                                                                    // if isPaired is true
            {                                                                                       // This means the paragraph is correctly tagged
                Console.Write("Correctly tagged paragraph\n");                                      // output "Correctly tagged paragraph" 
                return "Correctly tagged paragraph";                                                // return the string 
            }

            return "none";
        }
    }
}