using System.Collections.Generic;
using static Showout.BootstrapVue.Net.Components.Nav.Constants;
using static Showout.BootstrapVue.Net.Components.Nav.Constants.NavProperties;

namespace Showout.BootstrapVue.Net.Components.Nav
{
    public partial class VueNav : VueTagBuilder, IVueTag
    {
        public VueNav() : base(NavProperties.TagLabel) { }

        public ICollection<VueTemplate> Templates { get; set; } = new List<VueTemplate>();

        public bool MakeSmall { get; set; } = false;

        public AlignmentVariation Alignment { get; set; } = AlignmentVariation.left;
        private ICollection<AlignmentVariation> DisplayableAlignments
            = new AlignmentVariation[]
            {
                AlignmentVariation.left,
                AlignmentVariation.center,
                AlignmentVariation.right
            };

        public bool IsVertical { get; set; } = false;

        public SpacingVariation Spacing { get; set; } = SpacingVariation.none;
        private ICollection<SpacingVariation> DisplayableSpaceVariations
            = new SpacingVariation[]
            {
                SpacingVariation.fill,
                SpacingVariation.justified
            };

        public StyleVariation Style { get; set; } = StyleVariation.None;
        private ICollection<StyleVariation> DisplayableStyles = new StyleVariation[] { StyleVariation.Pills, StyleVariation.Tabs };

        public override string ToString()
        {

            if (DisplayableStyles.Contains(Style)) PropertyCollection.Add(Style.ToString());
            if (DisplayableSpaceVariations.Contains(Spacing)) PropertyCollection.Add(Spacing.ToString());
            if (DisplayableAlignments.Contains(Alignment)) Attributes.Add(AlignmentAttributeKey, Alignment.ToString());

            if (MakeSmall) PropertyCollection.Add(SmallPropertyText);
            if (IsVertical) PropertyCollection.Add(VerticalPropertyText);

            return base.ToString();
        }

        #region Classes


        public class VueNavForm : VueTagBuilder
        {
            public VueNavForm() : base(Constants.Tag)
            {
            }
        }
        #endregion Classes
    }
}
