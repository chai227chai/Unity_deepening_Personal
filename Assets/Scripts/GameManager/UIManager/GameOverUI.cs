using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverUI : UIBase
{
    [SerializeField] private TextMeshProUGUI timeText;
    [SerializeField] private GameObject popUp;

    private void Start()
    {
        StartCoroutine("ShowPopUp");
    }

    IEnumerator ShowPopUp()
    {
        timeText.text = GameManager.instance.playTime.ToString("N2");

        while (true)
        {
            popUp.GetComponent<RectTransform>().anchoredPosition = Vector2.Lerp(popUp.GetComponent<RectTransform>().anchoredPosition, Vector2.zero, Time.deltaTime * 1f);
            yield return null;
        }
    }

    public void OnRestartButton()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void OnEndButton()
    {
        SceneManager.LoadScene("StartScene");
    }
}
