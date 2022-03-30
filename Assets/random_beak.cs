using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class random_beak : MonoBehaviour
{
    public List<Transform> spawners = new List<Transform>();
    public List<GameObject> barks = new List<GameObject>();
    public List<GameObject> bodies = new List<GameObject>();
    public GameObject amogus;
    void Start()
    {
        if(birdsholder.birdsnum == 6)
        {
            Instantiate(amogus);
        }
        int[] listdeletespawner = {0, 2, 0, 1, 1, 2 };
        int rightbark = birdsholder.birdsnum;
        Debug.Log(rightbark);
        Instantiate(bodies[rightbark], transform);

        int deletespawner = listdeletespawner[birdsholder.birdsnum];
        Debug.Log(deletespawner);
        Instantiate(barks[rightbark], spawners[deletespawner]);
        spawners.RemoveAt(deletespawner);

        barks.RemoveAt(rightbark);
        int i = Random.Range(0, barks.Count);
        Instantiate(barks[i], spawners[0]);
        barks.RemoveAt(i);
        int o = Random.Range(0, barks.Count);
        Instantiate(barks[o], spawners[1]);
        barks.RemoveAt(o);
    }
    public void nextbird()
    {
        birdsholder.addbirdnum();
        SceneManager.LoadScene("birds");
    }
}
