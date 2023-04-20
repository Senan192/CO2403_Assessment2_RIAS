using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BedRoomScript : MonoBehaviour
{
    public void NextPage() => SceneManager.LoadScene("GameMap");
}

