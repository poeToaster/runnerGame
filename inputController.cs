using UnityEngine;
using System.Collections;

public class inputController_06 : MonoBehaviour {

	private bool isMobile = true;
	private playerHandler _player;

	void Start () {
		if (Application.isEditor)
						isMobile = false;
		_player = GameObject.Find ("Player").GetComponent<playerHandler> ();

	}

	
	// Update is called once per frame
	void Update () {


		if (isMobile) {

			int tmpC = Input.touchCount;
			tmpC--;

			if(Input.GetTouch(tmpC).phase == TouchPhase.Began){
				handleInteraction(true);
			}
			if(Input.GetTouch(tmpC).phase == TouchPhase.Ended){
				handleInteraction(false);
			}

		}else{

			if(Input.GetMouseButtonDown(0)){
				handleInteraction(true);
			}
			if(Input.GetMouseButtonUp(0)){
				handleInteraction(false);
			}

		}

	
	}


	void handleInteraction(bool starting){

		if (starting) {
			_player.jump();
		}else{
			_player.jumpPress=false;
		}


	}





}
