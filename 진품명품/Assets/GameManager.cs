using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float time = 0;
    [SerializeField]private int score = 0;
    public int Score{ get=>score; set{ score = value; Managers.Ui.scoreText.text = "Score : " + score.ToString(); } }
    public CBCtrl cb;
    public Spawner spawner;

    public GameObject curioObject;

    private void Start()
    {
        StartCoroutine(StartCoroutine(time));
    }

    IEnumerator StartCoroutine(float time)
    {
        yield return new WaitForSeconds(time);
        cb.isGoing = true;
        StartCoroutine(spawner.SpawnerCoroutine(time));
    }

    public void Check(string name)
    {
        if (curioObject.name + "(Clone)" == name) Score++;
        else Score--;
    }
}
