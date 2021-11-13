using System;

namespace CoreDTO.Common
{
    public class TgUserDto : IHasId<Guid>
    {
        /// <inheritdoc />
        public Guid Id { get; set; }
    }
}