using System;
using System.Collections.Generic;

namespace CoreDTO.Redis
{
	/// <summary>
	/// Заявка, поданная через бота 
	/// </summary>
	public class RequestDto
	{
		/// <summary>
		/// Уникальны идентификатор запроса
		/// </summary>
		public Guid Id { get; set; }
		/// <summary>
		/// Текущий статус запроса
		/// </summary>
		public RequestStatus Status { get; set; }
		/// <summary>
		/// Дата подачи заявки
		/// </summary>
		public DateTimeOffset StartAt { get; set; }
		/// <summary>
		/// Дата завершения заявки
		/// </summary>
		public DateTimeOffset EndAt { get; set; }
		/// <summary>
		/// Автор заявки
		/// </summary>
		public string Author { get; set; }
		/// <summary>
		/// Причина отказа
		/// </summary>
		public string RejectedReason { get; set; }
		/// <summary>
		/// Payload by services
		/// </summary>
		public Dictionary<string,string> Values { get; set; }
		/// <summary>
		/// Файлы
		/// </summary>
		public Dictionary<string, byte[]> Attachments { get; set; }
	}
}