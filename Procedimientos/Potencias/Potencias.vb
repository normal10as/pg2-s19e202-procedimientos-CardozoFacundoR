Imports System

Module Potencias
	Sub main()
		Dim Valor As Double
		Console.Write("Ingrese un valor: ")
		Valor = Console.ReadLine
		Console.WriteLine("El numero ingresado es: " & Valor)
		Console.WriteLine("Elevador a la segunda potencia es: " & CalcularPotencias(Valor, 2))
		Console.WriteLine("Elevador a la tercer potencia es: " & CalcularPotencias(Valor, 3))
		Console.WriteLine("Elevador a la quinta potencia es: " & CalcularPotencias(Valor, 5))
		Console.ReadKey()
	End Sub
	Private Function CalcularPotencias(valor As Double, potencia As Byte) As Double
		Dim resultado As Double
		resultado = valor ^ potencia
		Return resultado
	End Function
End Module
'2.5.Crear un proyecto y un módulo llamado “Potencias” que implemente una función que retornará la primera vez
'que es invocada el valor al cuadrado, la siguiente vez el valor al cubo y así sucesivamente. Ingresar por teclado
'un valor numérico y mostrar ese valor elevado a la 2°, 3° y 5° potencias. Por ejemplo, ingresando 3 mostrar: 9, 27 y 243.  