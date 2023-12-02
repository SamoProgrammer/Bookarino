using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using Bookarino.Assets.Scripts.Data.Api.Models;
using UnityEngine;
using UnityEngine.Networking;

namespace Data.Api
{
    public class ApiService : MonoBehaviour

    {
        private List<Clan> _clans= new List<Clan>();
        IEnumerator SearchClans(string query)
        {
            using (UnityWebRequest request =
                   UnityWebRequest.Get($"http://localhost:5188/api/Clans/GetClansByName/{query}"))
            {
                yield return request.SendWebRequest();

                if (request.result == UnityWebRequest.Result.ConnectionError)
                {
                    Debug.Log("Connection Error");
                }
                else
                {
                    string json = request.downloadHandler.text;
                    var clans = JsonUtility.FromJson<List<Clan>>(json);
                    _clans.AddRange(clans);
                }
                
                Debug.Log($"{_clans.Count} received");
            }
            // HttpWebRequest request =
            //     (HttpWebRequest)HttpWebRequest.Create($"http://localhost:5188/api/Clans/GetClansByName/{query}");
            // HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            // StreamReader reader = new StreamReader(response.GetResponseStream());
            // string json = reader.ReadToEnd();
            // return JsonUtility.FromJson<List<Clan>>(json);
        }
    }
}