using System;

namespace CoreDTO.Rabbit
{
	public abstract class RabbitDto
	{
		
		public Guid RequestId { get; set; }
		
		public string Command { get; set; }
	}
}