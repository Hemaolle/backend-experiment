using UnityEngine;
using System;
using System.Collections;

public class Api {

    private static string serverUrl = "http://127.0.0.1:5000";

    public static void Request(string resource, Action<string> callback)
    {
        Coroutiner.RunCoroutine(RequestCoroutine(resource, callback));
    }

    private static IEnumerator RequestCoroutine(string resource, Action<string> callback) {
        var www = new WWW(serverUrl + resource);
        yield return www;
        callback(www.text);
    }

	public static void TestCoroutiner() {
		Coroutiner.RunCoroutine(new Api().TestRoutine());
	}

	public IEnumerator TestRoutine() {		
		for (int i = 0; i < 5; i++) {
			Debug.Log("Hello");
			yield return new WaitForSeconds(1f);
		}
	}
}
