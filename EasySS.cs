using UnityEngine;

public class EasySS : MonoBehaviour {
	public int frameRate = 25;
	public int sizeMultiplier = 1;
  //Rename the savePath for the root your want.
	public string savePath = "";

	public void TakePicture () {
		System.IO.DirectoryInfo df = new System.IO.DirectoryInfo (savePath);
		if (!df.Exists)
			System.IO.Directory.CreateDirectory (savePath);

		Time.captureFramerate = frameRate;
		var name = string.Format ("{0}/ss {1:D04}.png", savePath, Time.frameCount);
		ScreenCapture.CaptureScreenshot (name, sizeMultiplier);
	}

}
