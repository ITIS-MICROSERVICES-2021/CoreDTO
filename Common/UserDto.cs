using System;

namespace CoreDTO.Common
{
    public class UserDto : IHasId<Guid>
    {
        /// <inheritdoc/>
        public Guid Id { get; set; }

        /// <summary> Роли пользователя </summary>
        public UserRole[] UserRoles { get; set; }

        /// <summary> Ид отдела </summary>
        public Guid DepartmentId { get; set; }
        /// <summary> Ид босса </summary>
        public Guid BossId { get; set; }

        /// <summary> Имя </summary>
        public string FirstName { get; set; }
        /// <summary> Фамилия </summary>
        public string LastName { get; set; }
        /// <summary> Отчество </summary>
        public string Patronymic { get; set; }
    }
}