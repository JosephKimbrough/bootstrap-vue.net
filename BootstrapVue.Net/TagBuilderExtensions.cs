using System.Web.Mvc;

namespace Showout.BootstrapVue.Net
{
    public static class TagBuilderExtensions
    {
        public static void AppendHtml(this TagBuilder tagBuilder, string html) => tagBuilder.InnerHtml += html;


    }
}
