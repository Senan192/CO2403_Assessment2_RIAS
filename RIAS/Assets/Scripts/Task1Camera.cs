//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class Task1Camera : MonoBehaviour
//{
//    public GameObject Cam1;
//    public GameObject Cam2;
//    public int manager;

   
//    public void managerF()
//    {
//        if(manager == 0)
//        {
//            camSet1();
//            manager = 1;
//        }
//        else
//        {
//            camSet2();
//            manager = 0;
//        }
//    }

//    void camSet1()
//    {
//        Cam1.SetActive(true);
//        Cam2.SetActive(false);
//    }

//    void camSet2()
//    {
//        Cam1.SetActive(false);
//        Cam2.SetActive(true);
//    }

//}

 using UnityEngine;
 using System.Collections;
 
 public class Task1Camera : MonoBehaviour
{
    public GameObject camera1;
    public GameObject camera2;
    //public GameObject camera3;
    //public GameObject camera4;
    void Start()
    {
        camera1.SetActive(true);
        camera2.SetActive(false);
        //camera3.SetActive(false);
        //camera4.SetActive(false);
    }

    public void EnableCamera1()
    {
        camera1.SetActive(true);
        camera2.SetActive(false);
        //camera3.SetActive(false);
        //camera4.SetActive(false);
    }
    public void EnableCamera2()
    {
        camera1.SetActive(false);
        camera2.SetActive(true);
        //camera3.SetActive(false);
        //camera4.SetActive(false);
    }
    //public void EnableCamera3()
    //{
    //    camera1.SetActive(false);
    //    camera2.SetActive(false);
    //    camera3.SetActive(true);
    //    //camera4.SetActive(false);
    //}
    //public void EnableCamera4()
    //{
    //    camera1.SetActive(false);
    //    camera2.SetActive(false);
    //    camera3.SetActive(false);
    //    camera4.SetActive(true);
    //}
}
