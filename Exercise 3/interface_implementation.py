from abc import ABC, abstractmethod

class SearchStrategy(ABC):
    @abstractmethod
    def invoke(self, item):
        pass


class StartsWithStrategy(SearchStrategy):
    def __init__(self):
        self.start_string = ""

    def set_starts_with(self, key):
        self.start_string = key

    def invoke(self, item):
        return item.startswith(self.start_string)


class StringListFilterController:
    def __init__(self, search_strategy):
        self.predicate = search_strategy

    def filter(self, string_list):
        filtered_array = []
        self.predicate.set_starts_with("b")
        for word in string_list:
            if self.predicate.invoke(word):
                filtered_array.append(word)
        return filtered_array


class ConsoleDisplayController:
    def __init__(self):
        self.content = []

    def set_content(self, msg):
        self.content = msg

    def display(self):
        print(self.content)


if __name__ == "__main__":
    arr = ["abc", "bcd", "acd"]

    search_strategy_obj = StartsWithStrategy()

    string_list_filter_controller_obj = StringListFilterController(search_strategy_obj)
    filtered_array = string_list_filter_controller_obj.filter(arr)

    console_display_controller_obj = ConsoleDisplayController()
    console_display_controller_obj.set_content(filtered_array)
    console_display_controller_obj.display()
