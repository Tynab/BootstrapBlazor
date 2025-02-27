﻿// Copyright (c) Argo Zhang (argo@163.com). All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.
// Website: https://www.blazor.zone or https://argozhang.github.io/

namespace BootstrapBlazor.Components;

/// <summary>
/// Table 组件 Excel 导出接口
/// </summary>
public interface ITableExcelExport
{
    /// <summary>
    /// 导出 Excel 方法
    /// </summary>
    /// <param name="items">导出数据集合</param>
    /// <param name="cols">当前可见列数据集合 默认 null 导出全部列</param>
    /// <param name="fileName">文件名 默认 null ExportData_{DateTime.Now:yyyyMMddHHmmss}.xlsx</param>
    Task<bool> ExportAsync<TModel>(IEnumerable<TModel> items, IEnumerable<ITableColumn>? cols, string? fileName = null);

    /// <summary>
    /// 导出 Csv 方法
    /// </summary>
    /// <param name="items">导出数据集合</param>
    /// <param name="cols">当前可见列数据集合 默认 null 导出全部列</param>
    /// <param name="fileName">文件名 默认 null ExportData_{DateTime.Now:yyyyMMddHHmmss}.xlsx</param>
    Task<bool> ExportCsvAsync<TModel>(IEnumerable<TModel> items, IEnumerable<ITableColumn>? cols, string? fileName = null);
}
