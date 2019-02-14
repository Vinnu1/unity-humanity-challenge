using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Floor : MonoBehaviour
{

    private TilemapCollider2D _tilemap;

    void Start()
    {
        _tilemap = GetComponent<TilemapCollider2D>();
    }


    // Start is called before the first frame update
    public void DisableCollider()
    {
        _tilemap.enabled = false;
    }
}
