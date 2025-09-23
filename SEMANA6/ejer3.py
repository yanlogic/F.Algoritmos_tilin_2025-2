#Realizar un programa que imprima con asteriscos un rectángulo, solicitando
#al usuario el número de columnas y filas. Tener en cuenta que puede haber
#dos o más estructuras repetitivas “while”.

filas = int(input("Ingrese número de filas: "))
columnas = int(input("Ingrese número de columnas: "))
print()
i = 0
while i < filas:
    j = 0
    while j < columnas: 
        print("*", end = " ")
        j+=1
    print()
    i+=1