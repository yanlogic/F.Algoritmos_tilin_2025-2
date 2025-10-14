from Triangulo import Triangulo
from Cuadrado import Cuadrado
t = Triangulo()
c = Cuadrado()

def menu1()->None:
    print("\nBIENVENIDOS A CÁLCULOS DE ÁREAS Y PERÍMETROS")
    print("\n************* Menú de opciones *************")
    print("*               1. Triángulo               *")
    print("*               2. Cuadrado                *")
    print("*               3. Rectángulo              *")
    print("*               4. Trapecio                *")
    print("*               0. SALIR                   *")
    print("********************************************")

def menu2()->int:
    print("\n********** Seleccione cálculo **********")
    print("*            1. Área                   *")
    print("*            2. Perímetro              *")
    print("****************************************")

    opcion = int(input("Ingrese una opción: "))
    return opcion

while True:
    menu1()
    while True:
        opcion = int(input("Ingrese opción: "))

        if opcion in (0,1,2,3,4): break
        else: print("Error. Opción no válida.\n")

    match opcion:
        case 0: exit() #quit()
        case 1: 
             opc = menu2()
             match opc:
                  case 1: t.area()
                  case 2: t.perimetro()
        case 2: 
            opc = menu2()
            l = int(input("\nIngrese un lado: "))
            match opc:
                  case 1: c.area(l);
                  case 2: c.perimetro(l);
        case 3: print()
        case 4: print()

    while True:
        conti = input("¿Desa continuar? (S/N): ")
        if conti.lower() in("s","n"):break
        else: print("Error. Solo 'S' o 'N'.")

    if conti.lower() == "n": break
