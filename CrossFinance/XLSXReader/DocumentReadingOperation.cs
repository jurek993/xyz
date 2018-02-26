using CrossFinance.Enums;
using CrossFinance.Extensions;
using CrossFinance.Models;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Web;

namespace CrossFinance.XLSXReader
{
    public class DocumentReadingOperation
    {
        private MainViewModel _model;
        public DocumentReadingOperation(MainViewModel model)
        {
            _model = model;
        }

        public void FindRowsNames() 
        {
            using (var package = new ExcelPackage(_model.File.InputStream))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[1];
                int row = 1;
                for (int col = 1; worksheet.Cells[row, col].Value != null; col++)
                {
                    var singleCell = worksheet.Cells[row, col].Value;
                    foreach (RowsName name in Enum.GetValues(typeof(RowsName)))
                    {
                        string rowEnumName = name.GetDisplayNameIfExist();
                        if (rowEnumName == singleCell.ToString())
                        {
                            _model.RowsNamesInImportedDocument.Add(name);
                        }
                    }                 
                }
            }
        }

        public List<RowsName> FindColumnForSingleEntity(object entity)
        {
            List<RowsName> columnList = new List<RowsName>(); 
            bool foundName = false;
            var fieldNames = entity.GetType().GetProperties();
            foreach (PropertyInfo field in fieldNames)
            {
                var displayAtribute = field.GetCustomAttribute(typeof(DisplayAttribute)) as DisplayAttribute;
                if (displayAtribute != null)
                {
                    var name = displayAtribute.Name;
                    foundName = false;
                    foreach (var rowEnum in _model.RowsNamesInImportedDocument)
                    {
                        string enumDisplayName = rowEnum.GetDisplayNameIfExist();
                        if(name == enumDisplayName)
                        {
                            foundName = true;
                            columnList.Add(rowEnum);
                        }
                    }
                    if (!foundName)
                    {
                        return null;
                    }
                }
            }
            return columnList;
        }
        public List<object> FindAllDataByColumnName(RowsName columnName)
        {
            List<object> columnValues = new List<object>();
            using (var package = new ExcelPackage(_model.File.InputStream))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[1];
                int row = 2;
                if (_model.DataSize != 0)
                {
                    for (int col = (int)columnName; row < _model.DataSize+2; row++)
                    {
                        columnValues.Add(worksheet.Cells[row, col].Value);
                    }
                    return columnValues;
                }
                for (int col = (int)columnName; worksheet.Cells[row, col].Value != null; row++)
                {
                    columnValues.Add(worksheet.Cells[row, col].Value);
                }
                return columnValues;
            }
        }
    }
}