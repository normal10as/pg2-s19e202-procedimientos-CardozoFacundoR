Imports System

Module Acumuladora
	Sub Main(args As String())
		Dim contador, valor As Decimal
		Console.Write("Ingresar un valor decimal: ")
		valor = Console.ReadLine()
		Acumular(valor, contador)
		Console.Write("Ingresar un valor decimal: ")
		valor = Console.ReadLine()
		Acumular(valor, contador)
		Console.Write("Ingresar un valor decimal: ")
		valor = Console.ReadLine()
		Acumular(valor, contador)
		Console.ReadLine()
	End Sub
	Sub Acumular(valor As Decimal, ByRef contador As Decimal)
		contador = contador + valor
		Console.WriteLine("El valor acumulado es: " & contador)
	End Sub
End Module
'2.6.Crear un proyecto y un módulo llamado “Acumuladora” que implemente una subrutina que recibe un valor decimal
'y lo va acumulando. Invocar por lo menos tres veces la subrutina desde el main y mostrar luego de cada llamada
'mostrar el valor acumulado.