using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NPLab.Data;
using NPLab.Models;
using System.Data.Entity;
using NPLab.Data.Migrations;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;
using FileStream  = System.IO.FileStream;
namespace NPLab.ConvertFile
{
    public partial class ConvertFile
    {
      Excel.Application AppXL;
      Excel._Workbook ConvertXL;
      public void ConvertImpExcel(string URL)
      {
    
  	    Excel._Worksheet ImpSheet;
        ImpSheet.Name = "Импеданс";
  	    Excel.Range Rng;
        int instCount = 0, currRow;
        ICollection<Sectors> Sects;
        object misValue = System.Reflection.Missing.Value;
  	    try
  	    {
  		    //Start Excel and get Application object.
  		    AppXL = new Excel.Application();
  		    AppXL.Visible = true;
  
  		    //Get a new workbook.
  		    ConvertXL = (Excel._Workbook)(AppXL.Workbooks.Add( Missing.Value ));
  		    ImpSheet = (Excel._Worksheet)ConvertXL.ActiveSheet;
  
  		    //Заглавия на колоните
  		    ImpSheet.Cells[1, 1] = "№ по ред";
  		    ImpSheet.Cells[1, 2] = "НАИМЕНОВАНИЕ НА УРЕДБАТА (СЪОРЪЖЕНИЕТО)";
  		    ImpSheet.get_Range("C1", "E1").Merge();
  		    ImpSheet.Cells[1, 3] = "ВИД НА МАКСИМАЛНОТОКОВАТА ЗАЩИТА";
  		    ImpSheet.Cells[1, 6] = "ИЗМЕРЕН ИМПЕДАНС [Ω}";
  		    ImpSheet.Cells[1, 7] = "МАКСИМАЛНО ДОПУСТИМ ИМПЕДАНС [Ω}";
  		    ImpSheet.get_Range("A1", "A2").Merge();
  		    ImpSheet.get_Range("B1", "B2").Merge();
  		    ImpSheet.Cells[2, 3] = "Стопяем предпазител Iн [A]";
  		    ImpSheet.Cells[2, 4] = "Автоматичен прекъсвач Iн [A]";
  		    ImpSheet.Cells[2, 5] = "Коефициент на задействане";
            ImpSheet.get_Range("F1", "F2").Merge();
  		    ImpSheet.get_Range("G1", "G2").Merge();
  		
  		    //Изграждане на 3-ти ред
  		    for(int i = 1; i <= 7; i++) ImpSheet.Cells[3, i] = i;
  		    currRow = 4; // редът, на който се въвежда в момента
  		
  		    //Записване на всеки сектор
  		    foreach(Sectors sector in Sects) 
  		    {
  		      ImpSheet.Cells[currRow, 1] = sector.SectorName;
              ImpSheet.Range[ImpSheet.Cells[currRow, 1], ImpSheet.Cells[currRow, 7]].Merge();
              ImpSheet.Range[ImpSheet.Cells[currRow, 1], ImpSheet.Cells[currRow, 7]].Font.Bold = true;
              ImpSheet.Range[ImpSheet.Cells[currRow, 1], ImpSheet.Cells[currRow, 7]].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
  		      currRow++;
  		  
  		      //Записване на етажите
  		      foreach(Floors floor in sector.ListOfFloors) 
  		      {
  		        ImpSheet.Cells[currRow, 2] = floor.Name;///шшоуу добави Name във Floors
    		      ImpSheet.Range[ImpSheet.Cells[currRow, 1], ImpSheet.Cells[currRow, 7]].Font.Bold = true;
    		      ImpSheet.Range[ImpSheet.Cells[currRow, 1], ImpSheet.Cells[currRow, 7]].Font.Underline = true;
    		      ImpSheet.Range[ImpSheet.Cells[currRow, 1], ImpSheet.Cells[currRow, 7]].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
    		      currRow++;
    		  
    		      //Записване на помещенията 
  		        foreach(Rooms room in floor.ListOfRooms) 
  		        {
  		          ImpSheet.Cells[currRow, 2] = floor.Name;///шшоуу добави Name във Floors
      		      ImpSheet.Range[ImpSheet.Cells[currRow, 1], ImpSheet.Cells[currRow, 7]].Font.Bold = true;
      		      ImpSheet.Range[ImpSheet.Cells[currRow, 1], ImpSheet.Cells[currRow, 7]].Font.Underline = true;
      		      ImpSheet.Range[ImpSheet.Cells[currRow, 1], ImpSheet.Cells[currRow, 7]].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
      		      currRow++;
      		      //Записване на съоръженията
      		      foreach(Installations inst in room.ListOfInstallations) 
  		          {
  		             instCount++;
  		             ImpSheet.Cells[currRow, 1] = instCount.ToString()+". ";
  		             ImpSheet.Cells[currRow, 2] = inst.InstallationName;
  		             if(!inst.isAutomaticProtector) ImpSheet.Cells[currRow, 3] = inst.Amperage;
  		             else ImpSheet.Cells[currRow, 4] = inst.Amperage;
  		             ImpSheet.Cells[currRow, 5] = inst.Coefficient;
  		             ImpSheet.Cells[currRow, 6] = inst.Impedance;
  		             if(!inst.isAutomaticProtector) ImpSheet.Range[ImpSheet.Cells[currRow, 7]].Formula = "= 230 / (D" + currRow.ToString()
  		                                      + " * E" + currRow.ToString();
  		             else ImpSheet.Range[ImpSheet.Cells[currRow, 7]].Formula = "= 230 / (C" + currRow.ToString()
  		                                      + " * E" + currRow.ToString();
  		             ImpSheet.Range[ImpSheet.Cells[currRow, 3], ImpSheet.Cells[currRow, 7]].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
  		             ImpSheet.Range[ImpSheet.Cells[currRow, 1]].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
  		             ImpSheet.Range[ImpSheet.Cells[currRow, 2]].HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
  		          }
  		        }
  		      }
  		    }
  		
  		    //Формат на таблицата
  		    ImpSheet.get_Range("A1", "G" + currRow.ToString()).Font.Name = "Bookman Old Style";
  		    ImpSheet.get_Range("A3", "G" + currRow.ToString()).Font.Size = 11;
  		    ImpSheet.get_Range("A2", "G2").Font.Size = 10;
  		    ImpSheet.get_Range("A1", "G1").Font.Size = 9;
  		    ImpSheet.get_Range("A1", "G" + currRow.ToString()).VerticalAlignment = 
  			    Excel.XlVAlign.xlVAlignCenter;
  		
        }
        catch
        {
            if (AppXL == null)
            {
                MessageBox.Show("Excel не е инсталиран на компютъра!!");
                return;
            }
            MessageBox.Show("Грешка при конвертирането на файла");
        }
        ConvertXL.SaveAs(URL);
      }
    }  
}
