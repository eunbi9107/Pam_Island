using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class MainCamera : MonoBehaviour
{
    static private MainCamera instanceC;
    
    public GameObject target;
    public BoxCollider2D bound;
    public float moveSpeed;

    private Vector3 minBound;
    private Vector3 maxBound;

    private Vector3 minTile;
    private Vector3 maxTile;

    private float halfWidth;
    private float halfHeight;

    private Camera theCamera;

    public Tilemap tilemap;
    
    private void Awake()
    {
        if (instanceC == null)
        {
            DontDestroyOnLoad(this.gameObject);
            theCamera = GetComponent<Camera>();

            minTile = tilemap.CellToWorld(tilemap.cellBounds.min);
            maxTile = tilemap.CellToWorld(tilemap.cellBounds.max);

            halfHeight = theCamera.orthographicSize;
            halfWidth = halfHeight * Screen.width / Screen.height;

            instanceC = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
        
    }
    
    void LateUpdate()
    {
        transform.position = new Vector3(target.transform.position.x, target.transform.position.y, -10f);

        this.transform.position = Vector3.Lerp(this.transform.position, target.transform.position, moveSpeed * Time.deltaTime);

        float clampedX = Mathf.Clamp(this.transform.position.x, minTile.x + halfWidth, maxTile.x - halfWidth);
        float clampedY = Mathf.Clamp(this.transform.position.y, minTile.y + halfHeight, maxTile.y - halfHeight);

        this.transform.position = new Vector3(clampedX, clampedY, this.transform.position.z);
    }
}
