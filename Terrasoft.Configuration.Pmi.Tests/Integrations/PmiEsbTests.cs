using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nobilis.Creatio.TestExtensions.Abstractions;
using Pmi.Integration.PmiEsb;
using Pmi.Integration.PmiEsbClient;

namespace Terrasoft.Configuration.Rnb.Tests.Integrations
{
    [TestClass]
    public class PmiEsbTests : CreatioTestBase
    {
        [TestMethod]
        public void ReceiveTest()
        {
            var conn = UserConnection;
            var cl = new PmiEsbClient(conn, false, "uat.ebx.brandvariant.feed.uat.rrpcrm", null, PmiEsbIntegrationConstants.NsIntegratingSystemCodifier.PmiEsb);
            //var procRes = new PmiEsbMessageProcessingTask(conn, false).Processing(cl);
        }

        [TestMethod]
        public void MapsInitializeTest()
        {
            ReceiveTest();
        }
    }
}
