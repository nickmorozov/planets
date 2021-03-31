﻿using UnityEngine;
using System.Collections;

public class NoiseFilterFactory
{
    public static INoiseFilter CreateNoiseFilter(NoiseSettings settings)
    {
        return settings.filterType switch
        {
            NoiseSettings.FilterType.Simple => new SimpleNoiseFilter(settings.simpleNoiseSettings),
            NoiseSettings.FilterType.Rigid => new RigidNoiseFilter(settings.rigidNoiseSettings),
            _ => null,
        };
    }
}
