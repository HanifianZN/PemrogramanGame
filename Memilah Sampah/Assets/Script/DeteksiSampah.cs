using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeteksiSampah : MonoBehaviour{
    public string nametag;
    public AudioClip audiobenar;
    public AudioClip audiosalah;
    public AudioSource MediaPlayerBenar;
    private AudioSource MediaPlayerSalah;
    public Text textscore;

    // Start is called before the first frame update
    void Start(){
        MediaPlayerBenar = gameObject.AddComponent < AudioSource >();
        MediaPlayerBenar.clip = audiobenar;

        MediaPlayerSalah = gameObject.AddComponent<AudioSource>();
        MediaPlayerSalah.clip = audiosalah;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals(nametag))
        {
            Data.score += 25;
            textscore.text = Data.score.ToString();
            Destroy(collision.gameObject);
            MediaPlayerBenar.Play();
        }
        else
        {
            Data.score -= 5;
            textscore.text = Data.score.ToString();
            Destroy(collision.gameObject);
            MediaPlayerSalah.Play();
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
