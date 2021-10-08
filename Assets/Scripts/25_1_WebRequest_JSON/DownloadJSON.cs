using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;


namespace WebRequest_JSON_Space
{
    // from catfact.ninja, copy the Response 200 Code from GET (single random cat fact)
    // enter into json2csharp.com to get code for C# data model (rename class Root to  CatFact)
    // JSON:
    // {
    // "fact": "string",
    // "length": 0
    // }
    // C#: change properties to variables and make serializable for JSON mapping
    [System.Serializable]
    public class CatFact
    {
        //public string fact { get; set; }
        public string fact;

        // don't really need this for now
        //public int length { get; set; }
        public int length;
    }

    public class DownloadJSON : MonoBehaviour
    {
        [SerializeField] private string _url;
        private Text _factText;

        private IEnumerator Start()
        {
            _factText = GetComponent<Text>();

            // cleans up after use
            using (UnityWebRequest request = UnityWebRequest.Get(_url))
            {
                // request and wait for the desired page
                yield return request.SendWebRequest();

                if (request.isNetworkError || request.isHttpError)
                {
                    Debug.LogError(request.error);
                }
                else
                {
                    Debug.Log("Success!");

                    var json = request.downloadHandler.text;
                    Debug.Log(json);  // gets JSON text
                    var catFact = JsonUtility.FromJson<CatFact>(json);  // auto maps json data
                    _factText.text = catFact.fact;
                }
            }

        }





        // Update is called once per frame
        void Update()
        {

        }
    } 
}
