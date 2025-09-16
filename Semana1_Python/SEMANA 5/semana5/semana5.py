def ejer1():
    #Desarrollar un algoritmo donde se le solicita al usuario que ingrese su edad y se
    #determinará si es elegible para votar y si es elegible para ser candidato a un
    #cargo político. La edad mínima para votar es de 18 años y la edad mínima para
    #ser candidato a un cargo político es de 25 años.
    edad = int(input("Buen día. Ingrese su edad: "))
    if edad >= 18:
        print("Puede votar.")
    elif edad >= 25:
        print("Puede ser candidato.")
    else:
        print("Aún eres un tilin. Tienes DNI amarillo.")

def ejer2():
    #Se pide ingresar 3 valores numéricos e indicar que tipo de triangulo es dado las
    #siguientes condiciones:
    #• Si los tres valores son iguales “TRIANGULO EQUILÁTERO”.
    #• Si solo 2 valores son iguales “TRIANGULO ISÓSCELES”.
    #• Si son diferentes “TRIANGULO ESCALENO”.
    num1 = float(input("Ingrese el primer valor numérico de su triangulo: "))
    num2 = float(input("Ingrese el segundo valor numérico de su triangulo: "))
    num3 = float(input("Ingrese el tercer valor numérico de su triangulo: "))
    if num1 == num2 == num3:
        print("Su triángulo es equilátero.")
    elif num1 == num2 or num1 == num3 or num2 == num3:
        print("Su triángulo es isósceles.")
    else:
        print("Su triángulo es escaleno.")
ejer2()

