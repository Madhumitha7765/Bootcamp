def is_equal_to_5(number):
    if (number == 5):
        return True
    else:
        return False

def filter_number(predicate, iterable):
    return [item for item in iterable if predicate(item)]
        
def display(numbers):
    for number in numbers:
        print(number)

numbers = [2, 1, 4, 3, 6, 8, 5, 5, 10]
result = filter_number(is_equal_to_5, numbers)
display(result)

