#Realizar un programa que permita ingresar números enteros positivos hasta
#que el usuario ingresa el valor de 0 (si ingresa negativos volver a solicitar),
#luego mostrar la suma de los pares e impares.
sumap = sumai = 0

while True:
    num = int(input("Ingrese un número positivo (0 salir): "))
    if num<0:
        print("Número inválido. Ingrese nuevamente.")
        continue

    if num == 0:
        break

    if num % 2 == 0:
        sumap += num
    else:
        sumai += num

print("\nSuma de pares: ", sumap)
print("Suma de impares: ", sumai)
    