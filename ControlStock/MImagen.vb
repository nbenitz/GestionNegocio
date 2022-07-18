Imports System.Drawing.Imaging
''Imports System.Drawing.Drawing2D
Imports System.IO

Module MImagen


    Public Function ByteArrayToImage(ByVal byteArrayIn As Byte()) As Image
        Dim ms As New MemoryStream(byteArrayIn)
        Return Image.FromStream(ms)
    End Function

    Public Function ImageToByteArray(ByVal imageIn As Image) As Byte()
        Dim ms As New MemoryStream()
        imageIn.Save(ms, ImageFormat.Jpeg)
        Return ms.ToArray()
    End Function

    Public Function CorrectExifOrientation(ByVal Img As Image) As Image
        If Img Is Nothing Then
            Exit Function
        End If

        Dim orientationId As Integer = 274
        If Img.PropertyIdList.Contains(orientationId) Then
            Dim Orientation As Byte = Img.GetPropertyItem(orientationId).Value(0)
            Dim RotateFlip As Integer = RotateFlipType.RotateNoneFlipNone
            Select Case Orientation
                Case 1
                    RotateFlip = RotateFlipType.RotateNoneFlipNone
                Case 2
                    RotateFlip = RotateFlipType.RotateNoneFlipX
                Case 3
                    RotateFlip = RotateFlipType.Rotate180FlipNone
                Case 4
                    RotateFlip = RotateFlipType.Rotate180FlipX
                Case 5
                    RotateFlip = RotateFlipType.Rotate90FlipX
                Case 6
                    RotateFlip = RotateFlipType.Rotate90FlipNone
                Case 7
                    RotateFlip = RotateFlipType.Rotate270FlipX
                Case 8
                    RotateFlip = RotateFlipType.Rotate270FlipNone
                Case Else
                    RotateFlip = RotateFlipType.RotateNoneFlipNone
            End Select

            If RotateFlip <> RotateFlipType.RotateNoneFlipNone Then
                Img.RotateFlip(RotateFlip)
                Img.RemovePropertyItem(orientationId)
            End If
        End If
        Return Img
    End Function

End Module
