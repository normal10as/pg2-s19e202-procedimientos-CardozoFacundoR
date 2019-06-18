Imports System

Module VolumenCilindro
	Sub Main(args As String())
		Const pi As Double = 3.14159265
		Dim Base, Altura As Double
		Console.Write("Ingrese Base del cilindro: ")
		Base = Console.ReadLine
		Console.Write("Ingrese Altura del cilindro: ")
		Altura = Console.ReadLine
		Console.WriteLine("El volumen Del cilindro es: " & CalcularVolumen(Base, Altura, pi))
		Console.ReadKey()

	End Sub
	Private Function CalcularVolumen(r As Double, h As Double, pi As Double) As Double
		Dim Volumen As Double
		Volumen = pi * r ^ 2 * h
		Return Volumen
	End Function
End Module
'2.4.Crear un proyecto y un módulo llamado “VolumenCilindro” que implemente una función que lea el radio de la base 
'y la altura de un cilindro y que calcule y devuelva el volumen. El volumen de un cilindro se calcula multiplicando 
'la constante Pi (π=3.14159265) por el cuadrado del radio de la base(r) por la altura(h) de lo que se da la 
'siguiente fórmula : v = πr²h. Ingresar los valores por teclado y mostrar el resultado en consola.  