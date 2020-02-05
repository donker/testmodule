using DotNetNuke.ComponentModel.DataAnnotations;

namespace Dnn.Test.ModulesTestModule.Components
{
    [TableName("Tabs")]
    public class TestComponent
    {
        public int TabID { get; set; }
        public string TabName { get; set; }
        public string TabPath { get; set; }
        [IgnoreColumn]
        public string TestLocale
        {
            get
            {
                return System.Threading.Thread.CurrentThread.CurrentCulture.Name;
            }
        }
    }
}