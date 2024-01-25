using System;
using System.Collections.Generic;

public class CompositeDoorCommand
{
    private List<Action> features = new List<Action>();

    public void AddFeature(Action feature)
    {
        features.Add(feature);
    }

    public void ExecuteFeatures()
    {
        foreach (var feature in features)
        {
            feature.Invoke();
        }
    }
}
