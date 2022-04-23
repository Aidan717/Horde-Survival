using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class managerTerrainTex : MonoBehaviour
{

    public Transform trPlayer;
    public Renderer renderTerrain;
    //float tempScroll;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //tempScroll += 0.01f;
        //renderTerrain.material.mainTextureOffset = new Vector2(tempScroll, tempScroll);

        renderTerrain.material.mainTextureOffset = new Vector2(trPlayer.position.x, trPlayer.position.y) * speed;
    }
}
