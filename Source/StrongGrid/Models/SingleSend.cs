using System;
using System.Text.Json.Serialization;

namespace StrongGrid.Models
{
	/// <summary>
	/// Single send (AKA campaign).
	/// </summary>
	public class SingleSend
	{
		/// <summary>
		/// Gets or sets the identifier.
		/// </summary>
		/// <value>
		/// The identifier.
		/// </value>
		[JsonPropertyName("id")]
		public string Id { get; set; }

		/// <summary>
		/// Gets or sets the name.
		/// </summary>
		/// <value>
		/// The name.
		/// </value>
		[JsonPropertyName("name")]
		public string Name { get; set; }

		/// <summary>
		/// Gets or sets the categories.
		/// </summary>
		/// <value>
		/// The categories.
		/// </value>
		[JsonPropertyName("categories")]
		public string[] Categories { get; set; }

		/// <summary>
		/// Gets or sets the status.
		/// </summary>
		/// <value>
		/// The status.
		/// </value>
		[JsonPropertyName("status")]
		public SingleSendStatus Status { get; set; }

		/// <summary>
		/// Gets or sets the date and time when the single send will be sent.
		/// </summary>
		/// <value>
		/// The date and time when the single send will be sent.
		/// </value>
		[JsonPropertyName("send_at")]
		public DateTime? SendOn { get; set; }

		/// <summary>
		/// Gets or sets the date and time when the single send was modified.
		/// </summary>
		/// <value>
		/// The date and time when the single send was modified.
		/// </value>
		[JsonPropertyName("updated_at")]
		public DateTime? UpdatedOn { get; set; }

		/// <summary>
		/// Gets or sets the date and time when the single send was created.
		/// </summary>
		/// <value>
		/// The date and time when the single send was created.
		/// </value>
		[JsonPropertyName("created_at")]
		public DateTime? CreatedOn { get; set; }

		/// <summary>
		/// Gets or sets the subject.
		/// </summary>
		/// <value>
		/// The subject.
		/// </value>
		[JsonIgnore]
		public string Subject
		{
			get => EmailConfig.Subject;
			set => EmailConfig.Subject = value;
		}

		/// <summary>
		/// Gets or sets the HTML content.
		/// </summary>
		/// <value>
		/// The HTML content.
		/// </value>
		[JsonIgnore]
		public string HtmlContent
		{
			get => EmailConfig.HtmlContent;
			set => EmailConfig.HtmlContent = value;
		}

		/// <summary>
		/// Gets or sets the plain text content.
		/// </summary>
		/// <value>
		/// The plain text content.
		/// </value>
		[JsonIgnore]
		public string TextContent
		{
			get => EmailConfig.TextContent;
			set => EmailConfig.TextContent = value;
		}

		/// <summary>
		/// Gets or sets a value indicating whether the plain content should be generated.
		/// </summary>
		/// <value>
		/// The generate_plain_content.
		/// </value>
		[JsonIgnore]
		public bool GeneratePlainContent
		{
			get => EmailConfig.GeneratePlainContent;
			set => EmailConfig.GeneratePlainContent = value;
		}

		/// <summary>
		/// Gets or sets the type of editor used in the UI.
		/// </summary>
		/// <value>
		/// The type of editor.
		/// </value>
		[JsonIgnore]
		public EditorType EditorType
		{
			get => EmailConfig.EditorType;
			set => EmailConfig.EditorType = value;
		}

		/// <summary>
		/// Gets or sets the sender identifier.
		/// </summary>
		/// <value>
		/// The sender identifier.
		/// </value>
		[JsonIgnore]
		public long SenderId
		{
			get => EmailConfig.SenderId;
			set => EmailConfig.SenderId = value;
		}

		/// <summary>
		/// Gets or sets the custom unsubscribe URL.
		/// </summary>
		/// <value>
		/// The custom unsubscribe URL.
		/// </value>
		[JsonIgnore]
		public string CustomUnsubscribeUrl
		{
			get => EmailConfig.CustomUnsubscribeUrl;
			set => EmailConfig.CustomUnsubscribeUrl = value;
		}

		/// <summary>
		/// Gets or sets the suppression group identifier.
		/// </summary>
		/// <value>
		/// The suppression group identifier.
		/// </value>
		[JsonIgnore]
		public long? SuppressionGroupId
		{
			get => EmailConfig.SuppressionGroupId;
			set => EmailConfig.SuppressionGroupId = value;
		}

		/// <summary>
		/// Gets or sets the ip pool.
		/// </summary>
		/// <value>
		/// The ip pool.
		/// </value>
		[JsonIgnore]
		public string IpPool
		{
			get => EmailConfig.IpPool;
			set => EmailConfig.IpPool = value;
		}

		/// <summary>
		/// Gets or sets the lists.
		/// </summary>
		/// <value>
		/// The lists.
		/// </value>
		[JsonIgnore]
		public string[] Lists
		{
			get => SendTo.Lists;
			set => SendTo.Lists = value;
		}

		/// <summary>
		/// Gets or sets the segments.
		/// </summary>
		/// <value>
		/// The segments.
		/// </value>
		[JsonIgnore]
		public string[] Segments
		{
			get => SendTo.Segments;
			set => SendTo.Segments = value;
		}

		[JsonPropertyName("email_config")]
		private SingleSendEmailConfig EmailConfig { get; set; }

		[JsonPropertyName("send_to")]
		private SingleSendSendTo SendTo { get; set; }
	}
}
