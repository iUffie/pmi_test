namespace Terrasoft.Configuration.Rnb.Tests.Integrations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.Serialization;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Serialization;
    using Nobilis.Creatio.TestExtensions.Abstractions;
    using PMI.BDDM.Common;
    using PMI.BDDM.Protocol;
    using Pmi.CoreCrm;
    

    [TestClass]
    public class PmContactServiceTests : CreatioTestBase
    {
        [TestMethod]
        public void FindByPhoneOrCaseNumber()
        {
            string consumerPhoneNumber = "79655865727";
            var serv = new PmContactService(UserConnection);
            serv.FindByPhoneOrCaseNumber(consumerPhoneNumber, string.Empty);
        }
    }
}
