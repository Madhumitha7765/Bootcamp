def is_equal_to_5(number):
    if (number == 5):
        return True
    else:
        return False

def custom_filter(predicate, iterable):
    return [item for item in iterable if predicate(item)]
        
def display(numbers):
    for number in numbers:
        print(number)

numbers = [2, 1, 4, 3, 6, 8, 5, 5, 10]
result = custom_filter(is_equal_to_5, numbers)
display(result)

