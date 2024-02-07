using UnityEngine;

public class TriggerDown : MonoBehaviour
{
    public GameObject triggerUp;
    public GameObject _objTriggerDown;

    Spawn spawn;
    private void Start()
    {
        spawn = FindObjectOfType<Spawn>();
    }

    private void OnTriggerEnter(Collider other)
    {
        Vector3 pos = new Vector3(Spawn.elements[2].transform.position.x, Spawn.elements[2].transform.position.y - 16.5f, Spawn.elements[2].transform.position.z);
        GameObject prolet = Instantiate(spawn.prefabDown, pos, Quaternion.identity);
        //Destroy(Spawn.elements[0]); 
        if (Spawn.elements[0] != null)
        {
            Destroy(Spawn.elements[0]);
            Spawn.elements[0] = Spawn.elements[1];
        }
        if (Spawn.elements[1] != null)
        {
            Spawn.elements[1] = Spawn.elements[2];
        }
        Spawn.elements[2] = prolet;

        spawn.FloorDown();
        triggerUp.SetActive(true);
        _objTriggerDown.SetActive(false);
    }
}
