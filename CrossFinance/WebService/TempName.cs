using CrossFinance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrossFinance.WebService
{
    public class WebServiceExporter
    {
        public void Export(Person person, Address address, FinancialState financial, Agreement agreement)
        {
            CFServiceReference.ImportServiceClient importService = new CFServiceReference.ImportServiceClient();
            CFServiceReference.Address webServiceAdress = new CFServiceReference.Address
            {
                City = address.PostOfficeCity,
                PostalCode = address.PostCode,
                HouseNo = address.StreetNumber,
                LocaleNo = address.FlatNumber,
                Street = address.StreetName
            };


            CFServiceReference.Address[] tabAddress = { webServiceAdress };
            CFServiceReference.IdentityDocument document = new CFServiceReference.IdentityDocument
            {
                Number = agreement.Number
            };
            CFServiceReference.IdentityDocument[] tabDocuments = { document };

            CFServiceReference.FinancialState webServiceFinancialState = new CFServiceReference.FinancialState
            {
                CourtFees = financial.CourtFees,
                CourtRepresentationFees = financial.RepresentationCourtFees,
                Fees = financial.Fees,
                Interest = financial.Interests,
                EnforcementFees = financial.RepresentationVindicationCosts,
                EnforcementRepresentationFees = financial.RepresentationCourtFees,
                Capital = financial.OutstandingLiabilites,
                PenaltyInterest = financial.PenaltyInterests,
            };

            CFServiceReference.Person webServicePerson = new CFServiceReference.Person
            {
                Name = person.FirstName,
                Surname = person.Surname,
                NationalIdentificationNumber = person.NationalIdentificationNumber,
                Addresses = tabAddress,
                ExtensionData = person.ExtensionData,
                IdentityDocuments = tabDocuments,
                FinancialState = webServiceFinancialState
            };

            //TODO: połączyć się 
            //importService.DoImport(webServicePerson);
        }
    }
}