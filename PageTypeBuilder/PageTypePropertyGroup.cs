namespace PageTypeBuilder
{
    public abstract class PageTypePropertyGroup
    {
        protected internal TypedPageData TypedPageData { get; set; }
        internal PageTypePropertyGroupHierarchy Hierarchy { get; set; }

        public virtual void PopuplateInstance(TypedPageData destination, string hierarchy)
        {
            Hierarchy = new PageTypePropertyGroupHierarchy { Value = hierarchy };
            TypedPageData = destination;
        }
    }
}
