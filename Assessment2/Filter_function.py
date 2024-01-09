def is_number_even(number):
    if (number%2 == 0):
        return True
    else:
        return False

def filter_numbers(predicate, iterable):
    return [item for item in iterable if predicate(item)]
        
def display(numbers):
    for number in numbers:
        print(number)
        
def main():
    numbers = [2, 1, 4, 3, 6, 8, 5, 5, 10]
    result = filter_numbers(is_number_even, numbers)
    display(result)

if __name__ == "__main__":
    main()

