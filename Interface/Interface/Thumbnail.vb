Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Drawing.Drawing2D

Public NotInheritable Class Thumbnail

    Public Sub New()
    End Sub

#Region "Thumbnails usando la matriz de transformacion"
#Region "       Por escala"
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="Filename">Nombre del fichero gráfico que se va a redimensionar</param>
    ''' <param name="Scale">Factor de escala. Valores menores de 1 reducen la imagen. Valores mayores de 1 la agrandan</param>
    ''' <returns>un objeto bitmap</returns>
    ''' <remarks></remarks>
    Public Shared Function ResizePicture_MatrixByScale(ByVal Filename As String, ByVal Scale As Single) As Bitmap
        Try
            Dim original As Image = Image.FromFile(Filename)
            Dim finalW As Integer = CType(original.Width * Scale, Integer)
            Dim finalH As Integer = CType(original.Height * Scale, Integer)
            Dim bm As New Bitmap(original.Width, original.Height)
            Dim gr As Graphics = Graphics.FromImage(bm)
            gr.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
            gr.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
            gr.PixelOffsetMode = Drawing2D.PixelOffsetMode.HighSpeed

            Dim myMatrix As Matrix = New Matrix()

            myMatrix.Scale(Scale, Scale, MatrixOrder.Append)
            gr.Transform = myMatrix
            gr.DrawImage(original, New Rectangle(0, 0, original.Width, original.Height), 0, 0, original.Width, original.Height, GraphicsUnit.Pixel)

            Dim retBitmap As New Bitmap(finalW, finalH)
            Dim retgr As Graphics = Graphics.FromImage(retBitmap)
            retgr.DrawImage(bm, New Point(0, 0))
            Return retBitmap
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
#End Region
#Region "       Ancho Fijo del thumbnail"
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="Filename">Nombre del fichero gráfico que se va a redimensionar</param>
    ''' <param name="FinalWidth">Ancho del Thumbnail. La altura se reajusta automáticamente</param>
    ''' <returns>objeto bitmap</returns>
    ''' <remarks></remarks>
    Public Shared Function ResizePicture_MatrixByWidth(ByVal Filename As String, ByVal FinalWidth As Integer) As Bitmap
        Try
            Dim original As Image = Image.FromFile(Filename)
            Dim Scale As Single = FinalWidth / original.Width

            Dim finalH As Integer = CType(original.Height * Scale, Integer)
            Dim sOffSet As Integer = 1
            Dim bm As Bitmap
            If Scale < 1 Then
                bm = New Bitmap(original.Width, original.Height)
            Else
                bm = New Bitmap(FinalWidth, finalH)
                sOffSet = -1
            End If

            Dim gr As Graphics = Graphics.FromImage(bm)
            gr.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
            gr.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
            gr.PixelOffsetMode = Drawing2D.PixelOffsetMode.HighSpeed

            Dim myMatrix As Matrix = New Matrix()

            myMatrix.Scale(Scale, Scale, MatrixOrder.Append)
            gr.Transform = myMatrix
            gr.DrawImage(original, New Rectangle(0, 0, original.Width, original.Height), 0, 0, original.Width, original.Height, GraphicsUnit.Pixel)

            sOffSet = 0
            Dim retBitmap As New Bitmap(FinalWidth + sOffSet, finalH + sOffSet)
            Dim retgr As Graphics = Graphics.FromImage(retBitmap)
            retgr.DrawImage(bm, New Point(0, 0))
            Return retBitmap
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
#End Region
#Region "       Altura Fija del thumbnail"
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="Filename">Nombre del fichero gráfico que se va a redimensionar</param>
    ''' <param name="FinalHeight">Altura del Thumbnail. El ancho se reajusta automáticamente</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function ResizePicture_MatrixByHeight(ByVal Filename As String, ByVal FinalHeight As Integer) As Bitmap
        Try
            Dim original As Image = Image.FromFile(Filename)
            Dim Scale As Single = FinalHeight / original.Height

            Dim finalW As Integer = CType(original.Width * Scale, Integer)
            Dim sOffSet As Integer = 1
            Dim bm As Bitmap
            If Scale < 1 Then
                bm = New Bitmap(original.Width, original.Height)
            Else
                bm = New Bitmap(finalW, FinalHeight)
                sOffSet = -1
            End If

            Dim gr As Graphics = Graphics.FromImage(bm)
            gr.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
            gr.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
            gr.PixelOffsetMode = Drawing2D.PixelOffsetMode.HighSpeed

            Dim myMatrix As Matrix = New Matrix()

            myMatrix.Scale(Scale, Scale, MatrixOrder.Append)
            gr.Transform = myMatrix
            gr.DrawImage(original, New Rectangle(0, 0, original.Width, original.Height), 0, 0, original.Width, original.Height, GraphicsUnit.Pixel)

            sOffSet = 0
            Dim retBitmap As New Bitmap(finalW + sOffSet, FinalHeight + sOffSet)
            Dim retgr As Graphics = Graphics.FromImage(retBitmap)
            retgr.DrawImage(bm, New Point(0, 0))
            Return retBitmap
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
#End Region
#End Region

#Region "Thumbnails de tamaño fijo y centrados"
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="Filename">Nombre del fichero gráfico que se va a redimensionar</param>
    ''' <param name="FinalWidth">Ancho del Thumbnail</param>
    ''' <param name="FinalHeight">Alto del Thumbnail</param>
    ''' <param name="ColorFill">Color con el que se rellena el fondo del thumbnail en caso de tener que centrar el thumbnail</param>
    ''' <returns></returns>
    ''' <remarks></remarks>    
    Public Shared Function MakeThumbnail_FixedSize(ByVal Filename As String, ByVal FinalWidth As Integer, ByVal FinalHeight As Integer, ByVal ColorFill As Color)
        Try
            Dim original As Image = Image.FromFile(Filename)
            Dim tW As Integer
            Dim tH As Integer

            Dim aspectRatio As Single = original.Width / original.Height

            If aspectRatio < 1 Then
                tH = FinalHeight
                tW = Convert.ToInt16(tH * aspectRatio)
                If tW > FinalWidth Then
                    tW = FinalWidth
                    tH = Convert.ToInt16(tW * aspectRatio)
                End If
            Else
                aspectRatio = original.Height / original.Width
                tW = FinalWidth
                tH = Convert.ToInt16(tW * aspectRatio)
                If tH > FinalHeight Then
                    tH = FinalHeight
                    aspectRatio = original.Width / original.Height
                    tW = Convert.ToInt16(tH * aspectRatio)
                End If
            End If

            Dim bm As New Bitmap(FinalWidth, FinalHeight)
            Dim gr As Graphics = Graphics.FromImage(bm)
            gr.Clear(ColorFill)
            gr.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
            gr.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
            gr.PixelOffsetMode = Drawing2D.PixelOffsetMode.HighSpeed

            Dim xI As Integer = 0
            Dim yI As Integer = 0
            If tW < FinalWidth Then
                xI = (FinalWidth - tW) / 2
            End If
            If tH < FinalHeight Then
                yI = (FinalHeight - tH) / 2
            End If

            gr.DrawImage(original, New Rectangle(xI, yI, tW, tH), 0, 0, original.Width, original.Height, GraphicsUnit.Pixel)
            Return bm
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
#End Region

End Class
