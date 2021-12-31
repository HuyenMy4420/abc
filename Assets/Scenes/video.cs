using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class video : MonoBehaviour
{
        private void OnCollisionEnter (Collision collision){
        GetComponent<VideoPlayer>().Play();
        }
}
