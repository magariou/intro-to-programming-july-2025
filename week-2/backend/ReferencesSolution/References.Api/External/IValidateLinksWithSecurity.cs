namespace References.Api.External;
using Shared;

public interface IValidateLinksWithSecurity
{
    Task<LinkValidationResponse> ValidateLinkAsync(LinkValidationRequest request);
}


