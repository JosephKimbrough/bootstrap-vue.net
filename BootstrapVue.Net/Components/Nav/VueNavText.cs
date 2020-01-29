using static BootstrapVue.Net.Components.Nav.Constants.NavTextProperties;

namespace BootstrapVue.Net.Components.Nav
{
    public partial class VueNav
    {
        public class VueTextItem : VueTagBuilder
        {
            public VueTextItem(string text) : base(Constants.NavTextProperties.TagLabel)
            {
                if (string.IsNullOrWhiteSpace(text))
                {
                    throw new System.ArgumentException("Text item must have valid text.", nameof(text));
                }

                this.SetInnerText(text);
            }
        }
    }
}
