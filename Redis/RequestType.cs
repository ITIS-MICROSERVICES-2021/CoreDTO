namespace CoreDTO.Redis
{
    public enum RequestType
    {
        /// <summary> Отпуск </summary>
        Vacation = 0,
        /// <summary> Отгул </summary>
        DayOff = 10,
        /// <summary> Увольнение </summary>
        Dismissal = 20,
        /// <summary> Больничный </summary>
        SickLeave = 30
    }
}