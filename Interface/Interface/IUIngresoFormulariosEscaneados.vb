'Hay que importar la referencia (COM) Microsoft Office Document Imaging 12.0 Type Library
'La version 12.0 es para el Office 2007. Si tenemos el Office 2003 la versión
'de la referencia que tenemos que importar será la 11.0
'Hay que compilar para x86 ya que la librería MODI es de 32 bits
Imports MODI
Imports Dominio, Inicio.IUMenu
Imports System.Drawing.Image
Imports System.IO
Imports System.Collections.ObjectModel



Public Class IUIngresoFormulariosEscaneados

    ' Delegado para el método GetThumbnailImage  
    Dim CallBack As New GetThumbnailImageAbort(AddressOf MycallBack)
    Dim petterns() As String = {"*.png", "*.jpg", "*.bmp", "*.gif", "*.ico"}
    Dim b As Bitmap

    Function MycallBack() As Boolean
        Return False
    End Function

    Private fileToOCR As String = ""

    Private Sub IUIngresoFormulariosEscaneados_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        unafachada.QuitarVentanaAbierta("IUIngresoFormulariosEscaneados")
    End Sub
    Private Sub IUIngresoFormulariosEscaneados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        listar_archivos(Me.txtRuta.text, ListBox1)
    End Sub

    Function CarpetaTEMP_Windows() As String
        Dim s As String
        s = IO.Path.GetTempPath
        If s.EndsWith("\") = False Then s &= "\"
        Return s
    End Function

    Private Sub BtnImagen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnImagen.Click
        Dim fileDlg As New OpenFileDialog
        fileDlg.Filter = "*.bmp;*.gif;*.jpg;*.png|*.bmp;*.gif;*.jpg;*.png"
        fileDlg.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        fileDlg.Title = "Selecciona el archivo para realizar el OCR"
        If fileDlg.ShowDialog = Windows.Forms.DialogResult.OK Then
            convertirArchivo(ListBox1.SelectedItem.ToString)
        End If

    End Sub

    Public Sub convertirArchivo(ByVal pNombreArchivo As String)
        fileToOCR = pNombreArchivo
        Dim dataString As String = ""
        If IO.Path.GetExtension(fileToOCR.ToLower).EndsWith("bmp") = False Then
            Try
                ConvertToBMP()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Exit Sub
            End Try
        End If

        b = Thumbnail.MakeThumbnail_FixedSize(fileToOCR, PictureBox1.Width, PictureBox1.Height, Color.White)
        If IsNothing(b) = False Then
            PictureBox1.Width = b.Width
            PictureBox1.Height = b.Height
            PictureBox1.Image = b
        End If

        Cursor = Cursors.WaitCursor
        If OCRText(fileToOCR, dataString) Then
            Cursor = Cursors.Default
            TextBox1.Text = dataString
        Else
            Cursor = Cursors.Default
            MessageBox.Show("Ocurrió un error al ejecutar el OCR")
        End If
        b.Dispose()

    End Sub

    Public Function convertirArchivoxPartes(ByVal pNombreArchivo As String) As String
        Dim retorno As String
        fileToOCR = pNombreArchivo
        Dim dataString As String = ""
        If IO.Path.GetExtension(fileToOCR.ToLower).EndsWith("bmp") = False Then
            Try
                ConvertToBMP()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Exit Function
            End Try
        End If

        'Dim b As Bitmap = Thumbnail.MakeThumbnail_FixedSize(fileToOCR, PictureBox1.Width, PictureBox1.Height, Color.White)
        'If IsNothing(b) = False Then
        '    PictureBox1.Width = b.Width
        '    PictureBox1.Height = b.Height
        '    PictureBox1.Image = b
        'End If

        Cursor = Cursors.WaitCursor
        If OCRText(fileToOCR, dataString) Then
            Cursor = Cursors.Default
            retorno = dataString
            Return retorno
        Else
            Cursor = Cursors.Default
            ' MessageBox.Show("Ocurrió un error al ejecutar el OCR")
        End If
    End Function


    Private Sub ConvertToBMP()
        Try
            Dim FILE_converted As String = CarpetaTEMP_Windows() & "tmpFormulario.bmp"
            If IO.File.Exists(FILE_converted) Then
                IO.File.Delete(FILE_converted)
            End If


            b = System.Drawing.Image.FromFile(fileToOCR)

            b.Save(FILE_converted)
            fileToOCR = FILE_converted
            b.Dispose()

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Function OCRText(ByVal Imagen As String, ByRef TextOCR As String) As Boolean
        Try
            Dim md As MODI.Document

            md = New MODI.Document
            md.Create(Imagen)

            'md.OCR(MiLANGUAGES.miLANG_SYSDEFAULT, True, True)
            md.OCR(MiLANGUAGES.miLANG_ENGLISH, True, True)

            Dim image As MODI.Image = md.Images(0)
            Dim layout As MODI.Layout = image.Layout
            TextOCR = layout.Text

            'LblWordsCount.Text = layout.Words.Count - 1

            'For i As Integer = 0 To layout.Words.Count - 1
            '    Dim ocrWord As MODI.Word = layout.Words(i)
            '    Captcha &= ocrWord.Text
            'Next

            md.Close()
            Return True

        Catch ex As Exception
            Return False
        End Try
    End Function


    Private Sub TextBox1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.Resize
        If fileToOCR <> "" Then
            PictureBox1.Width = SplitContainer1.Width
            PictureBox1.Height = SplitContainer1.Height

            b = Thumbnail.MakeThumbnail_FixedSize(fileToOCR, PictureBox1.Width, PictureBox1.Height, Color.White)
            If IsNothing(b) = False Then
                'PictureBox1.Width = b.Width
                'PictureBox1.Height = b.Height
                PictureBox1.Image = b
            End If
        End If
    End Sub

    Private Sub SplitContainer1_Panel1_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles SplitContainer1.Panel1.Paint

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.TextBox1.Text = RecortarRectanguloConvertir(Me.Dud1.Value, Me.Dud2.Value, Me.Dud3.Value, Me.Dud4.Value)
    End Sub

    Public Function RecortarRectanguloConvertir(ByVal A As Integer, ByVal B As Integer, ByVal C As Integer, ByVal D As Integer) As String
        Dim FILE_converted As String = CarpetaTEMP_Windows() & "tmpFormulario.bmp"
        Dim imagenOriginal As Bitmap
        imagenOriginal = System.Drawing.Image.FromFile(FILE_converted)
        Dim imagen2 As New Bitmap(C, D)
        Dim lienzo As Graphics = Graphics.FromImage(imagen2)

        Try
            Dim recorte As New Rectangle(A, B, C, D)
            lienzo.DrawImage(imagenOriginal, 0, 0, recorte, GraphicsUnit.Pixel)
            Me.PictureBox2.Image = imagen2
            'Dim pixelColor2 As Color = imagen2.GetPixel(nudX.Value, nudY.Value)
            'Me.txtColor.Text = pixelColor2.ToString
            'picBoxOutPut.BackColor = pixelColor2
        Catch
            MessageBox.Show("Surgio un Error, faltan elegir las coordenadas", "System Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End Try
        imagenOriginal.Dispose()
        PictureBox2.Image.Save("C:\image.bmp", System.Drawing.Imaging.ImageFormat.Bmp)
        Me.TextBox1.Text = ""
        Return convertirArchivoxPartes("C:\image.bmp")

    End Function


    Public Shared Function PixelColor(ByVal x As Integer, ByVal y As Integer) As Color

    End Function

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        convertirArchivo(ListBox1.SelectedItem.ToString)
        Me.lsDispositivos.Items.Clear()
        Dim i As Integer = 0
        Dim numeroTotalCaravanas As Integer = Me.nudLecturas.Value
        Dim inicioY As Integer = unafachada.BuscarParametros("EscaneoInicio").ValorParametro
        Dim largoNumDispositivo As Integer = unafachada.BuscarParametros("EscaneoLargoNumDispositivo").ValorParametro
        While i < numeroTotalCaravanas
            Dim linea As String = ""
            Dim numDispositivo As String = RecortarRectanguloConvertir(20, inicioY, largoNumDispositivo, 79)
            If Not numDispositivo Is Nothing Then
                linea &= i & "- " & numDispositivo & " | Sexo: "
            End If

            RecortarRectanguloConvertir(490, inicioY, 55, 79)
            Dim CantidadMacho As Integer = ContarCantidadPuntos("f")

            RecortarRectanguloConvertir(545, inicioY, 55, 79)
            Dim CantidadHembra As Integer = ContarCantidadPuntos("f")

            If CantidadHembra > CantidadMacho Then
                If Not numDispositivo Is Nothing Then
                    linea &= "M"
                End If
            Else
                If Not numDispositivo Is Nothing Then
                    linea &= "H"
                End If
            End If
            Dim raza As String = RecortarRectanguloConvertir(600, inicioY, 99, 79)
            linea &= " | Raza: " & raza
            Dim cruza As String = RecortarRectanguloConvertir(700, inicioY, 99, 79)
            linea &= " | Cruza: " & cruza
            Dim mes As String = RecortarRectanguloConvertir(880, inicioY, 110, 79)
            linea &= " | Mes: " & mes
            Dim ano As String = RecortarRectanguloConvertir(980, inicioY, 110, 79)
            linea &= " | Año: " & ano & vbCrLf
            Me.lsDispositivos.Items.Add(linea)
            inicioY += 79
            i += 1
        End While
    End Sub

    Public Function ContarCantidadPuntos(ByVal pNombreColor As String)
        'Este primer bloque, guarda los niveles digitales de la imagen en la variable Niveles
        Dim colorActual As Color
        Dim i, j As Long
        Dim cantidadPuntos As Integer = 0
        ' ReDim Niveles(PictureBox1.Image.Width - 1, PictureBox1.Image.Height - 1)  'Asignamos a la matriz las dimensiones de la imagen -1 *
        Dim bmp As New Bitmap(PictureBox2.Image)  'Creamos un objeto de la clase Bitmap
        For i = 0 To PictureBox2.Image.Width - 1 'Recorremos la matriz a lo ancho
            For j = 0 To PictureBox2.Image.Height - 1 'Recorremos la matriz a lo largo
                colorActual = bmp.GetPixel(i, j) 'Con el método GetPixel, asignamos para cada celda de la matriz el color con sus valores RGB.
                Dim comienzoColor As String = ""
                If colorActual.Name <> "0" Then
                    comienzoColor = colorActual.Name.Substring(4, 1)
                End If
                If comienzoColor = pNombreColor Then
                    cantidadPuntos += 1
                End If
            Next

        Next
        Return cantidadPuntos
    End Function

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        MsgBox(ContarCantidadPuntos("f"))
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles btnSeleccionar.Click


        ' Crear un FolderBrowserDialog para seleccionar una carpeta  
        Dim folder_Browser As New FolderBrowserDialog

        With folder_Browser
            If .ShowDialog <> Windows.Forms.DialogResult.OK Then
                Exit Sub
            End If
        End With

        ListBox1.Items.Clear()
        Me.Cursor = Cursors.WaitCursor
        Application.DoEvents()
        'Buscar y listar los archivos de imagen en el control ListBox  

        If Directory.GetDirectories(folder_Browser.SelectedPath).Length = 0 Then
            listar_archivos(folder_Browser.SelectedPath, ListBox1)
        Else
            buscar(folder_Browser.SelectedPath)
        End If

        Me.Cursor = Cursors.Default
    End Sub

    ' función recursiva para los directorios  
    Private Sub buscar(ByVal sPath As String)

        ' obtener todos los subdirectorios en una matriz de string  
        Dim carpetas() As String = Directory.GetDirectories(sPath)

        ' recorrer el array  
        For Each dir As String In carpetas
            Try
                ' buscar de nuevo  
                buscar(dir)
                ' listar los archivos del directorio corriente  
                listar_archivos(dir, ListBox1)

                ' errores  
            Catch ex As UnauthorizedAccessException
                Debug.Print(ex.Message.ToString)
            Catch ex1 As Exception
                Debug.Print(ex1.Message.ToString)
            End Try
        Next
    End Sub

    Private Sub listar_archivos( _
        ByVal sPath As String, _
        ByVal lbox As ListBox)

        ' colección para GetFiles  
        Dim Collections_Files As ReadOnlyCollection(Of String)

        Try
            ' Obtener todos ficheros ( un solo nivel de dir.)   
            Collections_Files = My.Computer.FileSystem.GetFiles( _
                                        sPath, _
                                        FileIO.SearchOption.SearchTopLevelOnly, _
                                        petterns)

            ' agegar a la lista las rutas  
            For Each archivo As String In Collections_Files
                lbox.Items.Add(archivo)
            Next
            ' errores  
        Catch ex As Exception
            Debug.Print(ex.Message.ToString)
        End Try

    End Sub

    ' devuelve un objeto Drawing.Image con la imagen para el picturebox  
  
    

    Private Sub ListBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        Try
            ' Height y Width del control picture  
            Dim Ancho As Integer = PictureBox1.Width
            Dim Alto As Integer = PictureBox1.Height

            With PictureBox1
                ' recupera el Thumbnail y lo asigna   
                .Image = Thumbnail.MakeThumbnail_FixedSize(ListBox1.SelectedItem.ToString, Ancho, Alto, Color.White)


            End With
            ' errores  
        Catch ex As Exception
            Debug.Print(ex.Message)
        End Try
    End Sub
End Class
