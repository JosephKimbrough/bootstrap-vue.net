using System;
using System.Collections.Generic;
using static BootstrapVue.Net.Components.Nav.Constants.NavDropdownProperties;

namespace BootstrapVue.Net.Components.Nav
{
    public partial class VueNav
    {
        public class VueNavDropDown : VueTagBuilder
        {
            /// <summary>
            /// Constructor
            /// </summary>
            /// <param name="Text">The button text.</param>
            public VueNavDropDown(string id, string text) : base(TagLabel)
            {
                if (string.IsNullOrWhiteSpace(id))
                {
                    throw new ArgumentException("Dropdown must have valid id.", nameof(id));
                }

                if (string.IsNullOrWhiteSpace(text))
                {
                    throw new ArgumentException("Dropdown must have valid text.", nameof(text));
                }

                this.Attributes.Add(IdAttributeKey, id);
                this.Attributes.Add(TextAttributeKey, text);
            }

            public void AddDivider() => this.ChildItemCollection.Add(new DropdownDividerTag());

            public DropdownBoxAlignmentVariation DropdownBoxAlignment { get; set; } = DropdownBoxAlignmentVariation.right;
            public ICollection<DropdownBoxAlignmentVariation> DisplayableDropdownBoxVariations = new DropdownBoxAlignmentVariation[] { DropdownBoxAlignmentVariation.left, DropdownBoxAlignmentVariation.right };

            public bool LazyLoad { get; set; }

            public string ToggleClass { get; set; }

            public override string ToString()
            {
                if (LazyLoad) this.PropertyCollection.Add(LazyLoadPropertyText);
                if (!string.IsNullOrWhiteSpace(ToggleClass)) this.Attributes.Add(ToggleClassAttributeKey, ToggleClass);
                if (DisplayableDropdownBoxVariations.Contains(DropdownBoxAlignment)) this.PropertyCollection.Add(DropdownBoxAlignment.ToString());

                return base.ToString();
            }

            private class DropdownDividerTag : VueTagBuilder
            {
                public DropdownDividerTag() : base(DividerTagName) { }
            }
        }
    }
}
