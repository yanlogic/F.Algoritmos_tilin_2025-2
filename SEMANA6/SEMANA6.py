#Realizar un programa que realice la tabla de multiplicar 1-12. Solicitando al
#usuario el numero de la tabla a realizar. No realizar la tabla de un número
#negativo o la tabla del 0, si el usuario lo ingresa volver a solicitar el número

num = int(input("Ingrese un número positivo: "))
i = 1
print()

while num<=0:
    num = int(input("Error. Ingrese un número positivo: "))

while i <= 12:
    print(f"{i} x {num} = {i*num}")
    i+=1