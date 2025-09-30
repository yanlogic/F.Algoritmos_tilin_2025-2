while True:
    suma = 0
    num = int(input("Ingrese un número positivo: "))
    for i in range(1, num+1): #en el "for" se suma +1
        suma += i
        print(i, end = " ")
        
    print("\nSuma: ", suma)
    opc = input("¿Desea continuar? (S/N): ")
    if (opc.upper() == "N"): break


