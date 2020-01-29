using System;
using System.Collections.Generic;
using static BootstrapVue.Net.Components.Nav.Constants.NavItemProperties;

namespace BootstrapVue.Net.Components.Nav
{
    public partial class VueNav
    {
        public class VueNavItem : VueTagBuilder
        {
            public VueNavItem(string text, string url) : base(Constants.NavItemProperties.TagLabel)
            {
                if (string.IsNullOrWhiteSpace(text))
                {
                    throw new ArgumentException("Must supply valid text.", nameof(text));
                }

                if (string.IsNullOrWhiteSpace(url))
                {
                    throw new ArgumentException("Must supply valid url", nameof(url));
                }

                this.Attributes.Add("href", url);
                this.SetInnerText(text);
            }

            AlternateState AlternateState { get; set; } = AlternateState.none;

            ICollection<AlternateState> DisplayableAlternetStates = new AlternateState[] { AlternateState.active, AlternateState.disabled };

            public override string ToString()
            {
                if (DisplayableAlternetStates.Contains(this.AlternateState)) this.PropertyCollection.Add(this.AlternateState.ToString());

                return base.ToString();
            }
        }
    }
}
