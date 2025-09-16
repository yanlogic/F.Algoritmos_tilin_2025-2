def ejer1(): #creando método ejer1
    nombre = input("Ingrese su nombre (Python): ")
    carrera = input("Ingrese su carrera: ")
    print(nombre, ", bienvenido al curso de Fundamentos de Algoritmos de la carrera ", carrera)

def ejer2():
    print("\"Yanta\"")

def ejer3():
    x = int(input("Ingrese el valor de x: "))
    y = int(input("Ingrese  el valor de y: "))

    print("suma: ", (x+y))
    print("resta: ", (x-y))
    print("multiplicación: ", (x*y))
    print("división: ", (x/y))

import math #Importando la librería Math

def ejer4():
    num = float(input("Ingrese un número decimal: "))
    print("Raiz 2: ", math.sqrt(num))
    print("Redondeado: ", round(num,0))
    print("Al cubo: ", math.pow(num,3))
    print("Raiz 3: ", num ** (1/3))

def ejer5():
    num = input("Ingrese número: ")
    entero = int(num)
    deci = float(num)

    print("Resto: ", (entero%2))
    print("Division: ", (deci/3))


#Escribe un programa que solicite al usuario que ingrese un año y determine si es bisiesto o no, siguiendo lo siguiente:
#• Un año es bisiesto si es divisible entre 4 pero no si es divisible entre 100, excepto si también es divisible entre 400.
#• Además, el programa debe indicar si el año ingresado es par o impar.
def ejer6():

    annio = int(input("Ingrese el año: "))
    if (annio % 4 == 0 and annio % 100 != 0) or annio % 400 == 0:
        print("El año es bisiesto.")
    else:
        print ("EL año no es bisiesto.")

    if annio % 2 == 0:
        print("El año es par.")
    else: 
        print("El año es impar.")

#Desarrolla un programa usando switch que permita al usuario ingresar un monto en soles peruanos (PEN) y seleccionar a qué moneda desea convertirlo:
#Opción 1: Dólares (USD) - 1 USD = 3.75 PEN
#Opción 2: Euros (EUR) - 1 EUR = 4.05 PEN
def ejer7():
    monto = float(input("Ingrese el monto en soles: S/"))
    print("\n[1] - Dolares\n[2] - Euros")
    opcion = int(input("\nIngrese una opción: "))
    cambio = float
    total = float
    match opcion:
        case 1:
            cambio = 3.78
            print("Usted ha elegido Dólares.")
            print("Cambio: S/", cambio)

        case 2:
            cambio = 4.05
            print("Usted ha elegido Euros.")
            print("Cambio: S/", cambio)
        case _:
            print("Ingrese un número válido.")

    total = monto/cambio
    print("El cambio es de: ", total)

import math
#Implementa el algoritmo usando switch que te permita lo siguiente:
#• Si ingresa 1; área de un cuadrado.
#• Si Ingresa 2; área de un rectángulo.
#• Si ingresa 3; área de un triángulo.
#• Si Ingresa 4; área de un círculo. (el resultado redondeado a 2 decimales).
#• Caso contrario que muestre “Valor ingresado incorrecto”
def ejer8():
    print("Bienvenido al sistema de cálculos de áreas:\n")
    print("1. Cuadrado")
    print("2. Rectángulo")
    print("3. Triángulo")
    print("4. Círculo\n")

    opcion = int(input("Ingrese una opción: "))

    match opcion:
        case 1:
            lado = float(input("Ingrese un lado del círculo: "))
            print("Área: ", lado*lado)

        case 2:
            base = float(input("Ingrese la base del rectángulo: "))
            altura = float(input("Ingrese la altura del rectángulo: "))
            print("Área: ", base*altura)

        case 3:
            base2 = float(input("Ingrese la base del triángulo: "))
            altura2 = float(input("Ingrese la altura del triángulo: "))
            print("Área: ", (base2*altura2)/2)

        case 4:
            radio = float(input("Ingrese el radio del círculo: "))
            print("Área: ", (round(math.pi*radio**2),2))

        case _:
            print("Ingrese un número válido.")
ejer8()
