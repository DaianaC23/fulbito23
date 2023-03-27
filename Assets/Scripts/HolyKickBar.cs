using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolyKickBar
{
    public float maximumEnergy = 100f;
    public float currentEnergy = 0f;
    public HolyKickBar()
    {
    }

    public void AddEnergy(float amount)
    {
        currentEnergy = Mathf.Min(maximumEnergy, currentEnergy + amount);
    }

    public void StolenEnergy(float amount)
    {
        currentEnergy = Mathf.Max(0f, currentEnergy - amount);
    }
}
