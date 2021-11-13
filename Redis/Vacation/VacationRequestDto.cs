namespace CoreDTO.Redis.Vacation
{
    public class VacationRequestDto : RequestDto<VacationRequestStatus, VacationPayload>
    {
        /// <inheritdoc/>
        public override RequestType RequestType { get; set; } = RequestType.Vacation;
    }
}