﻿// Copyright (c) Argo Zhang (argo@163.com). All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.
// Website: https://www.blazor.zone or https://argozhang.github.io/

namespace BootstrapBlazor.Components;

/// <summary>
/// BootstrapInputGroupLabel 组件
/// </summary>
public partial class BootstrapInputGroupLabel
{
    private string? ClassString => CssBuilder.Default()
        .AddClass("input-group-text", IsInnerLabel)
        .AddClass("form-label", !IsInnerLabel)
        .AddClassFromAttributes(AdditionalAttributes)
        .Build();

    private bool IsInnerLabel { get; set; }

    /// <summary>
    /// 获得/设置 是否显示必填项标识 默认 false
    /// </summary>
    [Parameter]
    public bool ShowRequiredMark { get; set; }

    private string? Required => ShowRequiredMark ? "true" : null;

    /// <summary>
    /// OnParametersSet 方法
    /// </summary>
    protected override void OnParametersSet()
    {
        base.OnParametersSet();

        IsInnerLabel = InputGroup != null;
    }
}
