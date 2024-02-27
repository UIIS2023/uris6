﻿namespace DocumentAPI.Models
{
	/// <summary>
	/// Document status model
	/// </summary>
	public class StatusOfDocumentDto
	{
		/// <summary>
		/// ID of document status
		/// </summary>
		public Guid statusOfDocumentId { get; set; }

		/// <summary>
		/// Indicates whether the document is adopted
		/// </summary>
		public bool adopted { get; set; }

		/// <summary>
		/// Indicates whether the document is rejected
		/// </summary>
		public bool rejected { get; set; }

		/// <summary>
		/// Indicates whether the document is open
		/// </summary>
		public bool opened { get; set; }

		/// <summary>
		/// Indicates whether the document has been modified
		/// </summary>
		public bool modified { get; set; }
	}
}
