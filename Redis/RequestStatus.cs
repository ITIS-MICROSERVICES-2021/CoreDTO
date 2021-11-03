namespace CoreDTO.Redis
{
	public enum RequestStatus
	{
		Rejected = 0,
		Started = 10,
		BossReview = 20,
		BookKeepReview = 30,
		Finished = 100,
	}
}