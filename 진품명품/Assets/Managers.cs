using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEngine;

public class Managers : MonoBehaviour
{
    private static GameManager game;
    public static GameManager Game{ get { return game; } set { game = value; } }

    private static UiManager ui;
    public static UiManager Ui { get { return ui; } set { ui = value; } }

    private void Start()
    {
        game = GetComponent<GameManager>();
        ui = GetComponent<UiManager>();
    }
}
