using BusinessLogicLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System.Web.UI.WebControls;

namespace MusicSiteTests
{
    [TestClass]
    public class Index
    {
        [TestMethod]
        public void bindTopDownloads()
        {
            clsCommonHelper objcommon;                    
            objcommon = new clsCommonHelper();
            Assert.IsNotNull(objcommon);
        }

        [TestMethod]
        public void bindLatestHits()
        {
            clsCommonHelper objcommon;     
            objcommon = new clsCommonHelper();
            Assert.IsNotNull(objcommon);
        }
    }
}
