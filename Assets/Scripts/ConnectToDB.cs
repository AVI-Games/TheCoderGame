using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class ConnectToDB : MonoBehaviour
{
    public TimeScript timer;
    public int timeInLevel, resetsInLevel, starsWon;
    public string apiURL = "http://localhost:5000/api/gameConnect";

    public void Function(){
        timeInLevel = timer.time+timer.beggining_time;
        resetsInLevel = PlayerPrefs.GetInt("resetsInLevel", 0);
        starsWon = PlayerPrefs.GetInt("starsWon", 1);
        StartCoroutine(uploadData());
    }

    IEnumerator uploadData()
    {
        Debug.Log("Time: " + timeInLevel);
        Debug.Log("Resets: " + resetsInLevel);
        Debug.Log("Stars: " + starsWon);
        // Unity sends a form, just as a html form. 
        WWWForm form = new WWWForm();

        // We need to create the form first, by manually adding fields. These fields match the names of the columns in the database.
        // The values from the other scripts is checked here and added to the form.
        form.AddField("timeInLevel", timeInLevel.ToString());
        form.AddField("resetsInLevel", resetsInLevel.ToString());
        form.AddField("starsWon", starsWon.ToString());

        Debug.Log(form);

        // We create a request that makes a post to the url, and sends the form we just created.
        using (UnityWebRequest request = UnityWebRequest.Post(apiURL, form))
        {
            // The yield return line is the point at which execution will pause, and be resumed after the request ends.
            yield return request.SendWebRequest();

            // If there are no errors...
            if (request.isNetworkError || request.isHttpError)
            {
                Debug.Log(request.error);
            }
            else
            {
                // We get the response text and log it in the console.
                Debug.Log(request.downloadHandler.text);
                Debug.Log("Form upload complete!");
            }
        }
    }
}
