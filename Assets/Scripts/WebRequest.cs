using Newtonsoft.Json;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Networking;

public class WebRequest : MonoBehaviour
{
    [Header("URL")]
    [SerializeField] string url;

    [Header("JSON elements")]
    public Data data;

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

            //Call to the Json Converter to change teh data
            //data = JsonConvert.DeserializeObject<Data>(www.downloadHandler.text);
        }
        else
        {
            //display the error response
            Debug.Log($"Failed: {www.error}");
        }
    }
}
