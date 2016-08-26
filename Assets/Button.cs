using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour {

	public void TestCoroutiner()
	{
        Api.Request("/", (response) => Debug.Log(response));
	}
}
