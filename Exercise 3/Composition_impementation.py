class ConsoleDisplayController:
    def __init__(self):
        self.content = []

    def set_content(self, msg):
        self.content = msg

    def display(self):
        print(self.content)


class StartsWithStrategy:
    def __init__(self):
        self.start_string = ""

    def set_starts_with(self, key):
        self.start_string = key

    def invoke(self, item):
        return item.startswith(self.start_string)


class StringListFilterController:
    def __init__(self):
        self.predicate = StartsWithStrategy()

    def filter(self, string_list):
        filtered_array = []
        self.predicate.set_starts_with("a")
        for word in string_list:
            if self.predicate.invoke(word):
                filtered_array.append(word)
        return filtered_array


if __name__ == "__main__":
    arr = ["abc", "bcd", "acd"]

    string_list_filter_controller_obj = StringListFilterController()
    filtered_array = string_list_filter_controller_obj.filter(arr)

    console_display_controller_obj = ConsoleDisplayController()
    console_display_controller_obj.set_content(filtered_array)
    console_display_controller_obj.display()
