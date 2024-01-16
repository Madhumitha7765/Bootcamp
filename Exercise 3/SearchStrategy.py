class StringFilter:
    def __init__(self, string_array):
        self.string_array = string_array

    def filter(self, checking_criteria):
        return [string for string in self.string_array if checking_criteria.check(string)]


class StartsWithChecker:
    def __init__(self, start_char):
        self.start_char = start_char.lower()

    def check(self, string_item):
        return string_item.lower().startswith(self.start_char)


class EndsWithChecker:
    def __init__(self, end_char):
        self.end_char = end_char.lower()

    def check(self, string_item):
        return string_item.lower().endswith(self.end_char)


class DisplayResults:
    def __init__(self, array_of_results):
        self.results = array_of_results

    def display(self):
        for result in self.results:
            print(result)


def main():
    strings = ["Hello", "testing", "Orientation", "Hi", "Programming"]

    string_filter = StringFilter(strings)

    starts_with_checker = StartsWithChecker('p')
    starts_with_criteria = starts_with_checker
    starts_with_result = string_filter.filter(starts_with_criteria)

    results = DisplayResults(starts_with_result)
    results.display()


if __name__ == "__main__":
    main()
