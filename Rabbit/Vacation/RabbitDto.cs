using System;

namespace CoreDTO.Rabbit.Vacation
{
	public abstract class RabbitDto
	{
		/// <summary> Ид реквеста </summary>
		public Guid RequestId { get; set; }
		
		/// <summary> Видимо команда конкретная что нужно сделать </summary>
		/// FIXME: дженериком и строгая типизация
		public string Command { get; set; }
	}
}