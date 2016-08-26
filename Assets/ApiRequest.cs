using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class Api {

    private static string serverUrl = "http://127.0.0.1:5000";
    private static Dictionary<string, string> headers = new Dictionary<string, string>();

    static Api() {
        headers.Add("Cookie", "sessionToken=0504625166");
    }

    public static void Request(string resource, Action<string> callback)
    {
        Coroutiner.RunCoroutine(RequestCoroutine(resource, callback));
    }

    public static void Request(string resource, WWWForm form, Action<string> callback)
    {
        Coroutiner.RunCoroutine(RequestCoroutine(resource, form, callback));
    }

    private static IEnumerator RequestCoroutine(string resource, Action<string> callback) {
        yield return RequestCoroutine(new WWW(serverUrl + resource, null, headers), callback);
    }

    private static IEnumerator RequestCoroutine(string resource, WWWForm form, Action<string> callback) {        
        yield return RequestCoroutine(new WWW(serverUrl + resource), callback);
    }

    private static IEnumerator RequestCoroutine(WWW www, Action<string> callback) {
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
