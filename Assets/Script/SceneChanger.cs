using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("GOOL");
        SceneManager.LoadScene("Scenes/Runner2");
    }

}
