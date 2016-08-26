using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour {

	public void TestCoroutiner()
	{
        Api.Request("/", (response) => Debug.Log(response));
	}

    public void TestLogin() {
        var form = new WWWForm();
        form.AddField("username", "oskari");
        form.AddField("password", "salakala");
        Api.Request("/login", form, (response) => Debug.Log(response));
    }
}
