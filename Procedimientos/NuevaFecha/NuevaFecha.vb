Imports System.DateTime

Module NuevaFecha
	Sub Main(args As String())
		Dim fecha As DateTime = Now
		Dim Dias As Integer
		Console.Write("Ingrese una cantidad de dias a sumar a la fecha actual: ")
		Dias = Console.ReadLine
		SumaFechas(fecha, Dias)
		Console.ReadKey()
	End Sub
	Private Function SumaFechas(fecha As DateTime, Dias As Integer) As DateTime
		Console.WriteLine("La fecha es: " & fecha)
		Console.WriteLine("Cantidad a sumar: {0} dias.", Dias)
		Console.WriteLine("La fecha sumada es " & fecha.AddDays(Dias))
		Return fecha
	End Function

End Module

'2.2.Crear un proyecto y un módulo llamado “Nueva_fecha” con una función que reciba un valor fecha y 
'un valor entero que representa una cantidad de días y retorne a la fecha sumada la cantidad de días. 
'En el módulo principal ingresar una fecha y la cantidad de días,invocar a la función creada y
'mostrar el valor obtenido.