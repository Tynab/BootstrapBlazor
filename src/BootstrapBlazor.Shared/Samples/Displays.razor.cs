﻿// Copyright (c) Argo Zhang (argo@163.com). All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.
// Website: https://www.blazor.zone or https://argozhang.github.io/

namespace BootstrapBlazor.Shared.Samples;

/// <summary>
/// Display 组件示例
/// </summary>
public partial class Displays
{
    private IEnumerable<int> IntValue { get; set; } = new[] { 1, 2, 3 };

    private string DisplayValue => "Text1; Text2; Text3; Text4; Text5;";

    private IEnumerable<SelectedItem> IntValueSource { get; set; } = new[]
    {
        new SelectedItem("1", "Text1"),
        new SelectedItem("2", "Text2"),
        new SelectedItem("3", "Text3")
    };

    private static Task<string> DateTimeFormatter(DateTime source) => Task.FromResult(source.ToString("yyyy-MM-dd"));

    private static async Task<string> ByteArrayFormatter(byte[] source)
    {
        await Task.Delay(10);
        return Convert.ToBase64String(source);
    }

    [NotNull]
    private IEnumerable<SelectedItem>? Hobbies { get; set; }

    private byte[] ByteArray { get; set; } = { 0x01, 0x12, 0x34, 0x56 };

    /// <summary>
    /// Foo 类为Demo测试用，如有需要请自行下载源码查阅
    /// Foo class is used for Demo test, please download the source code if necessary
    /// https://gitee.com/LongbowEnterprise/BootstrapBlazor/blob/main/src/BootstrapBlazor.Shared/Data/Foo.cs
    /// </summary>
    [NotNull]
    private Foo? Model { get; set; }

    [Inject]
    [NotNull]
    private IStringLocalizer<Foo>? FooLocalizer { get; set; }

    /// <summary>
    /// OnInitialized 方法
    /// </summary>
    protected override void OnInitialized()
    {
        base.OnInitialized();

        Model = Foo.Generate(FooLocalizer);
        Model.Hobby = Foo.GenerateHobbies(FooLocalizer).Take(3).Select(i => i.Text);
        Hobbies = Foo.GenerateHobbies(FooLocalizer);
    }

    private IEnumerable<AttributeItem> GetAttributes() => new AttributeItem[]
    {
        new()
        {
            Name = "ShowLabel",
            Description = Localizer["ShowLabel"],
            Type = "bool",
            ValueList = "true|false",
            DefaultValue = "false"
        },
        new()
        {
            Name = "DisplayText",
            Description = Localizer["DisplayText"],
            Type = "string",
            ValueList = " — ",
            DefaultValue = " — "
        },
        new()
        {
            Name = "FormatString",
            Description = Localizer["FormatString"],
            Type = "string",
            ValueList = " — ",
            DefaultValue = " — "
        },
        new()
        {
            Name = "Formatter",
            Description = Localizer["Formatter"],
            Type = "RenderFragment<TItem>",
            ValueList = " — ",
            DefaultValue = " — "
        },
        new()
        {
            Name = nameof(Display<string>.TypeResolver),
            Description = Localizer["TypeResolver"],
            Type = "Func<Assembly?, string, bool, Type?>",
            ValueList = " — ",
            DefaultValue = " — "
        }
    };
}
