using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class sphereScale : MonoBehaviour
{
    public GameObject Sphere;
    public SphereData spheredata;

    [ContextMenu("Load")]
    public void LoadField()
    {
        spheredata = JsonUtility.FromJson<SphereData>(File.ReadAllText(Application.streamingAssetsPath + "/JSON.json"));
        Sphere.transform.localScale = Vector3.one * spheredata.scale;
    }

    [ContextMenu("Save")]
    public void SaveField()
    {
        File.WriteAllText(Application.streamingAssetsPath + "/JSON.json", JsonUtility.ToJson(spheredata));
    }

    [System.Serializable]
    public class SphereData
    {
        public int scale;
        
    }
    
}
