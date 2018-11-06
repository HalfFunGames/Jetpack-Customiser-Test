using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ChangeBodyType : MonoBehaviour {

    private void Start()
    {
        index = PlayerPrefs.GetInt("BodyType");
        bodyComponent.sprite = bodyTypes[index];
        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            bodyTypeDescriptor.text = bodyTypeDescriptions[index];
        }
    }

    public Sprite[] bodyTypes;
    public SpriteRenderer bodyComponent;
    public int index;

    public string[] bodyTypeDescriptions;
    public TextMeshProUGUI bodyTypeDescriptor;

    private void Update()
    {
        
    }

    public void Swap()
    {
        if (index < bodyTypes.Length - 1)
        {
            index++;
        }
        else
        {
            index = 0;
        }
        PlayerPrefs.SetInt("BodyType", index);
        bodyComponent.sprite = bodyTypes[index];
        bodyTypeDescriptor.text = bodyTypeDescriptions[index];
    }

}
