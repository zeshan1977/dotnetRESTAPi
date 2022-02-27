//Dtos . data TrasnferPbject
//REST VERB nd stnaddard response

namespace PlayCatalogService.Dtos
{
    public record ItemDto(Guid id, string Name, string Description, float Price, DateTimeOffset CreatedDate);

    public record CreateItemDto(string Name, string Description, float Price);
    public record UpdateItemDto(string Name, string Description, float Price);
}
