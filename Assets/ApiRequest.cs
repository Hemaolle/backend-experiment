using UnityEngine;
using System.Collections;

public class ApiRequest {

	public static void TestCoroutiner() {
		Coroutiner.RunCoroutine(new ApiRequest().TestRoutine());
	}

	public IEnumerator TestRoutine() {		
		for (int i = 0; i < 5; i++) {
			Debug.Log("Hello");
			yield return new WaitForSeconds(1f);
		}
	}
}
