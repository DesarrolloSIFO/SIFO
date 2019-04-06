Imports System.Data
Imports System.Data.SqlClient
Module Conexion
    Public Cn As New SqlConnection("Data Source=.\SQLExpress;Initial Catalog=OpticaDb;Integrated Security=True")
End Module
