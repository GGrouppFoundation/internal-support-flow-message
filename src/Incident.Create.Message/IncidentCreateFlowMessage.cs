using System;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace GGroupp.Internal.Support;

public sealed record class IncidentCreateFlowMessage
{
    public IncidentCreateFlowMessage(
        Guid ownerId,
        Guid customerId,
        Guid? contactId,
        string title,
        [AllowNull] string description,
        IncidentCaseTypeCode caseTypeCode,
        IncidentPriorityCode priorityCode,
        Guid? callerUserId)
    {
        OwnerId = ownerId;
        CustomerId = customerId;
        ContactId = contactId;
        Title = title ?? string.Empty;
        Description = string.IsNullOrEmpty(description) ? null : description;
        CaseTypeCode = caseTypeCode;
        PriorityCode = priorityCode;
        CallerUserId = callerUserId;
    }

    [JsonPropertyName("ownerId")]
    public Guid OwnerId { get; }

    [JsonPropertyName("customerId")]
    public Guid CustomerId { get; }

    [JsonPropertyName("contactId")]
    public Guid? ContactId { get; }

    [JsonPropertyName("title")]
    public string Title { get; }

    [JsonPropertyName("description")]
    public string? Description { get; }

    [JsonPropertyName("caseTypeCode")]
    public IncidentCaseTypeCode CaseTypeCode { get; }

    [JsonPropertyName("priorityCode")]
    public IncidentPriorityCode PriorityCode { get; }

    [JsonPropertyName("callerUserId")]
    public Guid? CallerUserId { get; }
}