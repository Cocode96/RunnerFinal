using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class ChangeScene : MonoBehaviour
{
    // ��ư�� ������ ����. ��, ����� ��ư�� ���� ����
    public Button startButton;
    //public Button optionButton;
    //public Button shopButton;

    private UnityAction action; // ���1

    void Start()
    {
        // ���1. UnityAction�� ����� �̺�Ʈ ���� ���
        action = () => OnButtonClick(startButton.name);
        startButton.onClick.AddListener(action);

        // ���2. ����޼��带 �̿��� ���
        //optionButton.onClick.AddListener(delegate { OnButtonClick(optionButton.name); });

        // ���3. ���ٽ��� �̿��� ���
        //shopButton.onClick.AddListener(() => OnButtonClick(shopButton.name));

    }

    public void OnButtonClick(string msg)
    {
        Debug.Log($"Click Button: {msg}");
        SceneManager.LoadScene("Scenes/Runner1");
    }
}
