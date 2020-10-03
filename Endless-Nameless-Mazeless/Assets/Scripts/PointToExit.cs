using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointToExit : MonoBehaviour
{
    [SerializeField] private Transform exit;
    [SerializeField] private Transform player;
    private RectTransform rt;
    void Awake()
    {
        rt = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 aponta = exit.position - player.position;
        float ang = Mathf.Atan2(aponta.y, aponta.x) * Mathf.Rad2Deg - 90f;
        rt.eulerAngles = new Vector3(0, 0, ang);
    }
}
