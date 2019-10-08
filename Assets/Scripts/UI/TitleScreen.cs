﻿using UnityEngine;

namespace MermaidCatch {

	public class TitleScreen : Singleton<TitleScreen> {
		
		public void StartSinglePlayer() {
			SceneController.Instance.SwitchScene("SinglePlayer");

			UIEvents.StartGame();

		}
		
		public void StartMultiPlayer() {
			SceneController.Instance.SwitchScene("MultiPlayer");

			UIEvents.StartGame();
			
		}
		
		public void ShowTitleScreen() {
			gameObject.SetActive(true);
		}
		
		void HideTitleScreen() {
			gameObject.SetActive(false);
		}
	}

}
