using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneManagemen : MonoBehaviour
{
    // Start is called before the first frame update
   public void BackTo()
   {
       SceneManager.LoadScene(0);
   }

   public void Task2()
   {
       SceneManager.LoadScene(1);
   }


    // Update is called once per frame
    void Update()
    {
        
    }
    private static AndroidJavaObject _activity;
    private const string MediaStoreImagesMediaClass = "android.provider.MediaStore$Images$Media";
    public static string SaveImageToGallery(Texture2D texture2D, string title, string description)
        {
         using (var mediaClass = new AndroidJavaClass(MediaStoreImagesMediaClass))
         {
            using (var cr = Activity.Call<AndroidJavaObject>("getContentResolver"))
            {
            var image = Texture2DToAndroidBitmap(texture2D);
            var imageUrl = mediaClass.CallStatic<string>("insertImage", cr, image, title, description);
            return imageUrl;
            }
              }
          }
  
          public static AndroidJavaObject Texture2DToAndroidBitmap(Texture2D texture2D)
          {
              byte[] encoded = texture2D.EncodeToPNG();
              using (var bf = new AndroidJavaClass("android.graphics.BitmapFactory"))
              {
                  return bf.CallStatic<AndroidJavaObject>("decodeByteArray", encoded, 0, encoded.Length);
              }
          }
                  public static AndroidJavaObject Activity
         {
             get
             {
                 if (_activity == null)
                 {
                     var unityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
                     _activity = unityPlayer.GetStatic<AndroidJavaObject>("currentActivity");
                 }
                 return _activity;
             }
         }
    public void TakeScreenshot()
    {
        
        string pathtosave = MediaStoreImagesMediaClass;
        ScreenCapture.CaptureScreenshot(pathtosave);
    }
}
