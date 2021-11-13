namespace CoreDTO.Redis.Vacation
{
	public enum VacationRequestStatus
	{
		/// <summary> Заявка отклонена </summary>
		Rejected = 0,
		/// <summary> Заявка начата </summary>
		Started = 10,
		/// <summary> Заявка на ревью у босса </summary>
		BossReview = 20,
		/// <summary> Заявка на ревью у бухгалтера </summary>
		BookKeepReview = 30,
		/// <summary> Заявка завершена </summary>
		Finished = 100,
	}
}