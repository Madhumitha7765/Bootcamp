from injector import inject, Module, Binder, Injector

class IEngine:
    def start(self):
        pass

class ITransmission:
    def shift(self):
        pass

class IStartupMotor:
    def start_motor(self):
        pass

class IFuelPump:
    def pump_fuel(self):
        pass

class IPrinter:
    def print_message(self, message):
        pass

class ConsolePrinter(IPrinter):
    def print_message(self, message):
        print(message)

class Engine(IEngine):
    @inject
    def __init__(self, startup_motor: IStartupMotor, fuel_pump: IFuelPump, printer: IPrinter):
        self.startup_motor = startup_motor
        self.fuel_pump = fuel_pump
        self.printer = printer

    def start(self):
        self.startup_motor.start_motor()
        self.fuel_pump.pump_fuel()
        self.printer.print_message("Engine started.")

class Transmission(ITransmission):
    @inject
    def __init__(self, printer: IPrinter):
        self.printer = printer

    def shift(self):
        self.printer.print_message("Transmission shifted.")

class StartupMotor(IStartupMotor):
    @inject
    def __init__(self, printer: IPrinter):
        self.printer = printer

    def start_motor(self):
        self.printer.print_message("Startup motor started.")

class FuelPump(IFuelPump):
    @inject
    def __init__(self, printer: IPrinter):
        self.printer = printer

    def pump_fuel(self):
        self.printer.print_message("Fuel pump activated.")

class Car(ICar):
    @inject
    def __init__(self, engine: IEngine, transmission: ITransmission, printer: IPrinter):
        self.engine = engine
        self.transmission = transmission
        self.printer = printer

    def drive(self):
        self.engine.start()
        self.transmission.shift()
        self.printer.print_message("Car is now driving.")

class MyAppModule(Module):
    def configure(self, binder: Binder):
        binder.bind(IStartupMotor, to=StartupMotor)
        binder.bind(IFuelPump, to=FuelPump)
        binder.bind(IEngine, to=Engine)
        binder.bind(ITransmission, to=Transmission)
        binder.bind(ICar, to=Car)
        binder.bind(IPrinter, to=ConsolePrinter)

if __name__ == '__main__':
    injector = Injector([MyAppModule()])
    my_car = injector.get(ICar)
    my_car.drive()
