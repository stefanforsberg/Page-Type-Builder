﻿using EPiServer.Core.PropertySettings;

namespace PageTypeBuilder
{
    public interface IUpdatePropertySettings<T> where T : IPropertySettings, new()
    {
        void UpdateSettings(T settings);
        int GetSettingsHashCode(T settings);
        bool OverWriteExistingSettings { get; }
    }
}