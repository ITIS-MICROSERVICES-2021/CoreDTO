namespace CoreDTO.Common
{
    public interface IHasId<T>
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public T Id { get; set; }
    }
}