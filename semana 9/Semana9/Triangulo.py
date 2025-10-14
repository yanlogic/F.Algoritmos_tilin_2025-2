class Triangulo:
    def area(self)->None: #Representa vacío
         b = int(input("Ingrese la base: "))
         h = int(input("Ingrese la altura: "))
         print("\nArea: ", (b * h)/2)

    def perimetro(self)->None:
        lado1 = int(input("\nIngrese lado 1: "))
        lado2 = int(input("Ingrese lado 2: "))
        lado3 = int(input("Ingrese lado 3: "))
        print("\nPerímetro: ", lado1 + lado2 + lado3)