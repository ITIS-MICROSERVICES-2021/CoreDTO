using System;
using System.Collections.Generic;
using CoreDTO.Common;

namespace CoreDTO.Redis
{
	/// <summary> Заявка, поданная через бота  </summary>
	public class RequestDto<TStatus, TPayload> : IHasId<Guid>
	{
		/// <summary> Уникальный идентификатор запроса </summary>
		public Guid Id { get; set; }
		
		/// <summary> Тип заявки </summary>
		public virtual RequestType RequestType { get; set; }
		
		/// <summary> Автор заявки </summary>
		public string Author { get; set; }
		/// <summary> Дата подачи заявки </summary>
		public DateTimeOffset StartAt { get; set; }
		/// <summary> Дата завершения заявки </summary>
		public DateTimeOffset EndAt { get; set; }
		
		/// <summary> Текущий статус запроса </summary>
		public TStatus Status { get; set; }
		
		/// <summary> Причина отказа </summary>
		public string RejectReason { get; set; }
		
		/// <summary> Payload by services </summary>
		public TPayload Payload { get; set; }
		/// <summary> Файлы </summary>
		public Dictionary<string, byte[]> Attachments { get; set; }
	}
}