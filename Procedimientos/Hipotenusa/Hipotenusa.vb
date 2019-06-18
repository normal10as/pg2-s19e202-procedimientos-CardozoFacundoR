Imports System.Math

Module Hipotenusa
	Sub Main(args As String())
		Dim LadoA, LadoB As Double
		Console.Write("Ingresar lado A: ")
		LadoA = Console.ReadLine
		Console.Write("Ingresar lado B: ")
		LadoB = Console.ReadLine
		Console.Write("La hipotenusa es: " & CalcularHipotenusa(LadoA, LadoB))
		Console.ReadKey()
	End Sub
	Private Function CalcularHipotenusa(a As Double, b As Double) As Double
		Dim c As UShort
		c = (a ^ 2) + (b ^ 2)
		Return c
	End Function
End Module
'2.3.Crear un proyecto y un módulo llamado “Hipotenusa” que implemente una función que reciba
'el tamaño de los lados A y B, calcule y devuelva C (hipotenusa). Dados los lados A y B de un triángulo rectángulo,
'según el teorema de Pitágoras, el cuadrado de la hipotenusa (C), es igual a la suma del cuadrado de los catetos (lados)
'de lo que se da la siguiente fórmula: c² = a² + b². Ingresar los valores por teclado y mostrar el resultado en consola.