#nullable disable

using System.Collections.Generic;
using Jellyfin.Data.Entities;
using MediaBrowser.Controller.Entities;
using MediaBrowser.Model.Dto;

namespace MediaBrowser.Controller.Dto
{
    /// <summary>
    /// Interface IDtoService.
    /// </summary>
    public interface IDtoService
    {
        /// <summary>
        /// Gets the primary image aspect ratio.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns>System.Nullable&lt;System.Double&gt;.</returns>
        double? GetPrimaryImageAspectRatio(BaseItem item);

        /// <summary>
        /// Gets the base item dto.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <param name="options">The options.</param>
        /// <param name="user">The user.</param>
        /// <param name="owner">The owner.</param>
        /// <returns>BaseItemDto.</returns>
        BaseItemDto GetBaseItemDto(BaseItem item, DtoOptions options, User user = null, BaseItem owner = null);

        /// <summary>
        /// Gets the base item dtos.
        /// </summary>
        /// <param name="items">The items.</param>
        /// <param name="options">The options.</param>
        /// <param name="user">The user.</param>
        /// <param name="owner">The owner.</param>
        IReadOnlyList<BaseItemDto> GetBaseItemDtos(IReadOnlyList<BaseItem> items, DtoOptions options, User user = null, BaseItem owner = null);

        /// <summary>
        /// Gets the item by name dto.
        /// </summary>
        BaseItemDto GetItemByNameDto(BaseItem item, DtoOptions options, List<BaseItem> taggedItems, User user = null);
    }
}
