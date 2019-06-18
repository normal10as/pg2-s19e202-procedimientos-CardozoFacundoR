Imports System

Module Sumas
	Sub Main(args As String())
		Dim valor1, valor2, valor3, valor4 As UShort
		Console.Write("Ingrese primer valor: ")
		valor1 = Console.ReadLine
		Console.Write("Ingrese segundo valor: ")
		valor2 = Console.ReadLine
		Console.Write("Ingrese tercer valor: ")
		valor3 = Console.ReadLine
		Console.Write("Ingrese cuarto valor: ")
		valor4 = Console.ReadLine
		Console.WriteLine("Suma dos valores: " & Suma(valor1, valor2))
		Console.WriteLine("Suma tres valores: " & suma(valor1, valor2, valor3))
		Console.WriteLine("Suma cuatro valores: " & suma(valor1, valor2, valor3, valor4))


		Console.ReadKey()
	End Sub
	Private Function Suma(valor1 As UShort, valor2 As UShort)
		Return valor1 + valor2
	End Function
	Private Function suma(valor1 As UShort, valor2 As UShort, valor3 As UShort)
		Return valor1 + valor2 + valor3
	End Function
	Private Function suma(valor1 As UShort, valor2 As UShort, valor3 As UShort, valor4 As UShort)
		Return valor1 + valor2 + valor3 + valor4
	End Function
End Module
'2.7.Crear un proyecto y un módulo llamado “Sumas” que implementa una función sobrecargada capaz de sumar
'dos, tres y cuatro valores de acuerdo al número de argumentos que recibe. Invocarla desde el módulo main
'probando las diferentes alternativas y mostrando los resultados por consola. Ej.: sumar(5, 8).Minimizar
'la repetición de código. 