using UnityEngine;

public class TriggerUp : MonoBehaviour
{
    public GameObject triggerDown;
    public GameObject _objTriggerUp;

    Spawn spawn;

    private void Start()
    {
        spawn = FindObjectOfType<Spawn>();
    }
    private void OnTriggerEnter(Collider other)
    {
        Vector3 pos = new Vector3(Spawn.elements[0].transform.position.x, Spawn.elements[0].transform.position.y + 16.5f, Spawn.elements[0].transform.position.z);
        GameObject prolet = Instantiate(spawn.prefabUp, pos, Quaternion.identity);
        if(Spawn.elements[2] != null)
        {
            Debug.Log(Spawn.elements[2]);
            Destroy(Spawn.elements[2]);
            Spawn.elements[2] = Spawn.elements[1];
        }
        if (Spawn.elements[1] != null)
        {
            Spawn.elements[1] = Spawn.elements[0];
        }
        Spawn.elements[0] = prolet;


        spawn.FloorUp();
        triggerDown.SetActive(true);
        _objTriggerUp.SetActive(false);
        
    }

}
