def is_equal_to_search_element(element):
    return element == search_element

def custom_filter(predicate, iterable):
    return [item for item in iterable if predicate(item)]

sample_array = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
search_element = 5

filtered_array = custom_filter(is_equal_to_search_element, sample_array)

print(filtered_array)
