using System;
using DeliveryService.Delivery.BusinessLogic.Services.Delivery.Contracts.Dto;


namespace DeliveryService.Delivery.BusinessLogic.Services.Delivery.Abstractions
{
    public interface IDeliveryService
    {
        /// <summary>
        /// Создать доставку.
        /// </summary>
        /// <param name="createDeliveryDto"> Dto создаваемой доставки. </param>
        public Task<Guid> CreateAsync(CreateDeliveryDto createDeliveryDto);

        /// <summary>   
        /// Получить доставку по id.
        /// </summary>
        /// <param name="id"> Идентификатор доставки. </param>
        /// <returns> Dto доставки.</returns>
        public Task<DeliveryDto> GetByIdAsync(Guid id);

        /// <summary>
        /// Изменить доставку по id.
        /// </summary>
        /// <param name="id"> Иентификатор доставки. </param>
        /// <param name="updateDeliveryDto"> Dto редактируемой доставки. </param>
        public Task<bool> TryUpdateAsync(Guid id, updateDeliveryDto updateDeliveryDto);

        /// <summary>
        /// Удалить доставку.
        /// </summary>
        /// <param name="id"> Идентификатор доставки. </param>
        public Task<bool> TryDeleteAsync(Guid id);
    }
}
