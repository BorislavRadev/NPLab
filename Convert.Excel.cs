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
    int instCount = 0, currRow;
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
  		currRow = 4; // редът, на който се въвежда в момента
  		
  		//Записване на всеки сектор
  		foreach(Sectors sector in EL_2.sectors) 
  		{
  		  oSheet.Cells[currRow, 1] = sector.Name;
  		  оSheet.Range[оSheet.Cells[currRow, 1], оSheet.Cells[currRow, 7]].Merge();
  		  оSheet.Range[оSheet.Cells[currRow, 1], оSheet.Cells[currRow, 7]].Font.Bold = true;
  		  оSheet.Range[оSheet.Cells[currRow, 1], оSheet.Cells[currRow, 7]].Font.Italic = true;
  		  оSheet.Range[оSheet.Cells[currRow, 1], оSheet.Cells[currRow, 7]].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
  		  currRow++;
  		  
  		  //Записване на етажите
  		  foreach(Floors floor in sector.floors) 
  		  {
  		    oSheet.Cells[currRow, 2] = floor.Name;///шшоуу добави Name във Floors
    		  оSheet.Range[оSheet.Cells[currRow, 1], оSheet.Cells[currRow, 7]].Font.Bold = true;
    		  оSheet.Range[оSheet.Cells[currRow, 1], оSheet.Cells[currRow, 7]].Font.Underline = true;
    		  оSheet.Range[оSheet.Cells[currRow, 1], оSheet.Cells[currRow, 7]].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
    		  currRow++;
    		  
    		  //Записване на помещенията 
  		    foreach(Rooms room in floor.rooms) 
  		    {
  		      oSheet.Cells[currRow, 2] = floor.Name;///шшоуу добави Name във Floors
      		  оSheet.Range[оSheet.Cells[currRow, 1], оSheet.Cells[currRow, 7]].Font.Bold = true;
      		  оSheet.Range[оSheet.Cells[currRow, 1], оSheet.Cells[currRow, 7]].Font.Underline = true;
      		  оSheet.Range[оSheet.Cells[currRow, 1], оSheet.Cells[currRow, 7]].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
      		  currRow++;
      		  //Записване на съоръженията
      		  foreach(Installation inst in room.installations) 
  		      {
  		         instCount++;
  		         oSheet.Cells[currRow, 1] = instCount.ToString()+". ";
  		         oSheet.Cells[currRow, 2] = inst.InstallationName;
  		         if(!inst.isAutomaticProtector) oSheet.Cells[currRow, 3] = inst.Imperage;
  		         else oSheet.Cells[currRow, 4] = inst.Imperage;
  		         oSheet.Cells[currRow, 5] = inst.Coefficient;
  		         oSheet.Cells[currRow, 6] = inst.Impedance;
  		         if(!inst.isAutomaticProtector) оSheet.Range[оSheet.Cells[currRow, 7]].Formula = "= 230 / (D" + currRow.ToString()
  		                                  + " * E" + currRow.ToString();
  		         else оSheet.Range[оSheet.Cells[currRow, 7]].Formula = "= 230 / (C" + currRow.ToString()
  		                                  + " * E" + currRow.ToString();
  		         оSheet.Range[оSheet.Cells[currRow, 3], оSheet.Cells[currRow, 7]].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
  		         оSheet.Range[оSheet.Cells[currRow, 1]].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
  		         оSheet.Range[оSheet.Cells[currRow, 2]].HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
  		      }
  		    }
  		  }
  		}
  		
  		//Формат на таблицата
  		oSheet.get_Range("A1", "G" + currRow.ToString()).Font.Name = "Bookman Old Style";
  		oSheet.get_Range("A3", "G" + currRow.ToString()).Font.Size = 11;
  		oSheet.get_Range("A2", "G2").Font.Size = 10;
  		oSheet.get_Range("A1", "G1").Font.Size = 9;
  		oSheet.get_Range("A1", "G" + currRow.ToString()).VerticalAlignment = 
  			Excel.XlVAlign.xlVAlignCenter;
  		
    }
    catch
    {
      
    }
    }
  }  
}
