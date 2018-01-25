using EPiServer.Core;

namespace Local_EPiServer.Models.Pages
{
    public interface IHasRelatedContent
    {
        ContentArea RelatedContentArea { get; }
    }
}
