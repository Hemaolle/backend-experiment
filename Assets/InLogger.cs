using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class InLogger : MonoBehaviour {

    public void Login(InputField usernameField) {
        Api.Username = usernameField.text;
    }
}
