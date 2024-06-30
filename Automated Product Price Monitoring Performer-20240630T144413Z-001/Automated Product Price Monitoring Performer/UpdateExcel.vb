Public Function UpdateExcel(imagePath As String, TableRange As String)
	If imagePath <> "No File" Then	
	  Range("A1").Select
		ActiveSheet.Pictures.Insert( _
			imagePath _
			).Select
		Selection.ShapeRange.LockAspectRatio = msoFalse
		Selection.ShapeRange.Height = 250
		Selection.ShapeRange.Width = 185
		Selection.ShapeRange.IncrementLeft 95
		Selection.ShapeRange.IncrementTop 15
	End If
	
  ActiveSheet.Range("B:B").WrapText = True
  ActiveSheet.Columns("B").ColumnWidth = 80
  ActiveSheet.Columns("A").ColumnWidth = 20
  ActiveSheet.Range("A:A").Font.Bold = True
  ActiveSheet.Range("A:B").HorizontalAlignment = xlLeft
  ActiveSheet.Range("A:B").VerticalAlignment = xlTop
  ActiveSheet.PageSetup.Zoom = False 
  ActiveSheet.PageSetup.FitToPagesTall = 3
  ActiveSheet.PageSetup.FitToPagesWide = 1 
  
  Range(TableRange).Rows.AutoFit
  
  Range(TableRange).Select
    ActiveSheet.ListObjects.Add(xlSrcRange, Range(TableRange), , xlNo).Name = _
        "Table3"
    ActiveSheet.ListObjects("Table3").ShowHeaders = False
	ActiveSheet.ListObjects("Table3").TableStyle = "TableStyleLight16"
End Function