Sub mergeCells(sheetName AS string, cellRange AS string)
  Set sh = Sheets(sheetName)
  sh.Range(cellRange).Merge
End Sub
