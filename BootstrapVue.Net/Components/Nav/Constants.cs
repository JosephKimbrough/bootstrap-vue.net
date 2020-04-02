namespace Showout.BootstrapVue.Net.Components.Nav
{
    public static class Constants
    {
        public const string Tag = "b-nav-form";

        public static class NavProperties
        {
            public const string TagLabel = "b-nav";
            public const string AlignmentAttributeKey = "align";
            public const string SmallPropertyText = "small";
            public const string VerticalPropertyText = "vertical";
            public enum StyleVariation { None, Pills, Tabs }
            public enum SpacingVariation { none, fill, justified }
            public enum AlignmentVariation { left, center, right }
        }

        public static class NavDropdownProperties
        {
            public const string TagLabel = "b-nav-item-dropdown";
            public const string DividerTagName = "b-dropdown-divider";
            public const string IdAttributeKey = "id";
            public const string TextAttributeKey = "text";
            public const string ToggleClassAttributeKey = "toggle-class";
            public const string LazyLoadPropertyText = "lazy";
            public enum DropdownBoxAlignmentVariation { left, right }
        }

        public static class NavTextProperties
        {
            public const string TagLabel = "b-nav-text";
        }

        public class NavItemProperties
        {
            public const string TagLabel = "b-nav-item";
            public enum AlternateState { none, active, disabled }
        }
    }
}
