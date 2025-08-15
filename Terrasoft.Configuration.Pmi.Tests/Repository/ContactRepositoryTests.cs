namespace Terrasoft.Configuration.Rnb.Tests.Repository
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Nobilis.Creatio.TestExtensions.Abstractions;
    using Pmi.CoreCrm;
    using Terrasoft.Configuration;
    using TimeZone = Terrasoft.Configuration.TimeZone;

    [TestClass]
    public class ContactRepositoryTests : CreatioTestBase
    {
        [TestMethod]
        public void GetContactByPhone()
        {
            var phoneNum = "79655865727";
            var caseNum = "SR00000086";
            var conn = UserConnection;
            var rep = new PmContactRepository(conn);
            var res = rep.GetContactWithCasesByPhoneNumber(phoneNum);

            //var res = rep.GetContactWithCasesByCaseNumber(caseNum);
            Assert.IsNotNull(res);

            //Contact
            Console.WriteLine($"Contact.{nameof(Contact.Id)} : {res.Contact.Id}");
            Console.WriteLine($"Contact.{nameof(Contact.ModifiedOn)} : {res.Contact.ModifiedOn}");
            Console.WriteLine($"Contact.{nameof(Contact.PmExternalCode)} : {res.Contact.PmExternalCode}");
            Console.WriteLine($"Contact.{nameof(Contact.PmExternalCodeSpace)} : {res.Contact.PmExternalCodeSpace}");
            Console.WriteLine($"Contact.{nameof(Contact.Name)} : {res.Contact.Name}");
            Console.WriteLine($"Contact.{nameof(Contact.PmRegistrationDate)} : {res.Contact.PmRegistrationDate}");
            Console.WriteLine(
                $"Contact.{nameof(Contact.PmRegistrationApplication)} : {res.Contact.PmRegistrationApplication}");

            //SalePoint
            Console.WriteLine($"SalePoint.{nameof(PmSalePoint.Id)} : {res.SalePoint.Id}");
            Console.WriteLine($"SalePoint.{nameof(PmSalePoint.PmName)} : {res.SalePoint.PmName}");
            Console.WriteLine($"SalePoint.{nameof(PmSalePoint.PmExternalCode)} : {res.SalePoint.PmExternalCode}");
            Console.WriteLine(
                $"SalePoint.{nameof(PmSalePoint.PmExternalCodeSpace)} : {res.SalePoint.PmExternalCodeSpace}");

            //Country
            Console.WriteLine($"Country.{nameof(Country.Id)} : {res.Country.Id}");
            Console.WriteLine($"Country.{nameof(Country.Name)} : {res.Country.Name}");
            Console.WriteLine($"Country.{nameof(Country.PmExternalCode)} : {res.Country.PmExternalCode}");
            Console.WriteLine($"Country.{nameof(Country.PmExternalCodeSpace)} : {res.Country.PmExternalCodeSpace}");

            //CreatedBy
            Console.WriteLine($"CreatedBy.{nameof(SysAdminUnit.Id)} : {res.CreatedBy.Id}");
            Console.WriteLine($"CreatedBy.{nameof(SysAdminUnit.Name)} : {res.CreatedBy.Name}");
            Console.WriteLine($"CreatedBy.{nameof(SysAdminUnit.PmExternalCode)} : {res.CreatedBy.PmExternalCode}");
            Console.WriteLine(
                $"CreatedBy.{nameof(SysAdminUnit.PmExternalCodeSpace)} : {res.CreatedBy.PmExternalCodeSpace}");

            //ModifiedBy
            Console.WriteLine($"ModifiedBy.{nameof(SysAdminUnit.Id)} : {res.ModifiedBy.Id}");
            Console.WriteLine($"ModifiedBy.{nameof(SysAdminUnit.Name)} : {res.ModifiedBy.Name}");
            Console.WriteLine($"ModifiedBy.{nameof(SysAdminUnit.PmExternalCode)} : {res.ModifiedBy.PmExternalCode}");
            Console.WriteLine(
                $"ModifiedBy.{nameof(SysAdminUnit.PmExternalCodeSpace)} : {res.ModifiedBy.PmExternalCodeSpace}");

            //TimeZone
            Console.WriteLine($"TimeZone.{nameof(TimeZone.Id)} : {res.TimeZone.Id}");
            Console.WriteLine($"TimeZone.{nameof(TimeZone.Offset)} : {res.TimeZone.Offset}");

            // Console.WriteLine($"TimeZone.{nameof(TimeZone.PmExternalCode)} : {res.ModifiedBy.PmExternalCode}");
            // Console.WriteLine($"TimeZone.{nameof(TimeZone.PmExternalCodeSpace)} : {res.ModifiedBy.PmExternalCodeSpace}");
            Console.WriteLine("Cases:");
            foreach (var cas in res.Cases)
            {
                Console.WriteLine($"Case.{nameof(Case.Id)} : {cas.Case.Id}");
                Console.WriteLine($"Case.{nameof(Case.Number)} : {cas.Case.Number}");
                Console.WriteLine($"Case.{nameof(Case.ModifiedOn)} : {cas.Case.ModifiedOn}");
                Console.WriteLine($"Case.{nameof(Case.PmExternalCode)} : {cas.Case.PmExternalCode}");
                Console.WriteLine($"Case.{nameof(Case.PmExternalCodeSpace)} : {cas.Case.PmExternalCodeSpace}");
            }
        }
    }
}
