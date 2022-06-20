using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
    //these are the values that the Json file class will be converted to inorder to spawn a gameobject
    [JsonProperty("@id")]
    public string Id;

    [JsonProperty("@type")]
    public string Type;

    public string representation_of;
    public string reference_organ;
    public string scenegraph;
    public string scenegraphNode;
    public List<double> transformMatrix;
    public string tooltip;
    public List<double> color;
    public double opacity;
    public bool unpickable;
    public string _lighting;
    public bool zoomBasedOpacity;
    public string entityId;
    public List<string> ccf_annotations;
}
