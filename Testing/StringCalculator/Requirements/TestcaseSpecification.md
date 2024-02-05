Test Case 1: Empty String

Input: ""
Expected Output: 0

Test Case 2: Single Number

Input: "1"
Expected Output: 1

Test Case 3: Two Numbers

Input: "1,2"
Expected Output: 3

Test Case 4: New Lines

Input: "1\n2,3"
Expected Output: 6

Test Case 5: Custom Delimiter

Input: "//;\n1;2"
Expected Output: 3

Test Case 6: Negative Numbers

Input: "-1,2,-3"
Expected Output: Throws exception with message "Negatives not allowed: -1, -3"

Test Case 7: Ignore Numbers Greater Than 1000

Input: "2 + 1001"
Expected Output: 2

Test Case 8: Delimiters of Any Length

Input: "//[]\n12***3"
Expected Output: 6

Test Case 9: Multiple Delimiters

Input: "//[][%]\n12%3"
Expected Output: 6

Test Case 10: Multiple Delimiters with Length Greater Than One

Input: "//[delim1][delim2]\n1delim12delim23"
Expected Output: 6
Test Case 11: One Valid, One Invalid Number

Input: "1,abc"
Expected Output: Throws exception with message "Invalid input format"
