using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CrossFinance.Models;

namespace CrossFinance.XLSXReader
{
    public class ObjectMapper
    {
        private List<List<object>> _allDataForObject = new List<List<object>>();
        public List<object> GetDataForObject(object obj, MainViewModel model)
        {
            model.RowsNamesInImportedDocument.Clear();
            _allDataForObject.Clear();
            DocumentReadingOperation documentReadingOperation = new DocumentReadingOperation(model);
            documentReadingOperation.FindRowsNames();
            var columnList = documentReadingOperation.FindColumnForSingleEntity(obj);
            if (columnList != null)
            {
                foreach (var singleEnumValue in columnList)
                {
                    _allDataForObject.Add(documentReadingOperation.FindAllDataByColumnName(singleEnumValue));
                }
                IMapper mapper = FindMappedObject(obj, model);
                return mapper.MapObject(_allDataForObject);
            }
            else
            {
                model.ErrorList.Add("could not be mapped: " + obj.GetType().ToString());
                return null;
            }
        }

        public IMapper FindMappedObject(object obj, MainViewModel model)
        {
            IMapper mapper = null;
            switch (obj.ToString())
            {
                case "CrossFinance.Models.Person":
                    model.DataSize = _allDataForObject.FirstOrDefault().Count();
                    mapper = new MapToPerson();
                    break;
                case "CrossFinance.Models.Address":
                    mapper = new MapToAddress();
                    break;
                case "CrossFinance.Models.FinancialState":
                    mapper = new MapToFinancialState();
                    break;
                case "CrossFinance.Models.Agreement":
                    mapper = new MapToAgreement();
                    break;
                default:
                    model.ErrorList.Add("Can't find mapper class ");
                    break;
            }
            return mapper;
        }
    }
}