using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeColour : MonoBehaviour {

    private void Start()
    {
        headCurrentOption = PlayerPrefs.GetInt("HeadColour");
        head.color = headOptions[headCurrentOption];
        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            headOption.color = headOptions[headCurrentOption];
            panel.SetActive(false);
        }
    }

    public SpriteRenderer head;
    public Image headOption;

    public Color[] headOptions;

    public int headCurrentOption;

    public GameObject panel;

    public void TogglePanel(bool state)
    {
        panel.SetActive(state);

    }

    public void changeHeadColour(int index)
    {
        headCurrentOption = index;
        PlayerPrefs.SetInt("HeadColour", index);
        head.color = headOptions[headCurrentOption];
        headOption.color = headOptions[headCurrentOption];
    }
}