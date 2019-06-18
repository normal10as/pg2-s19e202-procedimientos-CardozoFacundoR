Imports System.DateTime
Module AhoraEs
	Sub Main(args As String())
		Dim hoy As DateTime = Now
		FechaActual()
		HoraActual(hoy)
		Console.ReadKey()
	End Sub

	Public Sub FechaActual()
		Dim fecha As DateTime = Today
		Console.WriteLine("La fecha actual es: {0}/{1}/{2} ", fecha.Day, fecha.Month, fecha.Year)
	End Sub
	Public Function HoraActual(hoy As DateTime) As DateTime
		Console.WriteLine("La hora actual es: {0}/{1}/{2} ", hoy.Hour, hoy.Minute, hoy.Second)
		Return hoy
	End Function
End Module

'2.1.Crear un proyecto y un módulo llamado “AhoraEs” que imprimala fechay hora actual con sus respectivas leyendas
'según los siguientes requerimientos:
'•Utilizar una sub para imprimir la fecha actual.
'•Utilizar una function para obtener la hora actual.
'•Llamar a los procedimientosdesde el Main