﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Volo.Abp.AuditLogging;
using Volo.Abp.AuditLogging.Blazor.Pages.Shared.AverageExecutionDurationPerDayWidget;
using Volo.Abp.AuditLogging.Blazor.Pages.Shared.ErrorRateWidget;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.BlazoriseUI;
using Volo.Abp.Timing;

namespace PowerBi.Blazor.Pages;

public partial class TenantDashboard
{
    [Inject]
    public IPermissionChecker PermissionChecker { get; set; }
    
    protected List<BreadcrumbItem> BreadcrumbItems = new();

    protected AuditLoggingErrorRateWidgetComponent ErrorRateWidgetComponent;
    
    protected AuditLoggingAverageExecutionDurationPerDayWidgetComponent AverageExecutionDurationPerDayWidgetComponent;
    
    protected DateTime StartDate { get; set; }
    
    
    protected DateTime EndDate { get; set; }

    protected bool HasAuditLoggingPermission { get; set; }
    
    protected async override Task OnInitializedAsync()
    {
        StartDate = Clock.Now.AddMonths(-1).Date;
        EndDate = Clock.Now.Date;
        HasAuditLoggingPermission = await PermissionChecker.IsGrantedAsync(AbpAuditLoggingPermissions.AuditLogs.Default);
        await SetBreadcrumbItemsAsync();
    }
    
    protected virtual async Task RefreshAsync()
    {
        if (HasAuditLoggingPermission)
        {
            await AverageExecutionDurationPerDayWidgetComponent.RefreshAsync();
            await ErrorRateWidgetComponent.RefreshAsync();   
        }
    }

    protected virtual ValueTask SetBreadcrumbItemsAsync()
    {
        BreadcrumbItems.Add(new BreadcrumbItem(L["Dashboard"]));
        return ValueTask.CompletedTask;
    }
}