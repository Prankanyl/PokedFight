using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonExit : MonoBehaviour
{
    void OnMouseDown()
    {
        transform.localScale = new Vector3(1.05f, 1.05f, 1.05f);
        SceneManager.LoadScene(0);
    }

    void OnMouseUp()
    {
        transform.localScale = new Vector3(1f, 1f, 1f);
    }
}
