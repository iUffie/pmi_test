using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nobilis.Creatio.TestExtensions.Abstractions;
using Terrasoft.Core.Entities;

namespace Terrasoft.Configuration.Rnb.Tests
{
    [TestClass]
    public class CommonTests : CreatioTestBase
    {
        [TestMethod]
        public void Get_UserConnection_ReturnNotNull()
        {
            Assert.IsNotNull(UserConnection);
        }

        [TestMethod]
        public void InsertAndGet_SimpleRecord()
        {
            var contact1 = new Contact(UserConnection);
            contact1.SetDefColumnValues();
            contact1.Name = "Test";
            contact1.Save();
            var esq = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "Contact");
            esq.AddAllSchemaColumns();
            var contact = esq.GetEntity(UserConnection, contact1.Id);
            Assert.IsNotNull(contact);
            Assert.AreEqual(contact1.Id, contact.PrimaryColumnValue);
        }

        // [TestMethod]
        // public void RecExistsTest()
        // {
        //     var contact1 = new Contact(UserConnection);
        //     contact1.SetDefColumnValues();
        //     contact1.Name = "Test";
        //     contact1.Save();
        //     var res = NsLinqRepositoryUtils.EntityByIdExists<Contact>(contact1.Id, UserConnection);
        //     Assert.IsTrue(res);
        // }

    }
}
