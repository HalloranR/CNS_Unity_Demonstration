using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Networking;

public class WebRequest : MonoBehaviour
{
    [Header("URL")]
    [SerializeField] string url;

    [Header("DataPoint Prefab")]
    [SerializeField] GameObject spawnObject;

    [Header("JSON elements")]
    [SerializeField] public Data[] data;

    // Start is called before the first frame update
    void Start()
    {
        Request();
    }

    /// <summary>
    /// Async function that grabs the web data and then prints the json file
    /// After it unwraps the json element and places it in a list to look at during runtime
    /// This gets called from start
    /// </summary>
    public async void Request()
    {
        //url variable set in inspector
        using var www = UnityWebRequest.Get(url);

        //set the operation for www
        www.SetRequestHeader("Content-Type", "application/json");

        //operation variable that will modify the www
        var operation = www.SendWebRequest();

        //make the code wait for the operation to respond
        while (!operation.isDone)
            await Task.Yield(); //use async

        //If statement based off of the result
        if (www.result == UnityWebRequest.Result.Success)
        {
            //display the text of the json
            Debug.Log(www.downloadHandler.text);

            //call the json helper to take the array and turn it into a list of type data
            data = JsonConvert.DeserializeObject<Data[]>(www.downloadHandler.text);

            //Pass data to a helper inorder to instantiate the nodes to look at in the inspector
            SpawnData(data);
        }
        else
        {
            //display the error response
            Debug.Log($"Failed: {www.error}");
        }
    }

    /// <summary>
    /// Helper function that loops through the Data list and spawns in GameObjects
    /// The func then copies the data the the points script attached to the gameobject
    /// </summary>
    /// <param name="jlist"></param>
    private void SpawnData(Data[] jlist)
    {
        foreach (Data point in jlist)
        {
            //spawn the prefab in scene
            GameObject creation = Instantiate(spawnObject, new Vector3(0, 0, 0), Quaternion.identity);

            //get the points script
            Points pScript = creation.GetComponent<Points>();

            //convert all the data from a class to the points script
            pScript.Id = point.Id;
            pScript.Type = point.Type;

            pScript.representation_of = point.representation_of;
            pScript.reference_organ = point.reference_organ;
            pScript.scenegraph = point.scenegraph;
            pScript.scenegraphNode = point.scenegraphNode;
            pScript.transformMatrix = point.transformMatrix;
            pScript.color = point.color;
            pScript.opacity = point.opacity;
            pScript.unpickable = point.unpickable;
            pScript._lighting = point._lighting;
            pScript.zoomBasedOpacity = point.zoomBasedOpacity;
            pScript.entityId = point.entityId;
            pScript.ccf_annotations = point.ccf_annotations;
        }
    }
}
