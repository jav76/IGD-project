using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayButton : MonoBehaviour
{
    // Start is called before the first frame update

    private Button button;
    private Image image;
    public GameObject playerTank;
    public GameObject text;
    void Start()
    {
        button = GetComponent<Button>();
        image = GetComponent<Image>();
        button.enabled = false;
        image.enabled = false;
        button.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void Update()
    {
        if (playerTank.GetComponent<TankMovement>().Dead == true)
        {
            button.enabled = true;
            image.enabled = true;
            text.GetComponent<Text>().enabled = true;
        }
        else
        {
            button.enabled = false;
            image.enabled = false;
            text.GetComponent<Text>().enabled = false;
        }
    }

    public void TaskOnClick()
    {
        Application.LoadLevel(Application.loadedLevel);
        playerTank.GetComponent<TankMovement>().Dead = false;
    }
}
