def ejer1():
    edad = int(input("Ingrese una edad: "))
    if edad < 18:
        print("Menor de edad.")
    else:
        if edad >= 18 and edad <= 64:
            print("Es adulto.")
        else:
            print("Adulto mayor.")


def ejer2():
    n = int(input("Ingrese un número: "))
    suma = 0

    for i in range(1, n+1):
        print(i)

        if i % 2 == 0:
            suma += i

    print("\nSuma de pares: ", suma)

def ejer3():
    cant = int(input("Ingrese la cantidad de números: "))
    ceros = pares = impares = 0
    print()
    for i in range(1, cant+1):
        num = int(input(f"Ingrese el número {i}: "))

        if num == 0:
            ceros+= 1
        elif num % 2 == 0:
            pares += 1
        else:
            impares += 1

    print("\nNúmero de 0: ", ceros)
    print("Número de pares: ", pares)
    print("Número de impares: ", impares)

ejer3()
