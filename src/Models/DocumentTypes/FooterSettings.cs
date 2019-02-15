namespace Graph.Components.Footer
{
    using NicBell.UCreate.Attributes;
    using NicBell.UCreate.Constants;

	[DocType(Name = "Footer Settings", Icon = "icon-settings", AllowedAsRoot = true)]
	public class FooterSettings
	{
		[Property(TypeName = PropertyTypes.Textarea, Name = "Address", TabName = "Contacts", Alias = FooterConfig.AddressFieldAlias)]
		public string Address { get; set; }

		[Property(TypeName = PropertyTypes.Textstring, Name = "Phone", TabName = "Contacts", Alias = FooterConfig.PhoneFieldAlias)]
		public string Phone { get; set; }

		[Property(TypeName = PropertyTypes.Textstring, Name = "Email", TabName = "Contacts", Alias = FooterConfig.EmailFieldAlias)]
		public string Email { get; set; }

		[Property(TypeName = PropertyTypes.Textstring, Name = "Fax", TabName = "Contacts", Alias = FooterConfig.FaxFieldAlias)]
		public string Fax { get; set; }

		[Property(TypeName = PropertyTypes.Textstring, Name = "Facebook", TabName = "Social networks", Alias = FooterConfig.FacebookFieldAlias)]
		public string Facebook { get; set; }

		[Property(TypeName = PropertyTypes.Textstring, Name = "Twitter", TabName = "Social networks", Alias = FooterConfig.TwitterFieldAlias)]
		public string Twitter { get; set; }

		[Property(TypeName = PropertyTypes.Textstring, Name = "Instagram", TabName = "Social networks", Alias = FooterConfig.InstagramFieldAlias)]
		public string Instagram { get; set; }

		[Property(TypeName = PropertyTypes.Textstring, Name = "LinkedIn", TabName = "Social networks", Alias = FooterConfig.LinkedInFieldAlias)]
		public string LinkedIn { get; set; }

		[Property(TypeName = PropertyTypes.Textstring, Name = "YouTube", TabName = "Social networks", Alias = FooterConfig.YouTubeFieldAlias)]
		public string YouTube { get; set; }

		[Property(TypeName = PropertyTypes.Textarea, Name = "Copyright text", TabName = "Content", Alias = FooterConfig.CopyrightTextFieldAlias)]
		public string CopyrightText { get; set; }

		[Property(TypeName = PropertyTypes.RelatedLinks, Name = "Pages", TabName = "Content", Alias = FooterConfig.PagesFieldAlias)]
		public string Pages { get; set; }
	}
}