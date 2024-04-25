using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class ChangeScene : MonoBehaviour
{
    // 버튼을 연결할 변수. 즉, 사용할 버튼을 전부 선언
    public Button startButton;
    //public Button optionButton;
    //public Button shopButton;

    private UnityAction action; // 방식1

    void Start()
    {
        // 방식1. UnityAction을 사용한 이벤트 연결 방식
        action = () => OnButtonClick(startButton.name);
        startButton.onClick.AddListener(action);

        // 방식2. 무명메서드를 이용한 방식
        //optionButton.onClick.AddListener(delegate { OnButtonClick(optionButton.name); });

        // 방식3. 람다식을 이용한 방식
        //shopButton.onClick.AddListener(() => OnButtonClick(shopButton.name));

    }

    public void OnButtonClick(string msg)
    {
        Debug.Log($"Click Button: {msg}");
        SceneManager.LoadScene("Scenes/Runner1");
    }
}
