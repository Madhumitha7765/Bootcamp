from typing import List

class IObserver:
    def update(self, thread, thread_id):
        raise NotImplementedError

class Thread:
    def __init__(self):
        self.id = 0
        self.state = ""
        self.priority = ""
        self.culture = ""
        self.observers = []

    def notify_observers(self):
        for observer in self.observers:
            observer.update(self, self.id)

    def set_id(self, thread_id):
        self.id = thread_id

    def start(self):
        self.state = "Starting"
        self.notify_observers()

    def abort(self):
        self.state = "aborting"
        self.notify_observers()

    def sleep(self):
        self.state = "sleeping"
        self.notify_observers()

    def wait(self):
        self.state = "wait"
        self.notify_observers()

    def suspended(self):
        self.state = "suspended"
        self.notify_observers()

    def get_state(self):
        return self.state

    def subscribe(self, observer):
        self.observers.append(observer)

    def unsubscribe(self, observer):
        self.observers.remove(observer)

    def get_id(self):
        return self.id

class ConcreteObserver(IObserver):
    def update(self, thread, thread_id):
        print(f"Thread {thread_id} State: {thread.get_state()}")


def main():
    thread1 = Thread()
    thread2 = Thread()

    observer1 = ConcreteObserver()

    thread1.subscribe(observer1)
    thread1.set_id(1)
    thread1.start()

    thread2.subscribe(observer1)
    thread2.set_id(2)
    thread2.start()
    thread1.abort()
    thread2.wait()
    thread2.abort()

    thread1.unsubscribe(observer1)
    thread2.unsubscribe(observer1)

if __name__ == "__main__":
    main()
  
