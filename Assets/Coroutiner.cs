using UnityEngine;
using System.Collections;

public class Coroutiner : MonoBehaviour {

	static Coroutiner instance;

	void Start()
	{
		instance = this;
	}

	public static void RunCoroutine(IEnumerator coroutine) {
		instance.StartCoroutine(coroutine);
	}
}
