﻿// Copyright (c) 2021 Jose Torres. All rights reserved. Licensed under the Apache License, Version 2.0. See LICENSE.md file in the project root for full license information.

namespace AudioDeviceSwitcher;

using System.Threading.Tasks;

public interface IO
{
    public Task ShowMessageAsync(string title, string message);
    public Task<string?> GetMessageAsync(string message, string defaultValue = "");
    public Task ShowNotification(string message);
}
