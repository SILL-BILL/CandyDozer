using UnityEngine;
using System.Collections;

public class AutoDestoryEffect : MonoBehaviour {

	ParticleSystem particle;

	// Use this for initialization
	void Start () {

		particle = GetComponent<ParticleSystem> ();

	}
	
	// Update is called once per frame
	void Update () {
	
		//パーティクルの再生が終了したらGameObjectを削除
		if(particle.isPlaying == false) Destroy(gameObject);

	}
}
