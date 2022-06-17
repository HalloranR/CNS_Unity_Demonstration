using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data
{
    //Use Newtonsoft to create a class for the JSON data

    [JsonProperty("@id")]
    public string Id { get; set; }

    [JsonProperty("@type")]
    public string Type { get; set; }
    public string representation_of { get; set; }
    public string reference_organ { get; set; }
    public string scenegraph { get; set; }
    public string scenegraphNode { get; set; }
    public List<double> transformMatrix { get; set; }
    public string tooltip { get; set; }
    public List<double> color { get; set; }
    public double opacity { get; set; }
    public bool unpickable { get; set; }
    public string _lighting { get; set; }
    public bool zoomBasedOpacity { get; set; }
    public string entityId { get; set; }
    public List<string> ccf_annotations { get; set; }
}
