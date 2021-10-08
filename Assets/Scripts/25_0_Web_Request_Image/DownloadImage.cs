using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

namespace WebRequest_Space
{
    public class DownloadImage : MonoBehaviour
    {
        [SerializeField] private string _url;
        [SerializeField] private RawImage _rawImage;

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                // download an image from Google
                StartCoroutine(DownloadImageRoutine());

            }
        }

        IEnumerator DownloadImageRoutine()
        {
            using (UnityWebRequest request = UnityWebRequestTexture.GetTexture(_url))
            {
                yield return request.SendWebRequest();

                if (request.isHttpError || request.isNetworkError)
                {
                    Debug.LogError(request.error);
                }
                else
                {
                    Debug.Log("Successfully downloaded image!");
                    var texture = DownloadHandlerTexture.GetContent(request);
                    _rawImage.texture = texture;
                }
            }
        }
    } 
}
