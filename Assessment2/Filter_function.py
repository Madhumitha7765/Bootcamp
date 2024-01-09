import math

def isPerfectSquare(x):
    s = int(math.sqrt(x))
    return s*s == x
 
def is_fibonacci_number(n):
    return isPerfectSquare(5*n*n + 4) or isPerfectSquare(5*n*n - 4)

def filter_fibonacci_numbers(predicate, iterable):
    return [item for item in iterable if predicate(item)]
        
def display(numbers):
    for number in numbers:
        print(number)
        
def main():
    numbers = [2, 1, 4, 3, 6, 8, 5, 5, 10]
    result = filter_fibonacci_numbers(is_fibonacci_number, numbers)
    display(result)

if __name__ == "__main__":
    main()

