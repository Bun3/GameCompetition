using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Managers : MonoBehaviour
{
    private static GameManager game;
    public static GameManager Game{ get { return game; } set { game = value; } }

    private static UiManager ui;
    public static UiManager UI { get { return ui; } set { ui = value; } }

    private void Start()
    {
        game = GetComponent<GameManager>();
        ui = GetComponent<UiManager>();
    }
}
