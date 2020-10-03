using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RestartScene : MonoBehaviour
{
    [SerializeField] private float timeReset = 10f;
    [SerializeField] private Text timeText;
    [SerializeField] private Transform player;
    private float timeAtual;
    void Start()
    {
        timeAtual = timeReset;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeAtual > 0f)
        {
            timeAtual -= Time.deltaTime;
            timeText.text = timeAtual.ToString("F");
        }
        else
        {
            timeAtual = timeReset;
            timeText.text = timeAtual.ToString("F");
            player.position = new Vector3(this.transform.position.x, this.transform.position.y, player.position.z);
            player.eulerAngles = Vector3.zero;
        }
    }
}
