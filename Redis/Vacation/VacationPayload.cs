using System;

namespace CoreDTO.Redis.Vacation
{
    public class VacationPayload
    {
        /// <summary> Отпуск с </summary>
        public DateTimeOffset DateFrom { get; set; }
        /// <summary> Отпуск по </summary>
        public DateTimeOffset DateTo { get; set; }
    }
}