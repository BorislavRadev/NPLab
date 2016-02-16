using NPLab.Models;
using 
public partial class Convert:Object
{
  Excel.Application AppXL;
  Excel._Workbook ConvertXL;
  public ConvertImpExcel(FileStream fs)
  {
    
  	Excel._Worksheet ImpSheet;
  	Excel.Range Rng;
  
  	try
  	{
  		//Start Excel and get Application object.
  		AppXL = new Excel.Application();
  		AppXL.Visible = true;
  
  		//Get a new workbook.
  		ConvertXL = (Excel._Workbook)(oXL.Workbooks.Add( Missing.Value ));
  		ImpSheet = (Excel._Worksheet)ConvertXL.ActiveSheet;
  
  		//Заглавия на колоните
  		oSheet.Cells[1, 1] = "№ по ред";
  		oSheet.Cells[1, 2] = "НАИМЕНОВАНИЕ НА УРЕДБАТА (СЪОРЪЖЕНИЕТО)";
  		oSheet.get_Range("C1", "E1").Merge();
  		oSheet.Cells[1, 3] = "ВИД НА МАКСИМАЛНОТОКОВАТА ЗАЩИТА";
  		oSheet.Cells[1, 6] = "ИЗМЕРЕН ИМПЕДАНС [Ω}";
  		oSheet.Cells[1, 7] = "МАКСИМАЛНО ДОПУСТИМ ИМПЕДАНС [Ω}";
  		oSheet.get_Range("A1", "A2").Merge();
  		oSheet.get_Range("B1", "B2").Merge();
  		oSheet.Cells[2, 3] = "Стопяем предпазител Iн [A]";
  		oSheet.Cells[2, 4] = "Автоматичен прекъсвач Iн [A]";
  		oSheet.Cells[2, 5] = "Коефициент на задействане";
      oSheet.get_Range("F1", "F2").Merge();
  		oSheet.get_Range("G1", "G2").Merge();
  		
  		//Изграждане на 3-ти ред
  		for(int i = 1; i <= 7; i++) oSheet.Cells[3, i] = i;
  		int currRow = 4; // редът, на който се въвежда в момента
  		
  		//Записване на всеки сектор
  		foreach(Sectors sector in EL_2) 
  		{
  		  oSheet.Cells[currRow, 1] = sector.Name;
  		  оSheet.Range[оSheet.Cells[currRow, 1], оSheet.Cells[currRow, 7]].Merge();
  		  оSheet.Range[оSheet.Cells[currRow, 1], оSheet.Cells[currRow, 7]].Font.Bold = true;
  		  оSheet.Range[оSheet.Cells[currRow, 1], оSheet.Cells[currRow, 7]].Font.Italic = true;
  		  оSheet.Range[оSheet.Cells[currRow, 1], оSheet.Cells[currRow, 7]].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
  		  
  		  //Записване на етажите
  		}
  		
  		//Format A1:D1 as bold, vertical alignment = center.
  		oSheet.get_Range("A1", "D1").Font.Bold = true;
  		oSheet.get_Range("A1", "D1").VerticalAlignment = 
  			Excel.XlVAlign.xlVAlignCenter;
  		
    }

}
