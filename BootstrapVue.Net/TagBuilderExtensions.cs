using System.Web.Mvc;

namespace BootstrapVue.Net
{
    public static class TagBuilderExtensions
    {
        public static void AppendHtml(this TagBuilder tagBuilder, string html) => tagBuilder.InnerHtml += html;


    }
}
