### Test Case Specification for String Calculator

#### Test Case 1: Empty String

- **Given**: An empty string
- **When**: The `Add` method is called with the empty string as input
- **Then**: The method should return 0.

#### Test Case 2: Single Number

- **Given**: A string containing a single number "1"
- **When**: The `Add` method is called with the input string
- **Then**: The method should return 1.

#### Test Case 3: Two Numbers

- **Given**: A string containing two numbers "1,2"
- **When**: The `Add` method is called with the input string
- **Then**: The method should return the sum of the numbers, which is 3.

#### Test Case 4: New Lines

- **Given**: A string with numbers separated by new lines and commas "1\n2,3"
- **When**: The `Add` method is called with the input string
- **Then**: The method should return the sum of the numbers, which is 6.

#### Test Case 5: Custom Delimiter

- **Given**: A string with a custom delimiter "//;\n1;2"
- **When**: The `Add` method is called with the input string
- **Then**: The method should return the sum of the numbers using the custom delimiter, which is 3.

#### Test Case 6: Negative Numbers

- **Given**: A string with negative numbers "-1,2,-3"
- **When**: The `Add` method is called with the input string
- **Then**: The method should throw an exception with the message "Negatives not allowed: -1, -3".

#### Test Case 7: Ignore Numbers Greater Than 1000

- **Given**: A string with a number greater than 1000 "2 + 1001"
- **When**: The `Add` method is called with the input string
- **Then**: The method should ignore numbers greater than 1000 and return 2.

#### Test Case 8: Delimiters of Any Length

- **Given**: A string with a custom delimiter of any length "//[]\n12***3"
- **When**: The `Add` method is called with the input string
- **Then**: The method should return the sum of the numbers using the custom delimiter, which is 6.

#### Test Case 9: Multiple Delimiters

- **Given**: A string with multiple delimiters "//[][%]\n12%3"
- **When**: The `Add` method is called with the input string
- **Then**: The method should return the sum of the numbers using any of the specified delimiters, which is 6.

#### Test Case 10: Multiple Delimiters with Length Greater Than One

- **Given**: A string with multiple delimiters with length greater than one "//[delim1][delim2]\n1delim12delim23"
- **When**: The `Add` method is called with the input string
- **Then**: The method should return the sum of the numbers using any of the specified delimiters, which is 6.

#### Test Case 11: One Valid, One Invalid Number

- **Given**: A string with one valid number and one invalid number "1,-2"
- **When**: The `Add` method is called with the input string
- **Then**: The method should return the valid input number, which is 1.
