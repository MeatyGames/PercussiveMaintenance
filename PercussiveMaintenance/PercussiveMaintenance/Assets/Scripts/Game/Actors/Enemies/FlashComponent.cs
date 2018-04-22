using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashComponent : MonoBehaviour
{
    public float FlashsPerSecond;
    public Light[] Lights;
    public float Floor = 0.0f;
    public float Ceiling = 1.0f;
    public Color Color;

    private void Start()
    {
        FlashsPerSecond *= 2 * (Ceiling - Floor);
        Lights = GetComponentsInChildren<Light>(); 
        foreach (var light in Lights)
        {
            light.color = Color;
            light.intensity = Floor;
            light.gameObject.GetComponent<MeshRenderer>().enabled = false;
        }  
    }

    void Update ()
    {
        Flash();
    }

    void Flash()
    {
        foreach(var light in Lights)
        {
            light.intensity = Floor + Mathf.PingPong(Time.time * FlashsPerSecond, Ceiling - Floor);
        }
    }
}
