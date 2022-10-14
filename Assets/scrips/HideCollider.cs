using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
public class HideCollider : MonoBehaviour
{

    private TilemapRenderer tilemapRender;
    // Start is called before the first frame update
    private void Awake()
    {
        tilemapRender = GetComponent<TilemapRenderer>();
    }

    // Update is called once per frame
    private void Start()
    {
        tilemapRender.enabled = false;
    }
}
