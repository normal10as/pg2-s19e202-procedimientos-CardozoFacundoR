Imports System

Module SuperficieFiguras
	Sub Main(args As String())
		Dim Lado, Altura, Base, BaseMenor As Double
		Console.Write("Ingrese lado: ")
		Lado = Console.ReadLine
		Console.Write("Ingrese altura: ")
		Altura = Console.ReadLine
		Console.Write("Ingrese Base: ")
		Base = Console.ReadLine
		Console.Write("Ingrese Base Menor: ")
		BaseMenor = Console.ReadLine

		Console.WriteLine("El area del cuadrado es: " & CalcularArea(Lado) & vbCrLf)
		Console.WriteLine("El area del rectangulo es: " & calcularArea(Altura, Base) & vbCrLf)
		Console.WriteLine("El area del trapecio es: " & calcularArea(Altura, Base, BaseMenor) & vbCrLf)

		Console.ReadKey()
	End Sub
	Private Function CalcularArea(lado As Double) As Double
		Return (lado * lado)
	End Function
	Private Function calcularArea(altura As Double, base As Double) As Double
		Return (altura * base)
	End Function
	Private Function calcularArea(altura As Double, base As Double, BaseMenor As Double) As Double
		Return (((base + BaseMenor) / 2) * altura)
	End Function
End Module
'2.8.Crear un proyecto y un módulo llamado “SuperficieFiguras” para calcular la superficie de una figura.
'Los valores se ingresan por consola Usar una función sobrecargada para resolver el área y según el número
'de parámetros será: 
'cuadrado  area = lado * lado
'rectangulo area = Base * altura
'trapecio area = B+b / 2 * altura