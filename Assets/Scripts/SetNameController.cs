using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SetNameController : MonoBehaviour
{
    public TextMeshProUGUI user_name;
    public TMP_InputField user_input_field;
    private GameManager gameManager;

    void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    public void SetName()
    {
        gameManager.StartGame();
        user_name.text = "Hello, " + user_input_field.text + " !";
    }
}
