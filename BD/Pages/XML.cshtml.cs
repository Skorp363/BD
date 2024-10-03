using System.Xml.Xsl;
using System.Xml;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SpaceObjectBD.Pages
{
    public class XMLModel : PageModel
    {
        public string TransformedXml { get; private set; }

        public void OnGet()
        {
            var xslt = new XslCompiledTransform();
            xslt.Load("wwwroot/xsl/transform.xsl");

            using (var writer = new StringWriter())
            using (var xmlReader = XmlReader.Create("wwwroot/xml/KitchenAppliances.xml"))
            using (var xmlWriter = XmlWriter.Create(writer, xslt.OutputSettings))
            {
                xslt.Transform(xmlReader, xmlWriter);
                TransformedXml = writer.ToString();
            }
        }
    }
}
