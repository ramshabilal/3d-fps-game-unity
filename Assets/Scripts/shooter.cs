using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject decalPrefab;
    public AudioSource fire; // Reference to the AudioSource component

    GameObject[] totalDecals;
    int actualDecal = 0;

    void Start()
    {
        totalDecals = new GameObject[10];
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            if (Physics.Raycast(Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0)), out hit))
            {
                Destroy(totalDecals[actualDecal]);
                totalDecals[actualDecal] = Instantiate(decalPrefab, hit.point + hit.normal * 0.01f, Quaternion.FromToRotation(Vector3.forward, -hit.normal)) as GameObject;

                actualDecal++;
                if (actualDecal == 10) actualDecal = 0;

                // Play the gunshot sound effect
                if (fire != null)
                {
                    fire.Play();
                }
            }
        }
    }
}
