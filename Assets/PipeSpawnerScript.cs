using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject pipe;
    public float timer = 0;
    public float spawnRate = 2;
    public float heightOffSet = 10;
    private Camera mainCamera;
    void Start()
    {
        // Lấy camera chính
        mainCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        spawnPipe();
        
    }
    void spawnPipe()
    {
        // Tính chiều cao và chiều rộng của camera
        float cameraHeight = 2f * mainCamera.orthographicSize;
        float cameraWidth = cameraHeight * mainCamera.aspect;

        float lowestPoint = transform.position.y - heightOffSet;
        float highestPoint = transform.position.y + heightOffSet;
        lowestPoint = Mathf.Max(lowestPoint, mainCamera.transform.position.y - (cameraHeight / 2) + heightOffSet);
        highestPoint = Mathf.Min(highestPoint, mainCamera.transform.position.y + (cameraHeight / 3) - heightOffSet);
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            float spawnY = Random.Range(lowestPoint, highestPoint);
            Instantiate(pipe, new Vector3(transform.position.x,Random.Range(lowestPoint, highestPoint),0), transform.rotation);
            timer = 0;
        }
    }
}
