using Showout.BootstrapVue.Net.Components;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Showout.BootstrapVue.Net
{
    public abstract class VueTagBuilder : TagBuilder, IVueTag
    {
        public VueTagBuilder(string tagName) : base(tagName) {
        }

        public ICollection<VueTagBuilder> ChildItemCollection { get; set; } = new List<VueTagBuilder>();
        public bool HasChildTags { get { return ChildItemCollection.Any(); } }

        public ICollection<string> PropertyCollection { get; set; } = new List<string>();
        public bool HasProperties { get { return PropertyCollection.Any(); } }

        public override string ToString()
        {
            AddChildItemCollectionToInnerHtml();

            var tagHtml = base.ToString();

            var result = GetHtmlWithPropertyCollection(tagHtml);

            return result;
        }

        private string GetHtmlWithPropertyCollection(string html)
        {
            if (string.IsNullOrWhiteSpace(html))
            {
                throw new System.ArgumentException("Must provide valid HTML", nameof(html));
            }

            if (HasProperties)
            {
                int startIndex = html.IndexOf('>');
                html = html.Insert(startIndex, " ").Insert(startIndex + 1, string.Join(" ", PropertyCollection.ToArray()));
            }
            return html;
        }

        private void AddChildItemCollectionToInnerHtml()
        {
            if (this.HasChildTags)
            {
                foreach (TagBuilder tag in ChildItemCollection)
                {
                    this.AppendHtml(tag.ToString());
                }
            }            
        }
    }
}
